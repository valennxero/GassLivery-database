namespace GassLivery_Kelompok7
{
    partial class FormTenant
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
            this.buttonSearch = new System.Windows.Forms.Button();
            this.dateTimePickerAkhir = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerAwal = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewLaporan = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLaporan)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(512, 88);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 17;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // dateTimePickerAkhir
            // 
            this.dateTimePickerAkhir.Location = new System.Drawing.Point(272, 88);
            this.dateTimePickerAkhir.Name = "dateTimePickerAkhir";
            this.dateTimePickerAkhir.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerAkhir.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(231, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "s/d";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Pilih Periode";
            // 
            // dateTimePickerAwal
            // 
            this.dateTimePickerAwal.Location = new System.Drawing.Point(12, 89);
            this.dateTimePickerAwal.Name = "dateTimePickerAwal";
            this.dateTimePickerAwal.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerAwal.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Laporan Penjualan Menu";
            // 
            // dataGridViewLaporan
            // 
            this.dataGridViewLaporan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLaporan.Location = new System.Drawing.Point(0, 143);
            this.dataGridViewLaporan.Name = "dataGridViewLaporan";
            this.dataGridViewLaporan.Size = new System.Drawing.Size(609, 273);
            this.dataGridViewLaporan.TabIndex = 18;
            // 
            // FormTenant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 450);
            this.Controls.Add(this.dataGridViewLaporan);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.dateTimePickerAkhir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePickerAwal);
            this.Controls.Add(this.label1);
            this.Name = "FormTenant";
            this.Text = "FormTenant";
            this.Load += new System.EventHandler(this.FormTenant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLaporan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.DateTimePicker dateTimePickerAkhir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerAwal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewLaporan;
    }
}