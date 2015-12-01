namespace Softcom.Projekti
{
    partial class DodajRadnikaNaProjekatForm
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
            this.CS = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CPP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PHP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Java = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cancelBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.datumOdPicker = new System.Windows.Forms.DateTimePicker();
            this.datumDoPicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // radnikList
            // 
            this.radnikList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ZID,
            this.Ime,
            this.Prezime,
            this.CS,
            this.CPP,
            this.PHP,
            this.Java});
            this.radnikList.FullRowSelect = true;
            this.radnikList.GridLines = true;
            this.radnikList.Location = new System.Drawing.Point(20, 24);
            this.radnikList.Name = "radnikList";
            this.radnikList.Size = new System.Drawing.Size(438, 181);
            this.radnikList.TabIndex = 0;
            this.radnikList.UseCompatibleStateImageBehavior = false;
            this.radnikList.View = System.Windows.Forms.View.Details;
            // 
            // ZID
            // 
            this.ZID.Text = "ZID";
            this.ZID.Width = 47;
            // 
            // Ime
            // 
            this.Ime.Text = "Ime";
            // 
            // Prezime
            // 
            this.Prezime.Text = "Prezime";
            this.Prezime.Width = 85;
            // 
            // CS
            // 
            this.CS.Text = "C#";
            // 
            // CPP
            // 
            this.CPP.Text = "C++";
            this.CPP.Width = 47;
            // 
            // PHP
            // 
            this.PHP.Text = "PHP";
            // 
            // Java
            // 
            this.Java.Text = "Java";
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(324, 222);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(134, 33);
            this.cancelBtn.TabIndex = 1;
            this.cancelBtn.Text = "Odustani";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(174, 222);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(134, 33);
            this.addBtn.TabIndex = 2;
            this.addBtn.Text = "Dodaj";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(475, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Početak rada";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(475, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Završetak rada";
            // 
            // datumOdPicker
            // 
            this.datumOdPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datumOdPicker.Location = new System.Drawing.Point(478, 52);
            this.datumOdPicker.Name = "datumOdPicker";
            this.datumOdPicker.Size = new System.Drawing.Size(81, 20);
            this.datumOdPicker.TabIndex = 5;
            // 
            // datumDoPicker
            // 
            this.datumDoPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datumDoPicker.Location = new System.Drawing.Point(478, 121);
            this.datumDoPicker.Name = "datumDoPicker";
            this.datumDoPicker.Size = new System.Drawing.Size(81, 20);
            this.datumDoPicker.TabIndex = 6;
            // 
            // DodajRadnikaNaProjekatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 271);
            this.Controls.Add(this.datumDoPicker);
            this.Controls.Add(this.datumOdPicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.radnikList);
            this.Name = "DodajRadnikaNaProjekatForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Dodaj Radnika Na Projekat";
            this.Load += new System.EventHandler(this.DodajRadnikaNaProjekatForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView radnikList;
        private System.Windows.Forms.ColumnHeader ZID;
        private System.Windows.Forms.ColumnHeader Ime;
        private System.Windows.Forms.ColumnHeader Prezime;
        private System.Windows.Forms.ColumnHeader CS;
        private System.Windows.Forms.ColumnHeader CPP;
        private System.Windows.Forms.ColumnHeader PHP;
        private System.Windows.Forms.ColumnHeader Java;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker datumOdPicker;
        private System.Windows.Forms.DateTimePicker datumDoPicker;

    }
}