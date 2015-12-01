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
using Softcom.Helpers;
using DataLayer;
using DataLayer.Entiteti;


namespace Softcom.Projekti
{
    public partial class DodajRadnikaNaProjekatForm : Form
    {
        private IzmeniProjekatForm projekatForm;
        private Projekat projekat;

        public DodajRadnikaNaProjekatForm(Form projekatForm)
        {
            InitializeComponent();
            this.projekatForm = (IzmeniProjekatForm)projekatForm;
        }

        private void DodajRadnikaNaProjekatForm_Load(object sender, EventArgs e)
        {
            ISession sesija = DataLayer.DataLayer.GetSession();
            this.projekat = sesija.Load<Projekat>(projekatForm.pid);

            IQuery sql3 = sesija.CreateQuery("FROM Zaposleni");
            IList<Zaposleni> zaposleni = sql3.List<Zaposleni>();
            
            ListViewItem red;

            foreach (Zaposleni zap in zaposleni)
            {
                red = new ListViewItem();

                red.SubItems.Add(zap.ZID.ToString());
                red.SubItems.Add(zap.ime);
                red.SubItems.Add(zap.prezime);
                red.Tag = zap.ZID;

                // Flag parsing
                if (zap.F_CS == 1) red.SubItems.Add("Da");
                else  red.SubItems.Add("Ne");
                if (zap.F_CPP == 1) red.SubItems.Add("Da");
                else red.SubItems.Add("Ne");
                if (zap.F_PHP == 1) red.SubItems.Add("Da");
                else red.SubItems.Add("Ne");
                if (zap.F_Java == 1) red.SubItems.Add("Da");
                else red.SubItems.Add("Ne");

                radnikList.Items.Add(red);
            }

            sesija.Close();

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            try
            {
                ISession sesija = DataLayer.DataLayer.GetSession();

                var skip = 0;

                foreach (ListViewItem red in radnikList.SelectedItems)
                {
                    foreach(var outerRed in projekatForm.listRadnika.Items)
                    {
                        if( ((DropDownItem)outerRed).NumVal == (int) red.Tag )
                            skip = 1;
                    }
                    if ( skip == 0 )
                    {
                        Zaposleni radnik = sesija.Load<Zaposleni>(red.Tag);
                        projekatForm.listRadnika.Items.Add(new DropDownItem(radnik.ime + " " + radnik.prezime, radnik.ZID.ToString() ));
                        var proj = sesija.Load<Projekat>(projekatForm.pid);
                        RadiNa radi = new RadiNa() { radnik = radnik, projekat = proj, datum_pocetka = datumOdPicker.Value, datum_zavrsetka = datumDoPicker.Value};
                        sesija.Save(radi);
                    }
                    skip = 0;
                }
                sesija.Flush();
                sesija.Close();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
