namespace Softcom.ZapForms
{
    partial class SviZaposleniForm
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
            this.radnikList = new System.Windows.Forms.ListView();
            this.ZID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Prezime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.JMBG = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Telefon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Adresa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CS = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CPP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PHP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Java = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Pozicija = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.brProjekata = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // radnikList
            // 
            this.radnikList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ZID,
            this.Ime,
            this.Prezime,
            this.JMBG,
            this.Telefon,
            this.Adresa,
            this.CS,
            this.CPP,
            this.PHP,
            this.Java,
            this.Pozicija,
            this.brProjekata});
            this.radnikList.FullRowSelect = true;
            this.radnikList.GridLines = true;
            this.radnikList.Location = new System.Drawing.Point(12, 12);
            this.radnikList.Name = "radnikList";
            this.radnikList.Size = new System.Drawing.Size(916, 246);
            this.radnikList.TabIndex = 1;
            this.radnikList.UseCompatibleStateImageBehavior = false;
            this.radnikList.View = System.Windows.Forms.View.Details;
            // 
            // ZID
            // 
            this.ZID.Text = "ZID";
            // 
            // Ime
            // 
            this.Ime.Text = "Ime";
            this.Ime.Width = 83;
            // 
            // Prezime
            // 
            this.Prezime.Text = "Prezime";
            this.Prezime.Width = 85;
            // 
            // JMBG
            // 
            this.JMBG.Text = "JMBG";
            this.JMBG.Width = 95;
            // 
            // Telefon
            // 
            this.Telefon.Text = "Telefon";
            this.Telefon.Width = 79;
            // 
            // Adresa
            // 
            this.Adresa.Text = "Adresa";
            this.Adresa.Width = 151;
            // 
            // CS
            // 
            this.CS.Text = "C#";
            this.CS.Width = 30;
            // 
            // CPP
            // 
            this.CPP.Text = "C++";
            this.CPP.Width = 35;
            // 
            // PHP
            // 
            this.PHP.Text = "PHP";
            this.PHP.Width = 35;
            // 
            // Java
            // 
            this.Java.Text = "Java";
            this.Java.Width = 35;
            // 
            // Pozicija
            // 
            this.Pozicija.Text = "Pozicija";
            this.Pozicija.Width = 71;
            // 
            // brProjekata
            // 
            this.brProjekata.Text = "Broj projekata";
            this.brProjekata.Width = 85;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(947, 24);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(148, 38);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Nov Zaposleni";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(947, 82);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(148, 38);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Izmeni Zaposlenog";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(947, 140);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(148, 38);
            this.btnDel.TabIndex = 4;
            this.btnDel.Text = "Obriši Zaposlenog";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(947, 199);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(148, 38);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Zatvori";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // SviZaposleniForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 270);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.radnikList);
            this.Name = "SviZaposleniForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Svi Zaposleni";
            this.Load += new System.EventHandler(this.SviZaposleni_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView radnikList;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ColumnHeader ZID;
        private System.Windows.Forms.ColumnHeader Ime;
        private System.Windows.Forms.ColumnHeader Prezime;
        private System.Windows.Forms.ColumnHeader JMBG;
        private System.Windows.Forms.ColumnHeader Telefon;
        private System.Windows.Forms.ColumnHeader Adresa;
        private System.Windows.Forms.ColumnHeader CS;
        private System.Windows.Forms.ColumnHeader CPP;
        private System.Windows.Forms.ColumnHeader PHP;
        private System.Windows.Forms.ColumnHeader Java;
        private System.Windows.Forms.ColumnHeader Pozicija;
        private System.Windows.Forms.ColumnHeader brProjekata;
    }
}