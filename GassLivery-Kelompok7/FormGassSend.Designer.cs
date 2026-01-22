namespace GassLivery_Kelompok7
{
    partial class FormGassSend
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
            this.comboBoxLokasiAkhir = new System.Windows.Forms.ComboBox();
            this.comboBoxLokasiAwal = new System.Windows.Forms.ComboBox();
            this.labelRP = new System.Windows.Forms.Label();
            this.labelHarga = new System.Windows.Forms.Label();
            this.buttonPesan = new System.Windows.Forms.Button();
            this.buttonCekHarga = new System.Windows.Forms.Button();
            this.checkBoxDiantara5dengan10Kilo = new System.Windows.Forms.CheckBox();
            this.checkBoxKurangDari5Kilo = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBoxDiantara10dengan20Kilo = new System.Windows.Forms.CheckBox();
            this.checkBoxPoin = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxLokasiAkhir
            // 
            this.comboBoxLokasiAkhir.FormattingEnabled = true;
            this.comboBoxLokasiAkhir.Location = new System.Drawing.Point(20, 149);
            this.comboBoxLokasiAkhir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxLokasiAkhir.Name = "comboBoxLokasiAkhir";
            this.comboBoxLokasiAkhir.Size = new System.Drawing.Size(313, 24);
            this.comboBoxLokasiAkhir.TabIndex = 17;
            // 
            // comboBoxLokasiAwal
            // 
            this.comboBoxLokasiAwal.FormattingEnabled = true;
            this.comboBoxLokasiAwal.Location = new System.Drawing.Point(20, 55);
            this.comboBoxLokasiAwal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxLokasiAwal.Name = "comboBoxLokasiAwal";
            this.comboBoxLokasiAwal.Size = new System.Drawing.Size(313, 24);
            this.comboBoxLokasiAwal.TabIndex = 16;
            this.comboBoxLokasiAwal.SelectedIndexChanged += new System.EventHandler(this.comboBoxLokasiAwal_SelectedIndexChanged);
            // 
            // labelRP
            // 
            this.labelRP.AutoSize = true;
            this.labelRP.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRP.Location = new System.Drawing.Point(37, 217);
            this.labelRP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRP.Name = "labelRP";
            this.labelRP.Size = new System.Drawing.Size(57, 31);
            this.labelRP.TabIndex = 15;
            this.labelRP.Text = "Rp.";
            // 
            // labelHarga
            // 
            this.labelHarga.AutoSize = true;
            this.labelHarga.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHarga.Location = new System.Drawing.Point(103, 217);
            this.labelHarga.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHarga.Name = "labelHarga";
            this.labelHarga.Size = new System.Drawing.Size(23, 31);
            this.labelHarga.TabIndex = 14;
            this.labelHarga.Text = "-";
            // 
            // buttonPesan
            // 
            this.buttonPesan.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonPesan.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPesan.Location = new System.Drawing.Point(162, 439);
            this.buttonPesan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonPesan.Name = "buttonPesan";
            this.buttonPesan.Size = new System.Drawing.Size(225, 52);
            this.buttonPesan.TabIndex = 13;
            this.buttonPesan.Text = "Pesan Gass-Send";
            this.buttonPesan.UseVisualStyleBackColor = false;
            this.buttonPesan.Visible = false;
            this.buttonPesan.Click += new System.EventHandler(this.buttonPesan_Click);
            // 
            // buttonCekHarga
            // 
            this.buttonCekHarga.Location = new System.Drawing.Point(195, 359);
            this.buttonCekHarga.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCekHarga.Name = "buttonCekHarga";
            this.buttonCekHarga.Size = new System.Drawing.Size(150, 37);
            this.buttonCekHarga.TabIndex = 12;
            this.buttonCekHarga.Text = "Cek Harga";
            this.buttonCekHarga.UseVisualStyleBackColor = true;
            this.buttonCekHarga.Click += new System.EventHandler(this.buttonCekHarga_Click);
            // 
            // checkBoxDiantara5dengan10Kilo
            // 
            this.checkBoxDiantara5dengan10Kilo.AutoSize = true;
            this.checkBoxDiantara5dengan10Kilo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxDiantara5dengan10Kilo.Location = new System.Drawing.Point(179, 283);
            this.checkBoxDiantara5dengan10Kilo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBoxDiantara5dengan10Kilo.Name = "checkBoxDiantara5dengan10Kilo";
            this.checkBoxDiantara5dengan10Kilo.Size = new System.Drawing.Size(156, 35);
            this.checkBoxDiantara5dengan10Kilo.TabIndex = 11;
            this.checkBoxDiantara5dengan10Kilo.Text = "5 - 10 Kilo";
            this.checkBoxDiantara5dengan10Kilo.UseVisualStyleBackColor = true;
            this.checkBoxDiantara5dengan10Kilo.CheckedChanged += new System.EventHandler(this.checkBoxDiantara5dengan10Kilo_CheckedChanged);
            // 
            // checkBoxKurangDari5Kilo
            // 
            this.checkBoxKurangDari5Kilo.AutoSize = true;
            this.checkBoxKurangDari5Kilo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxKurangDari5Kilo.Location = new System.Drawing.Point(44, 283);
            this.checkBoxKurangDari5Kilo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBoxKurangDari5Kilo.Name = "checkBoxKurangDari5Kilo";
            this.checkBoxKurangDari5Kilo.Size = new System.Drawing.Size(126, 35);
            this.checkBoxKurangDari5Kilo.TabIndex = 10;
            this.checkBoxKurangDari5Kilo.Text = "< 5 Kilo";
            this.checkBoxKurangDari5Kilo.UseVisualStyleBackColor = true;
            this.checkBoxKurangDari5Kilo.CheckedChanged += new System.EventHandler(this.checkBoxKurangDari5Kilo_CheckedChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(13, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(235, 39);
            this.label10.TabIndex = 18;
            this.label10.Text = "Alamat anda : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(322, 39);
            this.label2.TabIndex = 18;
            this.label2.Text = "Tujuan Pengiriman: ";
            // 
            // checkBoxDiantara10dengan20Kilo
            // 
            this.checkBoxDiantara10dengan20Kilo.AutoSize = true;
            this.checkBoxDiantara10dengan20Kilo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxDiantara10dengan20Kilo.Location = new System.Drawing.Point(341, 283);
            this.checkBoxDiantara10dengan20Kilo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBoxDiantara10dengan20Kilo.Name = "checkBoxDiantara10dengan20Kilo";
            this.checkBoxDiantara10dengan20Kilo.Size = new System.Drawing.Size(171, 35);
            this.checkBoxDiantara10dengan20Kilo.TabIndex = 19;
            this.checkBoxDiantara10dengan20Kilo.Text = "10 - 20 Kilo";
            this.checkBoxDiantara10dengan20Kilo.UseVisualStyleBackColor = true;
            this.checkBoxDiantara10dengan20Kilo.CheckedChanged += new System.EventHandler(this.checkBoxDiantara10dengan20Kilo_CheckedChanged);
            // 
            // checkBoxPoin
            // 
            this.checkBoxPoin.AutoSize = true;
            this.checkBoxPoin.Location = new System.Drawing.Point(41, 439);
            this.checkBoxPoin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBoxPoin.Name = "checkBoxPoin";
            this.checkBoxPoin.Size = new System.Drawing.Size(113, 20);
            this.checkBoxPoin.TabIndex = 20;
            this.checkBoxPoin.Text = "Gunakan Poin";
            this.checkBoxPoin.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.comboBoxLokasiAwal);
            this.panel1.Controls.Add(this.comboBoxLokasiAkhir);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(606, 193);
            this.panel1.TabIndex = 21;
            // 
            // FormGassSend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 500);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.checkBoxPoin);
            this.Controls.Add(this.checkBoxDiantara10dengan20Kilo);
            this.Controls.Add(this.labelRP);
            this.Controls.Add(this.labelHarga);
            this.Controls.Add(this.buttonPesan);
            this.Controls.Add(this.buttonCekHarga);
            this.Controls.Add(this.checkBoxDiantara5dengan10Kilo);
            this.Controls.Add(this.checkBoxKurangDari5Kilo);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormGassSend";
            this.Text = "FormGassSend";
            this.Load += new System.EventHandler(this.FormGassSend_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxLokasiAkhir;
        private System.Windows.Forms.ComboBox comboBoxLokasiAwal;
        private System.Windows.Forms.Label labelRP;
        private System.Windows.Forms.Label labelHarga;
        private System.Windows.Forms.Button buttonPesan;
        private System.Windows.Forms.Button buttonCekHarga;
        private System.Windows.Forms.CheckBox checkBoxDiantara5dengan10Kilo;
        private System.Windows.Forms.CheckBox checkBoxKurangDari5Kilo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBoxDiantara10dengan20Kilo;
        private System.Windows.Forms.CheckBox checkBoxPoin;
        private System.Windows.Forms.Panel panel1;
    }
}