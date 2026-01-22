namespace GassLivery_Kelompok7
{
    partial class FormAdmin
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
            this.daftarMotorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cekLaporanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transaksiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gassRideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gassKanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gassSendToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.daftarMotorToolStripMenuItem,
            this.cekLaporanToolStripMenuItem,
            this.transaksiToolStripMenuItem,
            this.cancelToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(387, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // daftarMotorToolStripMenuItem
            // 
            this.daftarMotorToolStripMenuItem.Name = "daftarMotorToolStripMenuItem";
            this.daftarMotorToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.daftarMotorToolStripMenuItem.Text = "Daftar Motor";
            this.daftarMotorToolStripMenuItem.Click += new System.EventHandler(this.daftarMotorToolStripMenuItem_Click);
            // 
            // cekLaporanToolStripMenuItem
            // 
            this.cekLaporanToolStripMenuItem.Name = "cekLaporanToolStripMenuItem";
            this.cekLaporanToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.cekLaporanToolStripMenuItem.Text = "Cek Laporan";
            this.cekLaporanToolStripMenuItem.Click += new System.EventHandler(this.cekLaporanToolStripMenuItem_Click);
            // 
            // transaksiToolStripMenuItem
            // 
            this.transaksiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gassRideToolStripMenuItem,
            this.gassKanToolStripMenuItem,
            this.gassSendToolStripMenuItem});
            this.transaksiToolStripMenuItem.Name = "transaksiToolStripMenuItem";
            this.transaksiToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.transaksiToolStripMenuItem.Text = "Transaksi";
            // 
            // gassRideToolStripMenuItem
            // 
            this.gassRideToolStripMenuItem.Name = "gassRideToolStripMenuItem";
            this.gassRideToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.gassRideToolStripMenuItem.Text = "GassRide";
            this.gassRideToolStripMenuItem.Click += new System.EventHandler(this.gassRideToolStripMenuItem_Click);
            // 
            // gassKanToolStripMenuItem
            // 
            this.gassKanToolStripMenuItem.Name = "gassKanToolStripMenuItem";
            this.gassKanToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.gassKanToolStripMenuItem.Text = "GassKan";
            this.gassKanToolStripMenuItem.Click += new System.EventHandler(this.gassKanToolStripMenuItem_Click);
            // 
            // gassSendToolStripMenuItem
            // 
            this.gassSendToolStripMenuItem.Name = "gassSendToolStripMenuItem";
            this.gassSendToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.gassSendToolStripMenuItem.Text = "GassSend";
            this.gassSendToolStripMenuItem.Click += new System.EventHandler(this.gassSendToolStripMenuItem_Click);
            // 
            // cancelToolStripMenuItem
            // 
            this.cancelToolStripMenuItem.Name = "cancelToolStripMenuItem";
            this.cancelToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.cancelToolStripMenuItem.Text = "Cancel";
            this.cancelToolStripMenuItem.Click += new System.EventHandler(this.cancelToolStripMenuItem_Click);
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormAdmin";
            this.Text = "FormAdmin";
            this.Load += new System.EventHandler(this.FormAdmin_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem daftarMotorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cekLaporanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transaksiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gassRideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gassKanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gassSendToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelToolStripMenuItem;
    }
}