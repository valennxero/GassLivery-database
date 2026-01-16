namespace GassLivery_Kelompok7
{
    partial class FormHistoryRide
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
            this.dataGridViewDataRiwayat = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tanggal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Biaya = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.driver = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detail = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDataRiwayat)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "History Gass Ride";
            // 
            // dataGridViewDataRiwayat
            // 
            this.dataGridViewDataRiwayat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDataRiwayat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Tanggal,
            this.Biaya,
            this.driver,
            this.Detail});
            this.dataGridViewDataRiwayat.Location = new System.Drawing.Point(12, 134);
            this.dataGridViewDataRiwayat.Name = "dataGridViewDataRiwayat";
            this.dataGridViewDataRiwayat.Size = new System.Drawing.Size(564, 261);
            this.dataGridViewDataRiwayat.TabIndex = 1;
            this.dataGridViewDataRiwayat.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDataRiwayat_CellContentClick);
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
            // Detail
            // 
            this.Detail.HeaderText = "Cek Detail";
            this.Detail.Name = "Detail";
            this.Detail.Text = "Cek";
            // 
            // FormHistoryRide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 450);
            this.Controls.Add(this.dataGridViewDataRiwayat);
            this.Controls.Add(this.label1);
            this.Name = "FormHistoryRide";
            this.Text = "FormHistoryRide";
            this.Load += new System.EventHandler(this.FormHistoryRide_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDataRiwayat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewDataRiwayat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tanggal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Biaya;
        private System.Windows.Forms.DataGridViewTextBoxColumn driver;
        private System.Windows.Forms.DataGridViewButtonColumn Detail;
    }
}