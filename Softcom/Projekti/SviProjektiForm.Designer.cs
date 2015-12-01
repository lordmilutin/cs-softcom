namespace Softcom
{
    partial class SviProjektiForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Insource Projekti", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("Outsource Projekti", System.Windows.Forms.HorizontalAlignment.Left);
            this.btnIzmeniProjekat = new System.Windows.Forms.Button();
            this.btnObrisiProjekat = new System.Windows.Forms.Button();
            this.btnZatvori = new System.Windows.Forms.Button();
            this.listSviProjekti = new System.Windows.Forms.ListView();
            this.TipIzrade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Projekat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Početo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Rok = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Vođa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Za = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.novProjekatBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnIzmeniProjekat
            // 
            this.btnIzmeniProjekat.Location = new System.Drawing.Point(868, 97);
            this.btnIzmeniProjekat.Name = "btnIzmeniProjekat";
            this.btnIzmeniProjekat.Size = new System.Drawing.Size(203, 51);
            this.btnIzmeniProjekat.TabIndex = 1;
            this.btnIzmeniProjekat.Text = "Izmeni Projekat";
            this.btnIzmeniProjekat.UseVisualStyleBackColor = true;
            this.btnIzmeniProjekat.Click += new System.EventHandler(this.btnIzmeniProjekat_Click);
            // 
            // btnObrisiProjekat
            // 
            this.btnObrisiProjekat.Location = new System.Drawing.Point(868, 168);
            this.btnObrisiProjekat.Name = "btnObrisiProjekat";
            this.btnObrisiProjekat.Size = new System.Drawing.Size(203, 51);
            this.btnObrisiProjekat.TabIndex = 2;
            this.btnObrisiProjekat.Text = "Obriši projekat";
            this.btnObrisiProjekat.UseVisualStyleBackColor = true;
            this.btnObrisiProjekat.Click += new System.EventHandler(this.btnObrisiProjekat_Click);
            // 
            // btnZatvori
            // 
            this.btnZatvori.Location = new System.Drawing.Point(868, 245);
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.Size = new System.Drawing.Size(203, 51);
            this.btnZatvori.TabIndex = 3;
            this.btnZatvori.Text = "Zatvori";
            this.btnZatvori.UseVisualStyleBackColor = true;
            this.btnZatvori.Click += new System.EventHandler(this.btnZatvori_Click);
            // 
            // listSviProjekti
            // 
            this.listSviProjekti.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.TipIzrade,
            this.ID,
            this.Projekat,
            this.Početo,
            this.Rok,
            this.Vođa,
            this.Za});
            this.listSviProjekti.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listSviProjekti.FullRowSelect = true;
            this.listSviProjekti.GridLines = true;
            listViewGroup1.Header = "Insource Projekti";
            listViewGroup1.Name = "Insource";
            listViewGroup1.Tag = "Insource";
            listViewGroup2.Header = "Outsource Projekti";
            listViewGroup2.Name = "Outsource";
            listViewGroup2.Tag = "Outsource";
            this.listSviProjekti.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2});
            this.listSviProjekti.HideSelection = false;
            this.listSviProjekti.Location = new System.Drawing.Point(12, 30);
            this.listSviProjekti.MultiSelect = false;
            this.listSviProjekti.Name = "listSviProjekti";
            this.listSviProjekti.Size = new System.Drawing.Size(823, 378);
            this.listSviProjekti.TabIndex = 4;
            this.listSviProjekti.UseCompatibleStateImageBehavior = false;
            this.listSviProjekti.View = System.Windows.Forms.View.Details;
            this.listSviProjekti.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // TipIzrade
            // 
            this.TipIzrade.Text = "Tip izrade";
            this.TipIzrade.Width = 102;
            // 
            // ID
            // 
            this.ID.Text = "PID";
            // 
            // Projekat
            // 
            this.Projekat.Text = "Projekat";
            this.Projekat.Width = 123;
            // 
            // Početo
            // 
            this.Početo.DisplayIndex = 4;
            this.Početo.Text = "Početo";
            this.Početo.Width = 108;
            // 
            // Rok
            // 
            this.Rok.DisplayIndex = 5;
            this.Rok.Text = "Rok";
            this.Rok.Width = 117;
            // 
            // Vođa
            // 
            this.Vođa.DisplayIndex = 3;
            this.Vođa.Text = "Vođa";
            this.Vođa.Width = 136;
            // 
            // Za
            // 
            this.Za.Text = "Za";
            this.Za.Width = 123;
            // 
            // novProjekatBtn
            // 
            this.novProjekatBtn.Location = new System.Drawing.Point(868, 30);
            this.novProjekatBtn.Name = "novProjekatBtn";
            this.novProjekatBtn.Size = new System.Drawing.Size(203, 51);
            this.novProjekatBtn.TabIndex = 5;
            this.novProjekatBtn.Text = "Dodaj Projekat";
            this.novProjekatBtn.UseVisualStyleBackColor = true;
            this.novProjekatBtn.Click += new System.EventHandler(this.novProjekatBtn_Click);
            // 
            // SviProjektiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 420);
            this.Controls.Add(this.novProjekatBtn);
            this.Controls.Add(this.listSviProjekti);
            this.Controls.Add(this.btnZatvori);
            this.Controls.Add(this.btnObrisiProjekat);
            this.Controls.Add(this.btnIzmeniProjekat);
            this.Name = "SviProjektiForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Svi Projekti";
            this.Load += new System.EventHandler(this.SviProjektiForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnIzmeniProjekat;
        private System.Windows.Forms.Button btnObrisiProjekat;
        private System.Windows.Forms.Button btnZatvori;
        private System.Windows.Forms.ListView listSviProjekti;
        private System.Windows.Forms.ColumnHeader Projekat;
        private System.Windows.Forms.ColumnHeader Vođa;
        private System.Windows.Forms.ColumnHeader Početo;
        private System.Windows.Forms.ColumnHeader Rok;
        private System.Windows.Forms.ColumnHeader Za;
        private System.Windows.Forms.ColumnHeader TipIzrade;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.Button novProjekatBtn;


    }
}