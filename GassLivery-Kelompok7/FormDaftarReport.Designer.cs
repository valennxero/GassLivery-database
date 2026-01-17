namespace GassLivery_Kelompok7
{
    partial class FormDaftarReport
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
            this.buttonSearch = new System.Windows.Forms.Button();
            this.dateTimePickerAkhir = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerAwal = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewReport = new System.Windows.Forms.DataGridView();
            this.IdReport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdTransaksi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tanggal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdKonsumen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamaKonsumen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CekNota = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Konfirmasi = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReport)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Daftar Report dari Konsumen";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(536, 62);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 11;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // dateTimePickerAkhir
            // 
            this.dateTimePickerAkhir.Location = new System.Drawing.Point(296, 62);
            this.dateTimePickerAkhir.Name = "dateTimePickerAkhir";
            this.dateTimePickerAkhir.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerAkhir.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(255, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "s/d";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Pilih Periode";
            // 
            // dateTimePickerAwal
            // 
            this.dateTimePickerAwal.Location = new System.Drawing.Point(36, 63);
            this.dateTimePickerAwal.Name = "dateTimePickerAwal";
            this.dateTimePickerAwal.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerAwal.TabIndex = 7;
            // 
            // dataGridViewReport
            // 
            this.dataGridViewReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdReport,
            this.IdTransaksi,
            this.Tanggal,
            this.IdKonsumen,
            this.NamaKonsumen,
            this.Status,
            this.CekNota,
            this.Konfirmasi});
            this.dataGridViewReport.Location = new System.Drawing.Point(12, 141);
            this.dataGridViewReport.Name = "dataGridViewReport";
            this.dataGridViewReport.Size = new System.Drawing.Size(856, 316);
            this.dataGridViewReport.TabIndex = 12;
            this.dataGridViewReport.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewReport_CellContentClick);
            // 
            // IdReport
            // 
            this.IdReport.HeaderText = "Id Report";
            this.IdReport.Name = "IdReport";
            // 
            // IdTransaksi
            // 
            this.IdTransaksi.HeaderText = "Id Transaksi";
            this.IdTransaksi.Name = "IdTransaksi";
            // 
            // Tanggal
            // 
            this.Tanggal.HeaderText = "Tanggal Order";
            this.Tanggal.Name = "Tanggal";
            // 
            // IdKonsumen
            // 
            this.IdKonsumen.HeaderText = "Id Konsumen";
            this.IdKonsumen.Name = "IdKonsumen";
            // 
            // NamaKonsumen
            // 
            this.NamaKonsumen.HeaderText = "Nama Konsumen";
            this.NamaKonsumen.Name = "NamaKonsumen";
            // 
            // Status
            // 
            this.Status.HeaderText = "Status Report";
            this.Status.Name = "Status";
            // 
            // CekNota
            // 
            this.CekNota.HeaderText = "Cek Nota";
            this.CekNota.Name = "CekNota";
            this.CekNota.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CekNota.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Konfirmasi
            // 
            this.Konfirmasi.HeaderText = "Konfirmasi Report";
            this.Konfirmasi.Name = "Konfirmasi";
            this.Konfirmasi.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Konfirmasi.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // FormDaftarReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 450);
            this.Controls.Add(this.dataGridViewReport);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.dateTimePickerAkhir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePickerAwal);
            this.Controls.Add(this.label1);
            this.Name = "FormDaftarReport";
            this.Text = "FormDaftarReport";
            this.Load += new System.EventHandler(this.FormDaftarReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.DateTimePicker dateTimePickerAkhir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerAwal;
        private System.Windows.Forms.DataGridView dataGridViewReport;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdReport;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdTransaksi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tanggal;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdKonsumen;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamaKonsumen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewButtonColumn CekNota;
        private System.Windows.Forms.DataGridViewButtonColumn Konfirmasi;
    }
}