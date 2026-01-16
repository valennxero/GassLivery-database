namespace GassLivery_Kelompok7
{
    partial class FormHistoryPenarikanDana
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
            this.dataGridViewPenarikan = new System.Windows.Forms.DataGridView();
            this.Tanggal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nominal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPenarikan)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Riwayat Penarikan Dana";
            // 
            // dataGridViewPenarikan
            // 
            this.dataGridViewPenarikan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPenarikan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tanggal,
            this.Nominal});
            this.dataGridViewPenarikan.Location = new System.Drawing.Point(12, 115);
            this.dataGridViewPenarikan.Name = "dataGridViewPenarikan";
            this.dataGridViewPenarikan.Size = new System.Drawing.Size(324, 295);
            this.dataGridViewPenarikan.TabIndex = 1;
            // 
            // Tanggal
            // 
            this.Tanggal.HeaderText = "Tanggal";
            this.Tanggal.Name = "Tanggal";
            // 
            // Nominal
            // 
            this.Nominal.HeaderText = "Nominal Penarikan";
            this.Nominal.Name = "Nominal";
            // 
            // FormHistoryPenarikanDana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 450);
            this.Controls.Add(this.dataGridViewPenarikan);
            this.Controls.Add(this.label1);
            this.Name = "FormHistoryPenarikanDana";
            this.Text = "FormHistoryPenarikanDana";
            this.Load += new System.EventHandler(this.FormHistoryPenarikanDana_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPenarikan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewPenarikan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tanggal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nominal;
    }
}