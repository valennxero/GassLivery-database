namespace GassLivery_Kelompok7
{
    partial class FormGassKanKonfirmasi
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
            this.buttonSelesaikanPesanan = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.labelRating = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelTenan = new System.Windows.Forms.Label();
            this.labelNamaDriver = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelHarga = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelRatingTenan = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonSelesaikanPesanan
            // 
            this.buttonSelesaikanPesanan.Location = new System.Drawing.Point(121, 193);
            this.buttonSelesaikanPesanan.Name = "buttonSelesaikanPesanan";
            this.buttonSelesaikanPesanan.Size = new System.Drawing.Size(131, 23);
            this.buttonSelesaikanPesanan.TabIndex = 19;
            this.buttonSelesaikanPesanan.Text = "Konfirmasi Selesai";
            this.buttonSelesaikanPesanan.UseVisualStyleBackColor = true;
            this.buttonSelesaikanPesanan.Click += new System.EventHandler(this.buttonSelesaikanPesanan_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(375, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Terimakasih Sudah Memesan, Driver akan Segera Mengantar Makanan Anda";
            // 
            // labelRating
            // 
            this.labelRating.AutoSize = true;
            this.labelRating.Location = new System.Drawing.Point(313, 29);
            this.labelRating.Name = "labelRating";
            this.labelRating.Size = new System.Drawing.Size(10, 13);
            this.labelRating.TabIndex = 16;
            this.labelRating.Text = "-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(205, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Rating Driver:";
            // 
            // labelTenan
            // 
            this.labelTenan.AutoSize = true;
            this.labelTenan.Location = new System.Drawing.Point(94, 63);
            this.labelTenan.Name = "labelTenan";
            this.labelTenan.Size = new System.Drawing.Size(79, 13);
            this.labelTenan.TabIndex = 13;
            this.labelTenan.Text = "(nama_Tenant)";
            // 
            // labelNamaDriver
            // 
            this.labelNamaDriver.AutoSize = true;
            this.labelNamaDriver.Location = new System.Drawing.Point(118, 29);
            this.labelNamaDriver.Name = "labelNamaDriver";
            this.labelNamaDriver.Size = new System.Drawing.Size(10, 13);
            this.labelNamaDriver.TabIndex = 12;
            this.labelNamaDriver.Text = "-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Tenant";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nama Driver : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Total Harga : Rp";
            // 
            // labelHarga
            // 
            this.labelHarga.AutoSize = true;
            this.labelHarga.Location = new System.Drawing.Point(205, 96);
            this.labelHarga.Name = "labelHarga";
            this.labelHarga.Size = new System.Drawing.Size(40, 13);
            this.labelHarga.TabIndex = 21;
            this.labelHarga.Text = "(harga)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(205, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Rating Tenant :";
            // 
            // labelRatingTenan
            // 
            this.labelRatingTenan.AutoSize = true;
            this.labelRatingTenan.Location = new System.Drawing.Point(313, 63);
            this.labelRatingTenan.Name = "labelRatingTenan";
            this.labelRatingTenan.Size = new System.Drawing.Size(10, 13);
            this.labelRatingTenan.TabIndex = 23;
            this.labelRatingTenan.Text = "-";
            // 
            // FormGassKanKonfirmasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 450);
            this.Controls.Add(this.labelRatingTenan);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelHarga);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonSelesaikanPesanan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelRating);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelTenan);
            this.Controls.Add(this.labelNamaDriver);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormGassKanKonfirmasi";
            this.Text = "FormGassKanKonfirmasi";
            this.Load += new System.EventHandler(this.FormGassKanKonfirmasi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSelesaikanPesanan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelRating;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelTenan;
        private System.Windows.Forms.Label labelNamaDriver;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelHarga;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelRatingTenan;
    }
}