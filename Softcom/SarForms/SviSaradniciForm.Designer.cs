namespace Softcom.SarForms
{
    partial class SviSaradniciForm
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
            this.saradnikList = new System.Windows.Forms.ListView();
            this.SID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Prezime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Telefon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AngazovaoGa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addBtn = new System.Windows.Forms.Button();
            this.delBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // saradnikList
            // 
            this.saradnikList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.SID,
            this.Ime,
            this.Prezime,
            this.Telefon,
            this.AngazovaoGa});
            this.saradnikList.FullRowSelect = true;
            this.saradnikList.GridLines = true;
            this.saradnikList.HideSelection = false;
            this.saradnikList.Location = new System.Drawing.Point(17, 29);
            this.saradnikList.Name = "saradnikList";
            this.saradnikList.Size = new System.Drawing.Size(446, 265);
            this.saradnikList.TabIndex = 0;
            this.saradnikList.UseCompatibleStateImageBehavior = false;
            this.saradnikList.View = System.Windows.Forms.View.Details;
            // 
            // SID
            // 
            this.SID.Text = "SID";
            this.SID.Width = 43;
            // 
            // Ime
            // 
            this.Ime.Text = "Ime";
            this.Ime.Width = 75;
            // 
            // Prezime
            // 
            this.Prezime.Text = "Prezime";
            this.Prezime.Width = 85;
            // 
            // Telefon
            // 
            this.Telefon.Text = "Telefon";
            this.Telefon.Width = 88;
            // 
            // AngazovaoGa
            // 
            this.AngazovaoGa.Text = "Angažovao ga";
            this.AngazovaoGa.Width = 129;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(501, 35);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(140, 38);
            this.addBtn.TabIndex = 1;
            this.addBtn.Text = "Dodaj Saradnika";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // delBtn
            // 
            this.delBtn.Location = new System.Drawing.Point(501, 155);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(140, 38);
            this.delBtn.TabIndex = 2;
            this.delBtn.Text = "Obriši Saradnika";
            this.delBtn.UseVisualStyleBackColor = true;
            this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.Location = new System.Drawing.Point(501, 95);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(140, 38);
            this.editBtn.TabIndex = 3;
            this.editBtn.Text = "Izmeni Saradnika";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(501, 215);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(140, 38);
            this.closeBtn.TabIndex = 4;
            this.closeBtn.Text = "Zatvori";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click_1);
            // 
            // SviSaradniciForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 312);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.delBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.saradnikList);
            this.Name = "SviSaradniciForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Svi Saradnici";
            this.Load += new System.EventHandler(this.SviSaradniciForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView saradnikList;
        private System.Windows.Forms.ColumnHeader SID;
        private System.Windows.Forms.ColumnHeader Ime;
        private System.Windows.Forms.ColumnHeader Prezime;
        private System.Windows.Forms.ColumnHeader Telefon;
        private System.Windows.Forms.ColumnHeader AngazovaoGa;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button delBtn;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button closeBtn;

    }
}