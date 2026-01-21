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
            this.SuspendLayout();
            // 
            // comboBoxLokasiAkhir
            // 
            this.comboBoxLokasiAkhir.FormattingEnabled = true;
            this.comboBoxLokasiAkhir.Location = new System.Drawing.Point(30, 117);
            this.comboBoxLokasiAkhir.Name = "comboBoxLokasiAkhir";
            this.comboBoxLokasiAkhir.Size = new System.Drawing.Size(236, 21);
            this.comboBoxLokasiAkhir.TabIndex = 17;
            // 
            // comboBoxLokasiAwal
            // 
            this.comboBoxLokasiAwal.FormattingEnabled = true;
            this.comboBoxLokasiAwal.Location = new System.Drawing.Point(30, 41);
            this.comboBoxLokasiAwal.Name = "comboBoxLokasiAwal";
            this.comboBoxLokasiAwal.Size = new System.Drawing.Size(236, 21);
            this.comboBoxLokasiAwal.TabIndex = 16;
            this.comboBoxLokasiAwal.SelectedIndexChanged += new System.EventHandler(this.comboBoxLokasiAwal_SelectedIndexChanged);
            // 
            // labelRP
            // 
            this.labelRP.AutoSize = true;
            this.labelRP.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRP.Location = new System.Drawing.Point(28, 158);
            this.labelRP.Name = "labelRP";
            this.labelRP.Size = new System.Drawing.Size(46, 26);
            this.labelRP.TabIndex = 15;
            this.labelRP.Text = "Rp.";
            // 
            // labelHarga
            // 
            this.labelHarga.AutoSize = true;
            this.labelHarga.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHarga.Location = new System.Drawing.Point(77, 158);
            this.labelHarga.Name = "labelHarga";
            this.labelHarga.Size = new System.Drawing.Size(19, 26);
            this.labelHarga.TabIndex = 14;
            this.labelHarga.Text = "-";
            // 
            // buttonPesan
            // 
            this.buttonPesan.Location = new System.Drawing.Point(131, 357);
            this.buttonPesan.Name = "buttonPesan";
            this.buttonPesan.Size = new System.Drawing.Size(142, 23);
            this.buttonPesan.TabIndex = 13;
            this.buttonPesan.Text = "Pesan Gass-Send";
            this.buttonPesan.UseVisualStyleBackColor = true;
            this.buttonPesan.Visible = false;
            this.buttonPesan.Click += new System.EventHandler(this.buttonPesan_Click);
            // 
            // buttonCekHarga
            // 
            this.buttonCekHarga.Location = new System.Drawing.Point(152, 312);
            this.buttonCekHarga.Name = "buttonCekHarga";
            this.buttonCekHarga.Size = new System.Drawing.Size(75, 23);
            this.buttonCekHarga.TabIndex = 12;
            this.buttonCekHarga.Text = "Cek Harga";
            this.buttonCekHarga.UseVisualStyleBackColor = true;
            this.buttonCekHarga.Click += new System.EventHandler(this.buttonCekHarga_Click);
            // 
            // checkBoxDiantara5dengan10Kilo
            // 
            this.checkBoxDiantara5dengan10Kilo.AutoSize = true;
            this.checkBoxDiantara5dengan10Kilo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxDiantara5dengan10Kilo.Location = new System.Drawing.Point(134, 211);
            this.checkBoxDiantara5dengan10Kilo.Name = "checkBoxDiantara5dengan10Kilo";
            this.checkBoxDiantara5dengan10Kilo.Size = new System.Drawing.Size(129, 30);
            this.checkBoxDiantara5dengan10Kilo.TabIndex = 11;
            this.checkBoxDiantara5dengan10Kilo.Text = "5 - 10 Kilo";
            this.checkBoxDiantara5dengan10Kilo.UseVisualStyleBackColor = true;
            this.checkBoxDiantara5dengan10Kilo.CheckedChanged += new System.EventHandler(this.checkBoxDiantara5dengan10Kilo_CheckedChanged);
            // 
            // checkBoxKurangDari5Kilo
            // 
            this.checkBoxKurangDari5Kilo.AutoSize = true;
            this.checkBoxKurangDari5Kilo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxKurangDari5Kilo.Location = new System.Drawing.Point(33, 211);
            this.checkBoxKurangDari5Kilo.Name = "checkBoxKurangDari5Kilo";
            this.checkBoxKurangDari5Kilo.Size = new System.Drawing.Size(105, 30);
            this.checkBoxKurangDari5Kilo.TabIndex = 10;
            this.checkBoxKurangDari5Kilo.Text = "< 5 Kilo";
            this.checkBoxKurangDari5Kilo.UseVisualStyleBackColor = true;
            this.checkBoxKurangDari5Kilo.CheckedChanged += new System.EventHandler(this.checkBoxKurangDari5Kilo_CheckedChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(25, 6);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(187, 31);
            this.label10.TabIndex = 18;
            this.label10.Text = "Alamat anda : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(255, 31);
            this.label2.TabIndex = 18;
            this.label2.Text = "Tujuan Pengiriman: ";
            // 
            // checkBoxDiantara10dengan20Kilo
            // 
            this.checkBoxDiantara10dengan20Kilo.AutoSize = true;
            this.checkBoxDiantara10dengan20Kilo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxDiantara10dengan20Kilo.Location = new System.Drawing.Point(256, 211);
            this.checkBoxDiantara10dengan20Kilo.Name = "checkBoxDiantara10dengan20Kilo";
            this.checkBoxDiantara10dengan20Kilo.Size = new System.Drawing.Size(141, 30);
            this.checkBoxDiantara10dengan20Kilo.TabIndex = 19;
            this.checkBoxDiantara10dengan20Kilo.Text = "10 - 20 Kilo";
            this.checkBoxDiantara10dengan20Kilo.UseVisualStyleBackColor = true;
            this.checkBoxDiantara10dengan20Kilo.CheckedChanged += new System.EventHandler(this.checkBoxDiantara10dengan20Kilo_CheckedChanged);
            // 
            // checkBoxPoin
            // 
            this.checkBoxPoin.AutoSize = true;
            this.checkBoxPoin.Location = new System.Drawing.Point(31, 357);
            this.checkBoxPoin.Name = "checkBoxPoin";
            this.checkBoxPoin.Size = new System.Drawing.Size(94, 17);
            this.checkBoxPoin.TabIndex = 20;
            this.checkBoxPoin.Text = "Gunakan Poin";
            this.checkBoxPoin.UseVisualStyleBackColor = true;
            // 
            // FormGassSend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 444);
            this.Controls.Add(this.checkBoxPoin);
            this.Controls.Add(this.checkBoxDiantara10dengan20Kilo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.comboBoxLokasiAkhir);
            this.Controls.Add(this.comboBoxLokasiAwal);
            this.Controls.Add(this.labelRP);
            this.Controls.Add(this.labelHarga);
            this.Controls.Add(this.buttonPesan);
            this.Controls.Add(this.buttonCekHarga);
            this.Controls.Add(this.checkBoxDiantara5dengan10Kilo);
            this.Controls.Add(this.checkBoxKurangDari5Kilo);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormGassSend";
            this.Text = "FormGassSend";
            this.Load += new System.EventHandler(this.FormGassSend_Load);
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
    }
}