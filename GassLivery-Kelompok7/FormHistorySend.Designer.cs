namespace GassLivery_Kelompok7
{
    partial class FormHistorySend
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
            this.dataGridViewDataRiwayat = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.dateTimePickerAkhir = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerAwal = new System.Windows.Forms.DateTimePicker();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tanggal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Biaya = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.driver = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Berat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detail = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDataRiwayat)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDataRiwayat
            // 
            this.dataGridViewDataRiwayat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDataRiwayat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Tanggal,
            this.Biaya,
            this.driver,
            this.Tip,
            this.Berat,
            this.Detail});
            this.dataGridViewDataRiwayat.Location = new System.Drawing.Point(12, 117);
            this.dataGridViewDataRiwayat.Name = "dataGridViewDataRiwayat";
            this.dataGridViewDataRiwayat.Size = new System.Drawing.Size(749, 261);
            this.dataGridViewDataRiwayat.TabIndex = 8;
            this.dataGridViewDataRiwayat.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDataRiwayat_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "History Gass Send";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(545, 69);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 13;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // dateTimePickerAkhir
            // 
            this.dateTimePickerAkhir.Location = new System.Drawing.Point(305, 69);
            this.dateTimePickerAkhir.Name = "dateTimePickerAkhir";
            this.dateTimePickerAkhir.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerAkhir.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(264, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "s/d";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Pilih Periode";
            // 
            // dateTimePickerAwal
            // 
            this.dateTimePickerAwal.Location = new System.Drawing.Point(45, 70);
            this.dateTimePickerAwal.Name = "dateTimePickerAwal";
            this.dateTimePickerAwal.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerAwal.TabIndex = 9;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id Transaksi";
            this.Id.Name = "Id";
            // 
            // Tanggal
            // 
            this.Tanggal.HeaderText = "Tanggal Order";
            this.Tanggal.Name = "Tanggal";
            // 
            // Biaya
            // 
            this.Biaya.HeaderText = "Biaya Transaksi";
            this.Biaya.Name = "Biaya";
            // 
            // driver
            // 
            this.driver.HeaderText = "Nama Driver";
            this.driver.Name = "driver";
            // 
            // Tip
            // 
            this.Tip.HeaderText = "Honor Driver";
            this.Tip.Name = "Tip";
            // 
            // Berat
            // 
            this.Berat.HeaderText = "Berat Paket";
            this.Berat.Name = "Berat";
            // 
            // Detail
            // 
            this.Detail.HeaderText = "Cek Detail";
            this.Detail.Name = "Detail";
            this.Detail.Text = "Cek";
            // 
            // FormHistorySend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewDataRiwayat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.dateTimePickerAkhir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePickerAwal);
            this.Name = "FormHistorySend";
            this.Text = "FormHistorySend";
            this.Load += new System.EventHandler(this.FormHistorySend_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDataRiwayat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDataRiwayat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.DateTimePicker dateTimePickerAkhir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerAwal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tanggal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Biaya;
        private System.Windows.Forms.DataGridViewTextBoxColumn driver;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tip;
        private System.Windows.Forms.DataGridViewTextBoxColumn Berat;
        private System.Windows.Forms.DataGridViewButtonColumn Detail;
    }
}