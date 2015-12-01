namespace Softcom.SarForms
{
    partial class IzmeniSaradnikaForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.closeBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.telefonBox = new System.Windows.Forms.TextBox();
            this.prezimeBox = new System.Windows.Forms.TextBox();
            this.imeBox = new System.Windows.Forms.TextBox();
            this.radnikList = new System.Windows.Forms.ListView();
            this.ZID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Prezime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Angažovan od strane";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(331, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Telefon";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(331, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Prezime";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(331, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Ime";
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(402, 209);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(87, 30);
            this.closeBtn.TabIndex = 25;
            this.closeBtn.Text = "Otkaži";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(309, 209);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(87, 30);
            this.saveBtn.TabIndex = 24;
            this.saveBtn.Text = "Izmeni";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // telefonBox
            // 
            this.telefonBox.Location = new System.Drawing.Point(327, 155);
            this.telefonBox.Name = "telefonBox";
            this.telefonBox.Size = new System.Drawing.Size(143, 20);
            this.telefonBox.TabIndex = 23;
            // 
            // prezimeBox
            // 
            this.prezimeBox.Location = new System.Drawing.Point(327, 99);
            this.prezimeBox.Name = "prezimeBox";
            this.prezimeBox.Size = new System.Drawing.Size(143, 20);
            this.prezimeBox.TabIndex = 22;
            // 
            // imeBox
            // 
            this.imeBox.Location = new System.Drawing.Point(327, 43);
            this.imeBox.Name = "imeBox";
            this.imeBox.Size = new System.Drawing.Size(143, 20);
            this.imeBox.TabIndex = 21;
            // 
            // radnikList
            // 
            this.radnikList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ZID,
            this.Ime,
            this.Prezime});
            this.radnikList.FullRowSelect = true;
            this.radnikList.GridLines = true;
            this.radnikList.HideSelection = false;
            this.radnikList.Location = new System.Drawing.Point(12, 27);
            this.radnikList.MultiSelect = false;
            this.radnikList.Name = "radnikList";
            this.radnikList.Size = new System.Drawing.Size(291, 212);
            this.radnikList.TabIndex = 20;
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
            this.Ime.Width = 105;
            // 
            // Prezime
            // 
            this.Prezime.Text = "Prezime";
            this.Prezime.Width = 97;
            // 
            // IzmeniSaradnikaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 253);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.telefonBox);
            this.Controls.Add(this.prezimeBox);
            this.Controls.Add(this.imeBox);
            this.Controls.Add(this.radnikList);
            this.Name = "IzmeniSaradnikaForm";
            this.Text = "Izmeni Saradnika";
            this.Load += new System.EventHandler(this.IzmeniSaradnikaForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.TextBox telefonBox;
        private System.Windows.Forms.TextBox prezimeBox;
        private System.Windows.Forms.TextBox imeBox;
        private System.Windows.Forms.ListView radnikList;
        private System.Windows.Forms.ColumnHeader ZID;
        private System.Windows.Forms.ColumnHeader Ime;
        private System.Windows.Forms.ColumnHeader Prezime;
    }
}