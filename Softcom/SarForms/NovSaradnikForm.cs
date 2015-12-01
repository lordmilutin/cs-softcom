using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Softcom.Helpers;
using DataLayer.Entiteti;
using NHibernate;

namespace Softcom.SarForms
{
    public partial class NovSaradnikForm : Form
    {
        public NovSaradnikForm()
        {
            InitializeComponent();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            var sviSaradniciForm = new SviSaradniciForm();
            sviSaradniciForm.MdiParent = this.MdiParent;
            sviSaradniciForm.Show();
            this.Close();
        }

        private void NovSaradnikForm_Load(object sender, EventArgs e)
        {
            ISession sesija = DataLayer.DataLayer.GetSession();
            IQuery sql3 = sesija.CreateQuery("FROM Zaposleni AS z WHERE z.pozicija = 'junior' ");
            IList<Zaposleni> zaposleni = sql3.List<Zaposleni>();

            ListViewItem red;

            foreach (Zaposleni zap in zaposleni)
            {
                red = new ListViewItem();

                red.Tag = zap.ZID;
                red.Text = zap.ZID.ToString();
                red.SubItems.Add(zap.ime);
                red.SubItems.Add(zap.prezime);

                radnikList.Items.Add(red);
            }

            sesija.Close();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (radnikList.SelectedItems.Count > 0)
                {
                    if (String.IsNullOrEmpty(imeBox.Text))
                        throw new Exception("Unesite ime");
                    if (String.IsNullOrEmpty(prezimeBox.Text))
                        throw new Exception("Unesite prezime");
                    if (String.IsNullOrEmpty(telefonBox.Text))
                        throw new Exception("Unesite telefon");

                    ISession sesija = DataLayer.DataLayer.GetSession();
                    Zaposleni zap = sesija.Load<Zaposleni>(radnikList.SelectedItems[0].Tag);
                    Saradnik sar = new Saradnik() { ime = imeBox.Text, prezime = prezimeBox.Text, telefon = telefonBox.Text, nadredjeni = zap };
                    
                    zap.saradnici.Add(sar);
              
                    sesija.Save(sar);
                    sesija.Save(zap);

                    sesija.Flush();
                    sesija.Close();

                    var sviSaradniciForm = new SviSaradniciForm();
                    sviSaradniciForm.MdiParent = this.MdiParent;
                    sviSaradniciForm.Show();
                    this.Close();
                }
                else
                {
                    throw new Exception("Izaberite programera za kontakt");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
