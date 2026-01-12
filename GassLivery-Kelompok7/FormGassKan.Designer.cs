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
            this.label10 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBoxRestoran = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonPesan = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panelHeader.Controls.Add(this.label10);
            this.panelHeader.Controls.Add(this.textBox1);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(686, 100);
            this.panelHeader.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(47, 6);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(235, 39);
            this.label10.TabIndex = 4;
            this.label10.Text = "Alamat anda : ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(54, 53);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(552, 22);
            this.textBox1.TabIndex = 0;
            // 
            // comboBoxRestoran
            // 
            this.comboBoxRestoran.FormattingEnabled = true;
            this.comboBoxRestoran.Items.AddRange(new object[] {
            "KFC",
            "HokBen",
            "Solaria"});
            this.comboBoxRestoran.Location = new System.Drawing.Point(41, 201);
            this.comboBoxRestoran.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxRestoran.Name = "comboBoxRestoran";
            this.comboBoxRestoran.Size = new System.Drawing.Size(552, 24);
            this.comboBoxRestoran.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 31);
            this.label1.TabIndex = 12;
            this.label1.Text = "Restoran Pilihan : ";
            // 
            // buttonPesan
            // 
            this.buttonPesan.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonPesan.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPesan.Location = new System.Drawing.Point(186, 327);
            this.buttonPesan.Margin = new System.Windows.Forms.Padding(4);
            this.buttonPesan.Name = "buttonPesan";
            this.buttonPesan.Size = new System.Drawing.Size(272, 72);
            this.buttonPesan.TabIndex = 13;
            this.buttonPesan.Text = "Pesan Gass-kan";
            this.buttonPesan.UseVisualStyleBackColor = false;
            this.buttonPesan.Visible = false;
            // 
            // FormGassKan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(686, 624);
            this.Controls.Add(this.buttonPesan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxRestoran);
            this.Controls.Add(this.panelHeader);
            this.Name = "FormGassKan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormGassKan";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBoxRestoran;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonPesan;
    }
}