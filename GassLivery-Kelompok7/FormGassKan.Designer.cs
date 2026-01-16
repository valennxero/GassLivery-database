namespace GassLivery_Kelompok7
{
    partial class FormGassKan
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
            this.panelHeader = new System.Windows.Forms.Panel();
            this.comboBoxAlamat = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBoxTenant = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCek = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panelHeader.Controls.Add(this.comboBoxAlamat);
            this.panelHeader.Controls.Add(this.label10);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(2);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(514, 81);
            this.panelHeader.TabIndex = 11;
            // 
            // comboBoxAlamat
            // 
            this.comboBoxAlamat.FormattingEnabled = true;
            this.comboBoxAlamat.Location = new System.Drawing.Point(31, 49);
            this.comboBoxAlamat.Name = "comboBoxAlamat";
            this.comboBoxAlamat.Size = new System.Drawing.Size(424, 21);
            this.comboBoxAlamat.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(35, 5);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(187, 31);
            this.label10.TabIndex = 4;
            this.label10.Text = "Alamat anda : ";
            // 
            // comboBoxTenant
            // 
            this.comboBoxTenant.FormattingEnabled = true;
            this.comboBoxTenant.Items.AddRange(new object[] {
            "KFC",
            "HokBen",
            "Solaria"});
            this.comboBoxTenant.Location = new System.Drawing.Point(31, 163);
            this.comboBoxTenant.Name = "comboBoxTenant";
            this.comboBoxTenant.Size = new System.Drawing.Size(415, 21);
            this.comboBoxTenant.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 122);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 26);
            this.label1.TabIndex = 12;
            this.label1.Text = "Restoran Pilihan : ";
            // 
            // buttonCek
            // 
            this.buttonCek.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonCek.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCek.Location = new System.Drawing.Point(140, 266);
            this.buttonCek.Name = "buttonCek";
            this.buttonCek.Size = new System.Drawing.Size(204, 58);
            this.buttonCek.TabIndex = 13;
            this.buttonCek.Text = "Cek Menu";
            this.buttonCek.UseVisualStyleBackColor = false;
            this.buttonCek.Click += new System.EventHandler(this.buttonCek_Click);
            // 
            // FormGassKan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(514, 507);
            this.Controls.Add(this.buttonCek);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxTenant);
            this.Controls.Add(this.panelHeader);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormGassKan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormGassKan";
            this.Load += new System.EventHandler(this.FormGassKan_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBoxTenant;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCek;
        private System.Windows.Forms.ComboBox comboBoxAlamat;
    }
}