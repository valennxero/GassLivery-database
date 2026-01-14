namespace GassLivery_Kelompok7
{
    partial class FormHistoryTopUp
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDataRiwayat)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDataRiwayat
            // 
            this.dataGridViewDataRiwayat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDataRiwayat.Location = new System.Drawing.Point(-4, 90);
            this.dataGridViewDataRiwayat.Name = "dataGridViewDataRiwayat";
            this.dataGridViewDataRiwayat.Size = new System.Drawing.Size(354, 363);
            this.dataGridViewDataRiwayat.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Riwayat Top Up";
            // 
            // FormHistoryTopUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewDataRiwayat);
            this.Name = "FormHistoryTopUp";
            this.Text = "FormHistoryTopUp";
            this.Load += new System.EventHandler(this.FormHistoryTopUp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDataRiwayat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDataRiwayat;
        private System.Windows.Forms.Label label1;
    }
}