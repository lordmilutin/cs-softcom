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
using Softcom.Helpers;

namespace Softcom.Projekti
{
    public partial class DodajProjekat : Form
    {
        public DodajProjekat()
        {
            InitializeComponent();
        }

        private void DodajProjekat_Load(object sender, EventArgs e)
        {

            ISession sesija = DataLayer.DataLayer.GetSession();

            // Lista sefova
            IQuery sql = sesija.CreateQuery("FROM Zaposleni as z WHERE z.pozicija LIKE ? ");
            sql.SetString(0, "%senior%");
            IList<Zaposleni> seniori = sql.List<Zaposleni>();

            // Ispisivanje svih sefova u dropdown list
            foreach (Zaposleni senior in seniori)
            {
                leaderList.Items.Add(new DropDownItem(senior.ime + " " + senior.prezime, senior.ZID.ToString() ));
            }

            // Popuni listu svih radnika
            IQuery sql2 = sesija.CreateQuery("FROM Zaposleni ");
            IList<Zaposleni> zap = sql2.List<Zaposleni>();

            foreach (var red in zap)
            {
                listRadnika.Items.Add(new DropDownItem(red.ime + " " + red.prezime, red.ZID.ToString() ));
            }


            sesija.Close();
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

        private void dodajRadnikaBtn_Click(object sender, EventArgs e)
        {
            if (listRadnika.SelectedItems.Count > 0)
            {
                radeNaProjektuList.Items.Add(listRadnika.SelectedItem);
                listRadnika.Items.Remove(listRadnika.SelectedItem);
            }
        }

        private void ukloniRadnikaBtn_Click(object sender, EventArgs e)
        {
            if (radeNaProjektuList.SelectedItems.Count > 0)
            {
                listRadnika.Items.Add(radeNaProjektuList.SelectedItem);
                radeNaProjektuList.Items.Remove(radeNaProjektuList.SelectedItem);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            SviProjektiForm pF = new SviProjektiForm();
            pF.MdiParent = this.MdiParent;
            pF.Show();
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                ISession sesija = DataLayer.DataLayer.GetSession();

                Projekat proj = new Projekat();

                if (nazivProjekta.Text == "")
                    throw new Exception("Unesite ime projekta!");
                else
                    proj.ime = nazivProjekta.Text;
                proj.datumPocetka = datumOd.Value;
                proj.datumZavrsetka = datumDo.Value;

                // Insource projekat
                if (tipIzrade.SelectedIndex == 0)
                {
                    proj.izrada = "insource";

                    if (leaderList.SelectedIndex == -1)
                        throw new Exception("Izaberite vođu projekta");

                    var SefID = ((DropDownItem)leaderList.SelectedItem).NumVal;
                    var sef = sesija.Load<Zaposleni>(SefID);

                    Vodi vodi = new Vodi() { sef = sef, projekat = proj, vodiOd = vodiOdDatePicker.Value, vodiDo = vodiDoDatePicker.Value };
                    proj.vodi.Add(vodi);
                //    sesija.Save(vodi);
                }
                else if (tipIzrade.SelectedIndex == 1)
                {
                    proj.izrada = "outsource";
                    proj.nazivFirme = imeFirme.Text;
                    proj.adresaFirme = adresaFirme.Text;
                }
                else
                {
                    throw new Exception("Izaberite tip izrade!");
                }
                
                // Dodavanje radnika na projekat
                foreach (var selectedItem in radeNaProjektuList.Items)
                {
                    var radnikId = ((DropDownItem)selectedItem).NumVal;
                    Zaposleni radnik = sesija.Load<Zaposleni>(radnikId);
                    // Po defaultu svi radnici pri kreiranju projekta dobijaju da rade od pocetka do kraja na njemu
                    var radi = new RadiNa { projekat = proj, radnik = radnik, datum_pocetka = datumOd.Value, datum_zavrsetka = datumDo.Value };
                    proj.radnici.Add(radi);
                }
                

                sesija.Save(proj);

                // Commit and close
                sesija.Flush();
                sesija.Close();

                MessageBox.Show("Uspešno ste dodali novi projekat");

                SviProjektiForm pF = new SviProjektiForm();
                pF.MdiParent = this.MdiParent;
                pF.Show();

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            
                
            
        }
    }
}
