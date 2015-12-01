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
using Softcom.Projekti;
using Softcom.ZapForms;
using Softcom.SarForms;

namespace Softcom
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            MessageBox.Show("Softcom team\n Stanković Milutin 14161 \n Mario Žalac 14232");
            

        }

        private void sviProjektiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var sviProjektiForm = new SviProjektiForm();
            sviProjektiForm.MdiParent = this;
            sviProjektiForm.Show();
        }

        private void novProjekatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var addProjForm = new DodajProjekat();
            addProjForm.MdiParent = this;
            addProjForm.Show();
        }

        private void sviRadniciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var sviRadniciForm = new SviZaposleniForm();
            sviRadniciForm.MdiParent = this;
            sviRadniciForm.Show();
        }

        private void novRadnikToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var noviZaposleniForm = new NoviZaposleniForm();
            noviZaposleniForm.MdiParent = this;
            noviZaposleniForm.Show();
        }

        private void novSaradnikToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var novSaradnik = new NovSaradnikForm();
            novSaradnik.MdiParent = this;
            novSaradnik.Show();
        }

        private void sviSaradniciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var sviSaradnici = new SviSaradniciForm();
            sviSaradnici.MdiParent = this;
            sviSaradnici.Show();
        }
    }
}
