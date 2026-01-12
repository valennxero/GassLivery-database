namespace GassLivery_Kelompok7
{
    partial class FormGassRideKonfirmasi
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
            this.labelNamaDriver = new System.Windows.Forms.Label();
            this.labelMotor = new System.Windows.Forms.Label();
            this.labelPlat = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelRating = new System.Windows.Forms.Label();
            this.buttonCancelOrder = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonSelesaikanPesanan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama Driver : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Motor : ";
            // 
            // labelNamaDriver
            // 
            this.labelNamaDriver.AutoSize = true;
            this.labelNamaDriver.Location = new System.Drawing.Point(117, 64);
            this.labelNamaDriver.Name = "labelNamaDriver";
            this.labelNamaDriver.Size = new System.Drawing.Size(10, 13);
            this.labelNamaDriver.TabIndex = 2;
            this.labelNamaDriver.Text = "-";
            // 
            // labelMotor
            // 
            this.labelMotor.AutoSize = true;
            this.labelMotor.Location = new System.Drawing.Point(93, 98);
            this.labelMotor.Name = "labelMotor";
            this.labelMotor.Size = new System.Drawing.Size(71, 13);
            this.labelMotor.TabIndex = 3;
            this.labelMotor.Text = "(nama_motor)";
            // 
            // labelPlat
            // 
            this.labelPlat.AutoSize = true;
            this.labelPlat.Location = new System.Drawing.Point(209, 98);
            this.labelPlat.Name = "labelPlat";
            this.labelPlat.Size = new System.Drawing.Size(59, 13);
            this.labelPlat.TabIndex = 4;
            this.labelPlat.Text = "(plat motor)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(172, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Rating Driver:";
            // 
            // labelRating
            // 
            this.labelRating.AutoSize = true;
            this.labelRating.Location = new System.Drawing.Point(267, 64);
            this.labelRating.Name = "labelRating";
            this.labelRating.Size = new System.Drawing.Size(10, 13);
            this.labelRating.TabIndex = 6;
            this.labelRating.Text = "-";
            // 
            // buttonCancelOrder
            // 
            this.buttonCancelOrder.Location = new System.Drawing.Point(96, 239);
            this.buttonCancelOrder.Name = "buttonCancelOrder";
            this.buttonCancelOrder.Size = new System.Drawing.Size(131, 23);
            this.buttonCancelOrder.TabIndex = 7;
            this.buttonCancelOrder.Text = "Batalkan Pesanan";
            this.buttonCancelOrder.UseVisualStyleBackColor = true;
            this.buttonCancelOrder.Click += new System.EventHandler(this.buttonCancelOrder_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(288, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Terimakasih, Driver anda akan segera tiba menjemput anda";
            // 
            // buttonSelesaikanPesanan
            // 
            this.buttonSelesaikanPesanan.Location = new System.Drawing.Point(96, 293);
            this.buttonSelesaikanPesanan.Name = "buttonSelesaikanPesanan";
            this.buttonSelesaikanPesanan.Size = new System.Drawing.Size(131, 23);
            this.buttonSelesaikanPesanan.TabIndex = 9;
            this.buttonSelesaikanPesanan.Text = "Konfirmasi Selesai";
            this.buttonSelesaikanPesanan.UseVisualStyleBackColor = true;
            this.buttonSelesaikanPesanan.Click += new System.EventHandler(this.buttonSelesaikanPesanan_Click);
            // 
            // FormGassRideKonfirmasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 450);
            this.Controls.Add(this.buttonSelesaikanPesanan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonCancelOrder);
            this.Controls.Add(this.labelRating);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelPlat);
            this.Controls.Add(this.labelMotor);
            this.Controls.Add(this.labelNamaDriver);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormGassRideKonfirmasi";
            this.Text = "FormGassRideKonfirmasi";
            this.Load += new System.EventHandler(this.FormGassRideKonfirmasi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelNamaDriver;
        private System.Windows.Forms.Label labelMotor;
        private System.Windows.Forms.Label labelPlat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelRating;
        private System.Windows.Forms.Button buttonCancelOrder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonSelesaikanPesanan;
    }
}