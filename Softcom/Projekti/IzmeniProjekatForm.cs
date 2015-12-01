using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NHibernate;
using DataLayer.Entiteti;
using DataLayer.Mapiranja;
using Softcom.Helpers;

namespace Softcom.Projekti
{
    public partial class IzmeniProjekatForm : Form
    {

        public int pid { get; set; }
        private Form sviProjekti;

        public IzmeniProjekatForm(int pid, Form parent)
        {
            InitializeComponent();
            this.pid = pid;
            this.sviProjekti = parent;
        }

        private void IzmeniProjekatForm_Load(object sender, EventArgs e)
        {
            // Inicijalno ucitavanje projekta
            ISession sesija = DataLayer.DataLayer.GetSession();
            Projekat proj = sesija.Load<Projekat>(pid);

            try
            {

                // Ucitavanje svih sefova za dropdown list
                IQuery sql = sesija.CreateQuery("FROM Zaposleni as z WHERE z.pozicija LIKE ? ");
                sql.SetString(0, "%senior%");
                IList<Zaposleni> seniori = sql.List<Zaposleni>();

                // Ispisivanje svih sefova u dropdown list
                foreach (Zaposleni senior in seniori)
                {
                    leaderList.Items.Add(new DropDownItem(senior.ime + " " + senior.prezime, senior.ZID.ToString()));
                }

                foreach (var red in proj.radnici)
                {
                    listRadnika.Items.Add(new DropDownItem(red.radnik.ime + " " + red.radnik.prezime, red.radnik.ZID.ToString() ));
                }
                // Datumi
                datumOd.Value = proj.datumPocetka;
                datumDo.Value = proj.datumZavrsetka;


                // Postavljanje imena projekta
                nazivProjekta.Text = proj.ime;

                // Selektovanje tipa izrade
                if (proj.izrada == "insource")
                {
                    tipIzrade.SelectedIndex = 0;

                    // Trenutni sef projekta
                    Zaposleni leader = proj.trenutniLeader.sef;

                    // Datumi
                    vodiOdDatePicker.Value = proj.vodi[0].vodiOd;
                    vodiDoDatePicker.Value = proj.vodi[0].vodiDo;
                   
                    // Selektovanje trenutnog sefa
                    leaderList.SelectedIndex = leaderList.FindStringExact(leader.ime + " " + leader.prezime);

                }
                else if (proj.izrada == "outsource")
                {
                    tipIzrade.SelectedIndex = 1;
                    imeFirme.Text = proj.nazivFirme;
                    adresaFirme.Text = proj.adresaFirme;
                }
                else
                {
                    throw new Exception("Pogresan tip projekta");
                }

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            sesija.Close();
           
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tipIzrade_SelectedIndexChanged(object sender, EventArgs e)
        {   
            // Ako je insource
            if (tipIzrade.SelectedIndex == 0)
            {
                leaderList.Enabled = true;
                vodiOdDatePicker.Enabled = true;
                vodiDoDatePicker.Enabled = true;
                imeFirme.Enabled = false;
                adresaFirme.Enabled = false;
            }
            // Ako je outsource
            else if (tipIzrade.SelectedIndex == 1)
            {
                leaderList.Enabled = false;
                imeFirme.Enabled = true;
                adresaFirme.Enabled = true;
                vodiOdDatePicker.Enabled = false;
                vodiDoDatePicker.Enabled = false;
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                ISession sesija = DataLayer.DataLayer.GetSession();

                Projekat projekat = sesija.Load<Projekat>(pid);

                projekat.ime = nazivProjekta.Text;
                projekat.datumPocetka = datumOd.Value;
                projekat.datumZavrsetka = datumDo.Value;

                // Ako je insource
                if (tipIzrade.SelectedIndex == 0)
                {
                    projekat.izrada = "insource";

                    var SefID = ((DropDownItem)leaderList.SelectedItem).NumVal;
                    var sef = sesija.Load<Zaposleni>(SefID);

                    // Uzima zadnji zapis o vodjenju projekta
                    IQuery sql = sesija.CreateQuery("FROM Vodi as v WHERE v.projekat = ? ORDER BY LOCID DESC");
                    sql.SetInt32(0, pid);

                    // Trenutni lider projekta
                    IList<Vodi> vodiAtm = sql.List<Vodi>();

                    // Submitovan objekat Vodi
                    Vodi newVodi = new Vodi() { sef = sef, projekat = projekat, vodiOd = vodiOdDatePicker.Value, vodiDo = vodiDoDatePicker.Value };

                    // Ako postoji vec zapis za ovaj projekat
                    if (vodiAtm.Count > 0)
                    {
                        // Ako je ovaj sef poslednji vodio ovaj projekat, samo ga update
                        if (vodiAtm[0].sef.ZID == SefID)
                        {
                            vodiAtm[0].vodiOd = vodiOdDatePicker.Value;
                            vodiAtm[0].vodiDo = vodiDoDatePicker.Value;
                            sesija.Update(vodiAtm[0]);
                        }
                        // Ako je ovaj sef vec vodio ovaj projekat, a ne vodi ga trenutno, dodaj novi zapis
                        else
                        {
                            sesija.Save(newVodi);
                        }
                    }
                    // Ako prvi put vodi ovaj projekat, napravi novi zapis
                    else
                    {
                        sesija.Save(newVodi);
                    }

                    // Brisanje starih zapisa o outsource projektu ( u slucaju da projekat menja tip )
                    projekat.nazivFirme = null;
                    projekat.adresaFirme = null;


                }
                // Ako je outsource
                else if (tipIzrade.SelectedIndex == 1)
                {
                    projekat.izrada = "outsource";
                    projekat.nazivFirme = imeFirme.Text;
                    projekat.adresaFirme = adresaFirme.Text;

                    // Brisanje starih zapisa o insource projektu ( u slucaju da projekat menja tip )
                    projekat.vodi = null;

                    sesija.SaveOrUpdate(projekat);
                }

                sesija.Flush();
                sesija.Close();

                // Reload main form
                ((SviProjektiForm)this.sviProjekti).loadFormData();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void addRadnikaBtn_Click(object sender, EventArgs e)
        {
            Form addRadnik = new DodajRadnikaNaProjekatForm(this);
            addRadnik.MdiParent = this.MdiParent;
            addRadnik.Show();
        }

        private void listRadnika_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void delRadnikBtn_Click(object sender, EventArgs e)
        {
            try
            {
                ISession sesija = DataLayer.DataLayer.GetSession();

                if (listRadnika.SelectedItems.Count > 0)
                {
                    Zaposleni zap = sesija.Load<Zaposleni>(((DropDownItem)listRadnika.SelectedItem).NumVal);
                    Projekat proj = sesija.Load<Projekat>(pid);
                    
                    IQuery sql = sesija.CreateQuery("FROM RadiNa WHERE ZID = ? AND PID = ?");
                    sql.SetInt32(0, zap.ZID);
                    sql.SetInt32(1, proj.PID);

                    IList<RadiNa> radi = sql.List<RadiNa>();

                    sesija.Delete(radi[0]);
                    sesija.Flush();
                    listRadnika.Items.Remove(listRadnika.SelectedItem);
                }
                else
                {
                    throw new Exception("Selektujte radnika");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
