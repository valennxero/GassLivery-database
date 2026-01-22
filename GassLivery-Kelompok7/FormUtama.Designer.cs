namespace GassLivery_Kelompok7
{
    partial class FormUtama
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
            this.buttonRide = new System.Windows.Forms.Button();
            this.buttonGassKan = new System.Windows.Forms.Button();
            this.labelHomeMenu = new System.Windows.Forms.Label();
            this.buttonGassSend = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelSaldo = new System.Windows.Forms.Label();
            this.labelPoin = new System.Windows.Forms.Label();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.riwayatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.topUpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gassSendToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gassKanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gassRideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.topUpSaldoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonRide
            // 
            this.buttonRide.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRide.Location = new System.Drawing.Point(16, 208);
            this.buttonRide.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonRide.Name = "buttonRide";
            this.buttonRide.Size = new System.Drawing.Size(143, 80);
            this.buttonRide.TabIndex = 0;
            this.buttonRide.Text = "Gass-Ride";
            this.buttonRide.UseVisualStyleBackColor = true;
            this.buttonRide.Click += new System.EventHandler(this.buttonRide_Click);
            // 
            // buttonGassKan
            // 
            this.buttonGassKan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGassKan.Location = new System.Drawing.Point(167, 208);
            this.buttonGassKan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonGassKan.Name = "buttonGassKan";
            this.buttonGassKan.Size = new System.Drawing.Size(143, 80);
            this.buttonGassKan.TabIndex = 1;
            this.buttonGassKan.Text = "Gass-Kan";
            this.buttonGassKan.UseVisualStyleBackColor = true;
            this.buttonGassKan.Click += new System.EventHandler(this.buttonGassKan_Click);
            // 
            // labelHomeMenu
            // 
            this.labelHomeMenu.BackColor = System.Drawing.SystemColors.HotTrack;
            this.labelHomeMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHomeMenu.ForeColor = System.Drawing.SystemColors.Control;
            this.labelHomeMenu.Location = new System.Drawing.Point(4, 19);
            this.labelHomeMenu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHomeMenu.Name = "labelHomeMenu";
            this.labelHomeMenu.Size = new System.Drawing.Size(482, 43);
            this.labelHomeMenu.TabIndex = 6;
            this.labelHomeMenu.Text = "Home Menu";
            this.labelHomeMenu.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelHomeMenu.UseCompatibleTextRendering = true;
            // 
            // buttonGassSend
            // 
            this.buttonGassSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGassSend.Location = new System.Drawing.Point(317, 208);
            this.buttonGassSend.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonGassSend.Name = "buttonGassSend";
            this.buttonGassSend.Size = new System.Drawing.Size(143, 78);
            this.buttonGassSend.TabIndex = 8;
            this.buttonGassSend.Text = "Gass-Send";
            this.buttonGassSend.UseVisualStyleBackColor = true;
            this.buttonGassSend.Click += new System.EventHandler(this.buttonGassSend_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 97);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Saldo :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(257, 97);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Poin :";
            // 
            // labelSaldo
            // 
            this.labelSaldo.AutoSize = true;
            this.labelSaldo.Location = new System.Drawing.Point(108, 97);
            this.labelSaldo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSaldo.Name = "labelSaldo";
            this.labelSaldo.Size = new System.Drawing.Size(14, 16);
            this.labelSaldo.TabIndex = 12;
            this.labelSaldo.Text = "0";
            // 
            // labelPoin
            // 
            this.labelPoin.AutoSize = true;
            this.labelPoin.Location = new System.Drawing.Point(330, 97);
            this.labelPoin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPoin.Name = "labelPoin";
            this.labelPoin.Size = new System.Drawing.Size(14, 16);
            this.labelPoin.TabIndex = 13;
            this.labelPoin.Text = "0";
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(25, 137);
            this.buttonRefresh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(100, 28);
            this.buttonRefresh.TabIndex = 14;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.riwayatToolStripMenuItem,
            this.topUpSaldoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 393);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(500, 28);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // riwayatToolStripMenuItem
            // 
            this.riwayatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.topUpToolStripMenuItem,
            this.gassSendToolStripMenuItem,
            this.gassKanToolStripMenuItem,
            this.gassRideToolStripMenuItem});
            this.riwayatToolStripMenuItem.Name = "riwayatToolStripMenuItem";
            this.riwayatToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.riwayatToolStripMenuItem.Text = "Riwayat";
            // 
            // topUpToolStripMenuItem
            // 
            this.topUpToolStripMenuItem.Name = "topUpToolStripMenuItem";
            this.topUpToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.topUpToolStripMenuItem.Text = "Top Up";
            this.topUpToolStripMenuItem.Click += new System.EventHandler(this.topUpToolStripMenuItem_Click);
            // 
            // gassSendToolStripMenuItem
            // 
            this.gassSendToolStripMenuItem.Name = "gassSendToolStripMenuItem";
            this.gassSendToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.gassSendToolStripMenuItem.Text = "Gass-Send";
            this.gassSendToolStripMenuItem.Click += new System.EventHandler(this.gassSendToolStripMenuItem_Click);
            // 
            // gassKanToolStripMenuItem
            // 
            this.gassKanToolStripMenuItem.Name = "gassKanToolStripMenuItem";
            this.gassKanToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.gassKanToolStripMenuItem.Text = "Gass-Kan";
            this.gassKanToolStripMenuItem.Click += new System.EventHandler(this.gassKanToolStripMenuItem_Click);
            // 
            // gassRideToolStripMenuItem
            // 
            this.gassRideToolStripMenuItem.Name = "gassRideToolStripMenuItem";
            this.gassRideToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.gassRideToolStripMenuItem.Text = "Gass-Ride";
            this.gassRideToolStripMenuItem.Click += new System.EventHandler(this.gassRideToolStripMenuItem_Click);
            // 
            // topUpSaldoToolStripMenuItem
            // 
            this.topUpSaldoToolStripMenuItem.Name = "topUpSaldoToolStripMenuItem";
            this.topUpSaldoToolStripMenuItem.Size = new System.Drawing.Size(113, 24);
            this.topUpSaldoToolStripMenuItem.Text = "Top Up Saldo";
            this.topUpSaldoToolStripMenuItem.Click += new System.EventHandler(this.topUpSaldoToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.labelHomeMenu);
            this.panel1.Location = new System.Drawing.Point(1, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(499, 90);
            this.panel1.TabIndex = 18;
            // 
            // FormUtama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(500, 421);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.labelPoin);
            this.Controls.Add(this.labelSaldo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonGassSend);
            this.Controls.Add(this.buttonGassKan);
            this.Controls.Add(this.buttonRide);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormUtama";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormUtama_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRide;
        private System.Windows.Forms.Button buttonGassKan;
        private System.Windows.Forms.Label labelHomeMenu;
        private System.Windows.Forms.Button buttonGassSend;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelSaldo;
        private System.Windows.Forms.Label labelPoin;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem riwayatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem topUpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gassSendToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gassKanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gassRideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem topUpSaldoToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
    }
}

