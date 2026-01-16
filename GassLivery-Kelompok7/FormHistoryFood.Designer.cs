namespace GassLivery_Kelompok7
{
    partial class FormHistoryFood
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
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tanggal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Biaya = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.driver = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tenant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tip = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.Tenant,
            this.Tip,
            this.Detail});
            this.dataGridViewDataRiwayat.Location = new System.Drawing.Point(-1, 145);
            this.dataGridViewDataRiwayat.Name = "dataGridViewDataRiwayat";
            this.dataGridViewDataRiwayat.Size = new System.Drawing.Size(752, 261);
            this.dataGridViewDataRiwayat.TabIndex = 3;
            this.dataGridViewDataRiwayat.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDataRiwayat_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "History Gass Ride";
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
            // Tenant
            // 
            this.Tenant.HeaderText = "Nama Tenant";
            this.Tenant.Name = "Tenant";
            // 
            // Tip
            // 
            this.Tip.HeaderText = "Honor Driver";
            this.Tip.Name = "Tip";
            // 
            // Detail
            // 
            this.Detail.HeaderText = "Cek Detail";
            this.Detail.Name = "Detail";
            this.Detail.Text = "Cek";
            // 
            // FormHistoryFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 450);
            this.Controls.Add(this.dataGridViewDataRiwayat);
            this.Controls.Add(this.label1);
            this.Name = "FormHistoryFood";
            this.Text = "FormHistoryFood";
            this.Load += new System.EventHandler(this.FormHistoryFood_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDataRiwayat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDataRiwayat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tanggal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Biaya;
        private System.Windows.Forms.DataGridViewTextBoxColumn driver;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tenant;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tip;
        private System.Windows.Forms.DataGridViewButtonColumn Detail;
    }
}