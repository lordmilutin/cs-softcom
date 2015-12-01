namespace Softcom.SarForms
{
    partial class NovSaradnikForm
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
            this.label4.Location = new System.Drawing.Point(17, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Angažovan od strane";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(331, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Telefon";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(331, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Prezime";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(331, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Ime";
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(402, 220);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(87, 30);
            this.closeBtn.TabIndex = 15;
            this.closeBtn.Text = "Otkaži";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(309, 220);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(87, 30);
            this.saveBtn.TabIndex = 14;
            this.saveBtn.Text = "Dodaj";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // telefonBox
            // 
            this.telefonBox.Location = new System.Drawing.Point(327, 166);
            this.telefonBox.Name = "telefonBox";
            this.telefonBox.Size = new System.Drawing.Size(143, 20);
            this.telefonBox.TabIndex = 13;
            // 
            // prezimeBox
            // 
            this.prezimeBox.Location = new System.Drawing.Point(327, 110);
            this.prezimeBox.Name = "prezimeBox";
            this.prezimeBox.Size = new System.Drawing.Size(143, 20);
            this.prezimeBox.TabIndex = 12;
            // 
            // imeBox
            // 
            this.imeBox.Location = new System.Drawing.Point(327, 54);
            this.imeBox.Name = "imeBox";
            this.imeBox.Size = new System.Drawing.Size(143, 20);
            this.imeBox.TabIndex = 11;
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
            this.radnikList.Location = new System.Drawing.Point(12, 38);
            this.radnikList.Name = "radnikList";
            this.radnikList.Size = new System.Drawing.Size(291, 212);
            this.radnikList.TabIndex = 10;
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
            // NovSaradnikForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 262);
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
            this.Name = "NovSaradnikForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nov Saradnik";
            this.Load += new System.EventHandler(this.NovSaradnikForm_Load);
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