using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLayer.Entiteti;
using Softcom.Helpers;
using NHibernate;

namespace Softcom.ZapForms
{
    public partial class SviZaposleniForm : Form
    {
        public SviZaposleniForm()
        {
            InitializeComponent();
        }

        private void SviZaposleni_Load(object sender, EventArgs e)
        {
            ISession sesija = DataLayer.DataLayer.GetSession();
            IQuery sql3 = sesija.CreateQuery("FROM Zaposleni");
            IList<Zaposleni> zaposleni = sql3.List<Zaposleni>();

            ListViewItem red;

            foreach (Zaposleni zap in zaposleni)
            {
                red = new ListViewItem();

                red.Tag = zap.ZID;
                red.Text = zap.ZID.ToString();
                red.SubItems.Add(zap.ime);
                red.SubItems.Add(zap.prezime);
                red.SubItems.Add(zap.jmbg.ToString());
                red.SubItems.Add(zap.telefon);
                red.SubItems.Add(zap.adresa);

                // Flag parsing
                if (zap.F_CS == 1) red.SubItems.Add("Da");
                else red.SubItems.Add("Ne");
                if (zap.F_CPP == 1) red.SubItems.Add("Da");
                else red.SubItems.Add("Ne");
                if (zap.F_PHP == 1) red.SubItems.Add("Da");
                else red.SubItems.Add("Ne");
                if (zap.F_Java == 1) red.SubItems.Add("Da");
                else red.SubItems.Add("Ne");

                red.SubItems.Add(zap.pozicija);
                red.SubItems.Add(zap.radiNa.Count.ToString());


                radnikList.Items.Add(red);
            }

            sesija.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var noviZaposleniForm = new NoviZaposleniForm();
            noviZaposleniForm.MdiParent = this.MdiParent;
            noviZaposleniForm.Show();
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (radnikList.SelectedItems.Count > 0)
                {
                    var izp = new IzmeniZaposleniForm((int)radnikList.SelectedItems[0].Tag);
                    izp.MdiParent = this.MdiParent;
                    izp.Show();
                    this.Close();
                }
                else
                    throw new Exception("Izaberite zaposlenog za izmenu");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {

                if (radnikList.SelectedItems.Count > 0)
                {
                    ISession sesija = DataLayer.DataLayer.GetSession();
                    Zaposleni zap = sesija.Load<Zaposleni>(radnikList.SelectedItems[0].Tag);
                    sesija.Delete(zap);
                    sesija.Flush();
                    sesija.Close();
                    radnikList.Items.Remove(radnikList.SelectedItems[0]);

                }
                else
                    throw new Exception("Izaberite zaposlenog za brisanje");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
