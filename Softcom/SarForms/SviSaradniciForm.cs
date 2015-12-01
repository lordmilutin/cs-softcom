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
using DataLayer;
using DataLayer.Entiteti;

namespace Softcom.SarForms
{
    public partial class SviSaradniciForm : Form
    {
        public SviSaradniciForm()
        {
            InitializeComponent();
        }

        private void closeBtn_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            var novSaradnik = new NovSaradnikForm();
            novSaradnik.MdiParent = this.MdiParent;
            novSaradnik.Show();
            this.Close();
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (saradnikList.SelectedItems.Count > 0)
                {
                    ISession sesija = DataLayer.DataLayer.GetSession();
                    Saradnik sar = sesija.Load<Saradnik>(saradnikList.SelectedItems[0].Tag);
                    sesija.Delete(sar);
                    sesija.Flush();
                    saradnikList.Items.Remove(saradnikList.SelectedItems[0]);
                }
                else
                    throw new Exception("Izaberite saradnika za brisanje");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SviSaradniciForm_Load(object sender, EventArgs e)
        {
            ISession sesija = DataLayer.DataLayer.GetSession();
            IQuery sql3 = sesija.CreateQuery("FROM Saradnik");
            IList<Saradnik> saradnici = sql3.List<Saradnik>();

            ListViewItem red;

            foreach (Saradnik sar in saradnici)
            {
                red = new ListViewItem();

                red.Tag = sar.SID;
                red.Text = sar.SID.ToString();
                red.SubItems.Add(sar.ime);
                red.SubItems.Add(sar.prezime);
                red.SubItems.Add(sar.telefon);
                red.SubItems.Add(sar.nadredjeni.ime + " " + sar.nadredjeni.prezime);


                saradnikList.Items.Add(red);
            }

            sesija.Close();
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (saradnikList.SelectedItems.Count > 0)
                {
                    var editSar = new IzmeniSaradnikaForm(Convert.ToInt32(saradnikList.SelectedItems[0].Text));
                    editSar.MdiParent = this.MdiParent;
                    editSar.Show();
                    this.Close();
                }
                else
                    throw new Exception("Izaberite saradnika za izmenu");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
