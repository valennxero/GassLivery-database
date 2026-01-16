namespace GassLivery_Kelompok7
{
    partial class FormDriver
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownNominal = new System.Windows.Forms.NumericUpDown();
            this.buttonTarik = new System.Windows.Forms.Button();
            this.labelNamaDriver = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelPendapatan = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.riwayatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gassKanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gassRideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.penarikanDanaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNominal)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Anda bisa melakukan penarikan dana";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "setiap hari Minggu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Masukkan nominal";
            // 
            // numericUpDownNominal
            // 
            this.numericUpDownNominal.Location = new System.Drawing.Point(63, 187);
            this.numericUpDownNominal.Name = "numericUpDownNominal";
            this.numericUpDownNominal.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownNominal.TabIndex = 3;
            this.numericUpDownNominal.ValueChanged += new System.EventHandler(this.numericUpDownNominal_ValueChanged);
            // 
            // buttonTarik
            // 
            this.buttonTarik.Location = new System.Drawing.Point(63, 241);
            this.buttonTarik.Name = "buttonTarik";
            this.buttonTarik.Size = new System.Drawing.Size(128, 23);
            this.buttonTarik.TabIndex = 4;
            this.buttonTarik.Text = "Tarik";
            this.buttonTarik.UseVisualStyleBackColor = true;
            this.buttonTarik.Click += new System.EventHandler(this.buttonTarik_Click);
            // 
            // labelNamaDriver
            // 
            this.labelNamaDriver.AutoSize = true;
            this.labelNamaDriver.Location = new System.Drawing.Point(24, 18);
            this.labelNamaDriver.Name = "labelNamaDriver";
            this.labelNamaDriver.Size = new System.Drawing.Size(66, 13);
            this.labelNamaDriver.TabIndex = 5;
            this.labelNamaDriver.Text = "(namadriver}";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(132, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Total Pendapatan";
            // 
            // labelPendapatan
            // 
            this.labelPendapatan.AutoSize = true;
            this.labelPendapatan.Location = new System.Drawing.Point(230, 18);
            this.labelPendapatan.Name = "labelPendapatan";
            this.labelPendapatan.Size = new System.Drawing.Size(13, 13);
            this.labelPendapatan.TabIndex = 7;
            this.labelPendapatan.Text = "0";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.riwayatToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 426);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(334, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // riwayatToolStripMenuItem
            // 
            this.riwayatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.penarikanDanaToolStripMenuItem,
            this.gassRideToolStripMenuItem,
            this.gassKanToolStripMenuItem});
            this.riwayatToolStripMenuItem.Name = "riwayatToolStripMenuItem";
            this.riwayatToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.riwayatToolStripMenuItem.Text = "Riwayat";
            // 
            // gassKanToolStripMenuItem
            // 
            this.gassKanToolStripMenuItem.Name = "gassKanToolStripMenuItem";
            this.gassKanToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.gassKanToolStripMenuItem.Text = "Gass-Kan";
            this.gassKanToolStripMenuItem.Click += new System.EventHandler(this.gassKanToolStripMenuItem_Click);
            // 
            // gassRideToolStripMenuItem
            // 
            this.gassRideToolStripMenuItem.Name = "gassRideToolStripMenuItem";
            this.gassRideToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.gassRideToolStripMenuItem.Text = "Gass-Ride";
            this.gassRideToolStripMenuItem.Click += new System.EventHandler(this.gassRideToolStripMenuItem_Click);
            // 
            // penarikanDanaToolStripMenuItem
            // 
            this.penarikanDanaToolStripMenuItem.Name = "penarikanDanaToolStripMenuItem";
            this.penarikanDanaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.penarikanDanaToolStripMenuItem.Text = "Penarikan Dana";
            this.penarikanDanaToolStripMenuItem.Click += new System.EventHandler(this.penarikanDanaToolStripMenuItem_Click);
            // 
            // FormDriver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 450);
            this.Controls.Add(this.labelPendapatan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelNamaDriver);
            this.Controls.Add(this.buttonTarik);
            this.Controls.Add(this.numericUpDownNominal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormDriver";
            this.Text = "FormDriver";
            this.Load += new System.EventHandler(this.FormDriver_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNominal)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownNominal;
        private System.Windows.Forms.Button buttonTarik;
        private System.Windows.Forms.Label labelNamaDriver;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelPendapatan;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem riwayatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gassRideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gassKanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem penarikanDanaToolStripMenuItem;
    }
}