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
using Softcom.Projekti;


namespace Softcom
{
    public partial class SviProjektiForm : Form
    {
        
        public SviProjektiForm()
        {
            InitializeComponent();
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SviProjektiForm_Load(object sender, EventArgs e)
        {
            loadFormData();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnIzmeniProjekat_Click(object sender, EventArgs e)
        {
            if (listSviProjekti.SelectedItems.Count > 0)
            {
                var selektovanProjekat = (int)listSviProjekti.SelectedItems[0].Tag;

                var editForm = new IzmeniProjekatForm(selektovanProjekat, this);

                editForm.MdiParent = this.MdiParent;
                
                editForm.Show();

            }
            else
            {
                MessageBox.Show("Izaberite projekat sa liste za izmenu.");
            }
        }

        public void loadFormData()
        {

            foreach (ListViewItem row in listSviProjekti.Items)
            {
                row.Remove();
            }

            ISession sesija = DataLayer.DataLayer.GetSession();
            // Pokupi sve projekte
            IQuery q = sesija.CreateQuery("from Projekat");
            IList<Projekat> projekti = q.List<Projekat>();

            // Pokupi group objekte
            var insourceGroup = listSviProjekti.Groups["Insource"];
            var outsourceGroup = listSviProjekti.Groups["Outsource"];
            ListViewItem red;

            foreach (Projekat proj in projekti)
            {
                // Zajednicko za sve projekte
                red = new ListViewItem();

                red.SubItems.Add(proj.PID.ToString());
                red.SubItems.Add(proj.ime);
                red.Tag = proj.PID;

                // Remove(10) - Obrisi nule za time
                red.SubItems.Add(proj.datumPocetka.Date.ToString().Remove(10));
                red.SubItems.Add(proj.datumZavrsetka.Date.ToString().Remove(10));

                if (proj.izrada == "insource")
                {
                    red.Group = insourceGroup;
                    var leader = proj.trenutniLeader;
                    red.SubItems.Add(leader.sef.ime + " " + leader.sef.prezime);
                    red.SubItems.Add(""); // Naziv firme placeholder
                }

                if (proj.izrada == "outsource")
                {
                    red.Group = outsourceGroup;
                    red.SubItems.Add("");  // Leader placeholder            
                    red.SubItems.Add(proj.nazivFirme);
                }

                listSviProjekti.Items.Add(red);

            }

        }

        private void btnObrisiProjekat_Click(object sender, EventArgs e)
        {
            try
            {
                ISession sesija = DataLayer.DataLayer.GetSession();

                if (listSviProjekti.SelectedItems.Count > 0)
                {
                    string msgTxt = "Uz projekat će biti obrisani i podaci o projektu. Da li ste sigurni da želite da obrišete projekat?";
                    string caption = "Brisanje projekta";
                    MessageBoxButtons button = MessageBoxButtons.YesNo;
                    MessageBoxIcon icon = MessageBoxIcon.Warning;

                    DialogResult rez = MessageBox.Show(msgTxt, caption, button, icon);

                    if (rez == DialogResult.Yes)
                    {
                        var selektovanProjekat = (int)listSviProjekti.SelectedItems[0].Tag;
                        Projekat proj = sesija.Load<Projekat>(selektovanProjekat);

                        sesija.Delete(proj);
                        sesija.Flush();
                        sesija.Close();
                        loadFormData();
                    }
                }
                else
                {
                    throw new Exception("Izaberite projekat sa liste za brisanje.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void novProjekatBtn_Click(object sender, EventArgs e)
        {
            var addProjForm = new DodajProjekat();
            addProjForm.MdiParent = this.MdiParent;
            addProjForm.Show();
            this.Close();
        }
    }
}
