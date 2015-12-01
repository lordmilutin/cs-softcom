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
using NHibernate;

namespace Softcom.SarForms
{
    public partial class IzmeniSaradnikaForm : Form
    {
        private int SID;
        public IzmeniSaradnikaForm(int id)
        {
            InitializeComponent();
            SID = id;
        }

        private void IzmeniSaradnikaForm_Load(object sender, EventArgs e)
        {
            try
            {
                ISession sesija = DataLayer.DataLayer.GetSession();
                IQuery sql3 = sesija.CreateQuery("FROM Zaposleni AS z WHERE z.pozicija = 'junior' ");
                IList<Zaposleni> zaposleni = sql3.List<Zaposleni>();
                Saradnik sar = sesija.Load<Saradnik>(SID);

                imeBox.Text = sar.ime;
                prezimeBox.Text = sar.prezime;
                telefonBox.Text = sar.telefon;

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

                var item = radnikList.FindItemWithText(sar.nadredjeni.ZID.ToString());
                if (item != null)
                    item.Selected = true;

                sesija.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                ISession sesija = DataLayer.DataLayer.GetSession();
                Saradnik sar = sesija.Load<Saradnik>(SID);
                Zaposleni zap = sesija.Load<Zaposleni>(radnikList.SelectedItems[0].Tag);

                sar.ime = imeBox.Text;
                sar.prezime = prezimeBox.Text;
                sar.telefon = telefonBox.Text;
                sar.nadredjeni = zap;

                sesija.Save(sar);
                sesija.Flush();
                sesija.Close();

                var ssf = new SviSaradniciForm();
                ssf.MdiParent = this.MdiParent;
                ssf.Show();

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            var ssf = new SviSaradniciForm();
            ssf.MdiParent = this.MdiParent;
            ssf.Show();

            this.Close();
        }
    }
}
