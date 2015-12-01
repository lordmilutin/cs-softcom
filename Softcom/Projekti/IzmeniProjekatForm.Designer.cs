namespace Softcom.Projekti
{
    partial class IzmeniProjekatForm
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
            this.tipIzrade = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nazivProjekta = new System.Windows.Forms.TextBox();
            this.datumOd = new System.Windows.Forms.DateTimePicker();
            this.datumDo = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.leaderList = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.imeFirme = new System.Windows.Forms.TextBox();
            this.adresaFirme = new System.Windows.Forms.TextBox();
            this.listRadnika = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.vodiDoDatePicker = new System.Windows.Forms.DateTimePicker();
            this.vodiOdDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.addRadnikaBtn = new System.Windows.Forms.Button();
            this.delRadnikBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tipIzrade
            // 
            this.tipIzrade.AllowDrop = true;
            this.tipIzrade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tipIzrade.FormattingEnabled = true;
            this.tipIzrade.Items.AddRange(new object[] {
            "Insource",
            "Outsorce"});
            this.tipIzrade.Location = new System.Drawing.Point(29, 88);
            this.tipIzrade.Name = "tipIzrade";
            this.tipIzrade.Size = new System.Drawing.Size(160, 21);
            this.tipIzrade.TabIndex = 0;
            this.tipIzrade.SelectedIndexChanged += new System.EventHandler(this.tipIzrade_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tip izdrade";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Naziv projekta";
            // 
            // nazivProjekta
            // 
            this.nazivProjekta.Location = new System.Drawing.Point(29, 38);
            this.nazivProjekta.Name = "nazivProjekta";
            this.nazivProjekta.Size = new System.Drawing.Size(160, 20);
            this.nazivProjekta.TabIndex = 3;
            // 
            // datumOd
            // 
            this.datumOd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datumOd.Location = new System.Drawing.Point(213, 35);
            this.datumOd.Name = "datumOd";
            this.datumOd.Size = new System.Drawing.Size(94, 20);
            this.datumOd.TabIndex = 4;
            // 
            // datumDo
            // 
            this.datumDo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datumDo.Location = new System.Drawing.Point(213, 85);
            this.datumDo.Name = "datumDo";
            this.datumDo.Size = new System.Drawing.Size(94, 20);
            this.datumDo.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(214, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Rok za izradu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(210, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Pocetak izrade";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(339, 320);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(121, 26);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Sačuvaj";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(466, 320);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(121, 26);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Odustani";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Vođa projekta";
            // 
            // leaderList
            // 
            this.leaderList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.leaderList.FormattingEnabled = true;
            this.leaderList.Location = new System.Drawing.Point(29, 197);
            this.leaderList.Name = "leaderList";
            this.leaderList.Size = new System.Drawing.Size(160, 21);
            this.leaderList.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(216, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Firma";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(216, 232);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Adresa";
            // 
            // imeFirme
            // 
            this.imeFirme.Location = new System.Drawing.Point(213, 198);
            this.imeFirme.Name = "imeFirme";
            this.imeFirme.Size = new System.Drawing.Size(145, 20);
            this.imeFirme.TabIndex = 14;
            // 
            // adresaFirme
            // 
            this.adresaFirme.Location = new System.Drawing.Point(213, 249);
            this.adresaFirme.Name = "adresaFirme";
            this.adresaFirme.Size = new System.Drawing.Size(145, 20);
            this.adresaFirme.TabIndex = 15;
            // 
            // listRadnika
            // 
            this.listRadnika.BackColor = System.Drawing.SystemColors.Window;
            this.listRadnika.FormattingEnabled = true;
            this.listRadnika.Location = new System.Drawing.Point(380, 38);
            this.listRadnika.Name = "listRadnika";
            this.listRadnika.Size = new System.Drawing.Size(227, 225);
            this.listRadnika.TabIndex = 16;
            this.listRadnika.SelectedIndexChanged += new System.EventHandler(this.listRadnika_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(377, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Rade na projektu";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(31, 241);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Vodi od";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(35, 291);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Vodi do";
            // 
            // vodiDoDatePicker
            // 
            this.vodiDoDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.vodiDoDatePicker.Location = new System.Drawing.Point(34, 307);
            this.vodiDoDatePicker.Name = "vodiDoDatePicker";
            this.vodiDoDatePicker.Size = new System.Drawing.Size(94, 20);
            this.vodiDoDatePicker.TabIndex = 19;
            // 
            // vodiOdDatePicker
            // 
            this.vodiOdDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.vodiOdDatePicker.Location = new System.Drawing.Point(34, 257);
            this.vodiOdDatePicker.Name = "vodiOdDatePicker";
            this.vodiOdDatePicker.Size = new System.Drawing.Size(94, 20);
            this.vodiOdDatePicker.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(214, 143);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 16);
            this.label11.TabIndex = 22;
            this.label11.Text = "Outsource Info";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(29, 143);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(96, 16);
            this.label12.TabIndex = 23;
            this.label12.Text = "Insource Info";
            // 
            // addRadnikaBtn
            // 
            this.addRadnikaBtn.Location = new System.Drawing.Point(380, 269);
            this.addRadnikaBtn.Name = "addRadnikaBtn";
            this.addRadnikaBtn.Size = new System.Drawing.Size(107, 25);
            this.addRadnikaBtn.TabIndex = 24;
            this.addRadnikaBtn.Text = "Dodaj radnika";
            this.addRadnikaBtn.UseVisualStyleBackColor = true;
            this.addRadnikaBtn.Click += new System.EventHandler(this.addRadnikaBtn_Click);
            // 
            // delRadnikBtn
            // 
            this.delRadnikBtn.Location = new System.Drawing.Point(493, 269);
            this.delRadnikBtn.Name = "delRadnikBtn";
            this.delRadnikBtn.Size = new System.Drawing.Size(114, 25);
            this.delRadnikBtn.TabIndex = 25;
            this.delRadnikBtn.Text = "Ukloni radnika";
            this.delRadnikBtn.UseVisualStyleBackColor = true;
            this.delRadnikBtn.Click += new System.EventHandler(this.delRadnikBtn_Click);
            // 
            // IzmeniProjekatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 365);
            this.Controls.Add(this.delRadnikBtn);
            this.Controls.Add(this.addRadnikaBtn);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.vodiDoDatePicker);
            this.Controls.Add(this.vodiOdDatePicker);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.listRadnika);
            this.Controls.Add(this.adresaFirme);
            this.Controls.Add(this.imeFirme);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.leaderList);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.datumDo);
            this.Controls.Add(this.datumOd);
            this.Controls.Add(this.nazivProjekta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tipIzrade);
            this.Name = "IzmeniProjekatForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Izmeni Projekat";
            this.Load += new System.EventHandler(this.IzmeniProjekatForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nazivProjekta;
        private System.Windows.Forms.ComboBox tipIzrade;
        private System.Windows.Forms.DateTimePicker datumOd;
        private System.Windows.Forms.DateTimePicker datumDo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox leaderList;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox imeFirme;
        private System.Windows.Forms.TextBox adresaFirme;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker vodiDoDatePicker;
        private System.Windows.Forms.DateTimePicker vodiOdDatePicker;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button addRadnikaBtn;
        private System.Windows.Forms.Button delRadnikBtn;
        public System.Windows.Forms.ListBox listRadnika;
    }
}