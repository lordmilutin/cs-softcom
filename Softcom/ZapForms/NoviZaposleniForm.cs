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
using DataLayer.Entiteti;


namespace Softcom.ZapForms
{
    public partial class NoviZaposleniForm : Form
    {
        public NoviZaposleniForm()
        {
            InitializeComponent();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            try
            {

                ISession sesija = DataLayer.DataLayer.GetSession();

                if (String.IsNullOrEmpty(imeBox.Text))
                    throw new Exception("Unesite ime");

                if (String.IsNullOrEmpty(prezimeBox.Text))
                    throw new Exception("Unesite prezime");

                if (String.IsNullOrEmpty(jmbgBox.Text))
                    throw new Exception("Unesite JMBG");

                Zaposleni zap = new Zaposleni();
                zap.ime = imeBox.Text;
                zap.prezime = prezimeBox.Text;
                zap.jmbg = Convert.ToInt64(jmbgBox.Text);
                zap.adresa = adresaBox.Text;
                zap.telefon = telefonBox.Text;

                if (pozicijaBox.SelectedIndex == 0)
                    zap.pozicija = "junior";
                else if (pozicijaBox.SelectedIndex == 1)
                    zap.pozicija = "senior";
                else
                   throw new Exception("Izaberite poziciju");
                // Flags parsing
                if (cpp.Checked) zap.F_CPP = 1;
                else zap.F_CPP = 0;
                if (cs.Checked) zap.F_CS = 1;
                else zap.F_CS = 0;
                if (php.Checked) zap.F_PHP = 1;
                else zap.F_PHP = 0;
                if (java.Checked) zap.F_Java = 1;
                else zap.F_Java = 0;


                sesija.Save(zap);
                sesija.Flush();
                sesija.Close();
                MessageBox.Show("Uspešno ste dodali " + zap.ime + " " + zap.prezime);


                var szf = new SviZaposleniForm();
                szf.MdiParent = this.MdiParent;
                szf.Show();

                this.Close();


            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }
    }
}
