namespace Softcom
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projektiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sviProjektiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novProjekatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.radniciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sviRadniciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novRadnikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saradniciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sviSaradniciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novSaradnikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem,
            this.projektiToolStripMenuItem,
            this.radniciToolStripMenuItem,
            this.saradniciToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1259, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.helpToolStripMenuItem.Text = "Home";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.AutoSize = false;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // projektiToolStripMenuItem
            // 
            this.projektiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sviProjektiToolStripMenuItem,
            this.novProjekatToolStripMenuItem});
            this.projektiToolStripMenuItem.Name = "projektiToolStripMenuItem";
            this.projektiToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.projektiToolStripMenuItem.Text = "Projekti";
            // 
            // sviProjektiToolStripMenuItem
            // 
            this.sviProjektiToolStripMenuItem.Name = "sviProjektiToolStripMenuItem";
            this.sviProjektiToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.sviProjektiToolStripMenuItem.Text = "Svi projekti";
            this.sviProjektiToolStripMenuItem.Click += new System.EventHandler(this.sviProjektiToolStripMenuItem_Click);
            // 
            // novProjekatToolStripMenuItem
            // 
            this.novProjekatToolStripMenuItem.Name = "novProjekatToolStripMenuItem";
            this.novProjekatToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.novProjekatToolStripMenuItem.Text = "Nov projekat";
            this.novProjekatToolStripMenuItem.Click += new System.EventHandler(this.novProjekatToolStripMenuItem_Click);
            // 
            // radniciToolStripMenuItem
            // 
            this.radniciToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sviRadniciToolStripMenuItem,
            this.novRadnikToolStripMenuItem});
            this.radniciToolStripMenuItem.Name = "radniciToolStripMenuItem";
            this.radniciToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.radniciToolStripMenuItem.Text = "Radnici";
            // 
            // sviRadniciToolStripMenuItem
            // 
            this.sviRadniciToolStripMenuItem.Name = "sviRadniciToolStripMenuItem";
            this.sviRadniciToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.sviRadniciToolStripMenuItem.Text = "Svi radnici";
            this.sviRadniciToolStripMenuItem.Click += new System.EventHandler(this.sviRadniciToolStripMenuItem_Click);
            // 
            // novRadnikToolStripMenuItem
            // 
            this.novRadnikToolStripMenuItem.Name = "novRadnikToolStripMenuItem";
            this.novRadnikToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.novRadnikToolStripMenuItem.Text = "Nov radnik";
            this.novRadnikToolStripMenuItem.Click += new System.EventHandler(this.novRadnikToolStripMenuItem_Click);
            // 
            // saradniciToolStripMenuItem
            // 
            this.saradniciToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sviSaradniciToolStripMenuItem,
            this.novSaradnikToolStripMenuItem});
            this.saradniciToolStripMenuItem.Name = "saradniciToolStripMenuItem";
            this.saradniciToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.saradniciToolStripMenuItem.Text = "Saradnici";
            // 
            // sviSaradniciToolStripMenuItem
            // 
            this.sviSaradniciToolStripMenuItem.Name = "sviSaradniciToolStripMenuItem";
            this.sviSaradniciToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.sviSaradniciToolStripMenuItem.Text = "Svi saradnici";
            this.sviSaradniciToolStripMenuItem.Click += new System.EventHandler(this.sviSaradniciToolStripMenuItem_Click);
            // 
            // novSaradnikToolStripMenuItem
            // 
            this.novSaradnikToolStripMenuItem.Name = "novSaradnikToolStripMenuItem";
            this.novSaradnikToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.novSaradnikToolStripMenuItem.Text = "Nov saradnik";
            this.novSaradnikToolStripMenuItem.Click += new System.EventHandler(this.novSaradnikToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1259, 568);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Location = new System.Drawing.Point(250, 150);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Softcom";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem projektiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sviProjektiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novProjekatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem radniciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sviRadniciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novRadnikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saradniciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sviSaradniciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novSaradnikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;

    }
}

