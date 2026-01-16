namespace GassLivery_Kelompok7
{
    partial class FormNotaGassKan
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
            this.buttonClose = new System.Windows.Forms.Button();
            this.labelBiaya = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.labelPlat = new System.Windows.Forms.Label();
            this.labelTanggal = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.labelNamaDriver = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelLokasiTujuan = new System.Windows.Forms.Label();
            this.labelTenant = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelIdOrder = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewKeranjang = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Jumlah = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HargaTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelLokasiTenant = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelOngkir = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKeranjang)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(152, 344);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(103, 23);
            this.buttonClose.TabIndex = 31;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // labelBiaya
            // 
            this.labelBiaya.AutoSize = true;
            this.labelBiaya.Location = new System.Drawing.Point(257, 312);
            this.labelBiaya.Name = "labelBiaya";
            this.labelBiaya.Size = new System.Drawing.Size(49, 13);
            this.labelBiaya.TabIndex = 30;
            this.labelBiaya.Text = "(nominal)";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(220, 312);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(27, 13);
            this.label14.TabIndex = 29;
            this.label14.Text = "Rp. ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(76, 312);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(88, 13);
            this.label13.TabIndex = 28;
            this.label13.Text = "Biaya Transaksi :";
            // 
            // labelPlat
            // 
            this.labelPlat.AutoSize = true;
            this.labelPlat.Location = new System.Drawing.Point(213, 165);
            this.labelPlat.Name = "labelPlat";
            this.labelPlat.Size = new System.Drawing.Size(62, 13);
            this.labelPlat.TabIndex = 27;
            this.labelPlat.Text = "(plat nomor)";
            // 
            // labelTanggal
            // 
            this.labelTanggal.AutoSize = true;
            this.labelTanggal.Location = new System.Drawing.Point(113, 78);
            this.labelTanggal.Name = "labelTanggal";
            this.labelTanggal.Size = new System.Drawing.Size(51, 13);
            this.labelTanggal.TabIndex = 26;
            this.labelTanggal.Text = "(tgl order)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(26, 78);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "Tanggal order :";
            // 
            // labelNamaDriver
            // 
            this.labelNamaDriver.AutoSize = true;
            this.labelNamaDriver.Location = new System.Drawing.Point(116, 165);
            this.labelNamaDriver.Name = "labelNamaDriver";
            this.labelNamaDriver.Size = new System.Drawing.Size(68, 13);
            this.labelNamaDriver.TabIndex = 24;
            this.labelNamaDriver.Text = "(nama driver)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 165);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Driver : ";
            // 
            // labelLokasiTujuan
            // 
            this.labelLokasiTujuan.AutoSize = true;
            this.labelLokasiTujuan.Location = new System.Drawing.Point(290, 78);
            this.labelLokasiTujuan.Name = "labelLokasiTujuan";
            this.labelLokasiTujuan.Size = new System.Drawing.Size(72, 13);
            this.labelLokasiTujuan.TabIndex = 22;
            this.labelLokasiTujuan.Text = "(lokasi tujuan)";
            // 
            // labelTenant
            // 
            this.labelTenant.AutoSize = true;
            this.labelTenant.Location = new System.Drawing.Point(290, 45);
            this.labelTenant.Name = "labelTenant";
            this.labelTenant.Size = new System.Drawing.Size(65, 13);
            this.labelTenant.TabIndex = 21;
            this.labelTenant.Text = "(lokasi awal)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(228, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Titik Antar :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(228, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Tenant :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(149, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "NOTA GASS-RIDE";
            // 
            // labelIdOrder
            // 
            this.labelIdOrder.AutoSize = true;
            this.labelIdOrder.Location = new System.Drawing.Point(113, 46);
            this.labelIdOrder.Name = "labelIdOrder";
            this.labelIdOrder.Size = new System.Drawing.Size(35, 13);
            this.labelIdOrder.TabIndex = 17;
            this.labelIdOrder.Text = "XXXX";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Id Transaksi :";
            // 
            // dataGridViewKeranjang
            // 
            this.dataGridViewKeranjang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKeranjang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.Jumlah,
            this.HargaTotal});
            this.dataGridViewKeranjang.Location = new System.Drawing.Point(-8, 137);
            this.dataGridViewKeranjang.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewKeranjang.Name = "dataGridViewKeranjang";
            this.dataGridViewKeranjang.RowHeadersWidth = 51;
            this.dataGridViewKeranjang.RowTemplate.Height = 24;
            this.dataGridViewKeranjang.Size = new System.Drawing.Size(455, 157);
            this.dataGridViewKeranjang.TabIndex = 32;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Nama Menu";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Harga Satuan";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // Jumlah
            // 
            this.Jumlah.HeaderText = "Jumlah";
            this.Jumlah.Name = "Jumlah";
            // 
            // HargaTotal
            // 
            this.HargaTotal.HeaderText = "SubTotal";
            this.HargaTotal.Name = "HargaTotal";
            // 
            // labelLokasiTenant
            // 
            this.labelLokasiTenant.AutoSize = true;
            this.labelLokasiTenant.Location = new System.Drawing.Point(361, 45);
            this.labelLokasiTenant.Name = "labelLokasiTenant";
            this.labelLokasiTenant.Size = new System.Drawing.Size(65, 13);
            this.labelLokasiTenant.TabIndex = 33;
            this.labelLokasiTenant.Text = "(lokasi awal)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(228, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Ongkir :";
            // 
            // labelOngkir
            // 
            this.labelOngkir.AutoSize = true;
            this.labelOngkir.Location = new System.Drawing.Point(290, 108);
            this.labelOngkir.Name = "labelOngkir";
            this.labelOngkir.Size = new System.Drawing.Size(42, 13);
            this.labelOngkir.TabIndex = 35;
            this.labelOngkir.Text = "(ongkir)";
            // 
            // FormNotaGassKan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 391);
            this.Controls.Add(this.labelOngkir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelLokasiTenant);
            this.Controls.Add(this.dataGridViewKeranjang);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.labelBiaya);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.labelPlat);
            this.Controls.Add(this.labelTanggal);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.labelNamaDriver);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.labelLokasiTujuan);
            this.Controls.Add(this.labelTenant);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelIdOrder);
            this.Controls.Add(this.label1);
            this.Name = "FormNotaGassKan";
            this.Text = "FormNotaGassKan";
            this.Load += new System.EventHandler(this.FormNotaGassKan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKeranjang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label labelBiaya;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label labelPlat;
        private System.Windows.Forms.Label labelTanggal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labelNamaDriver;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelLokasiTujuan;
        private System.Windows.Forms.Label labelTenant;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelIdOrder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewKeranjang;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Jumlah;
        private System.Windows.Forms.DataGridViewTextBoxColumn HargaTotal;
        private System.Windows.Forms.Label labelLokasiTenant;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelOngkir;
    }
}