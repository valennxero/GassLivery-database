namespace GassLivery_Kelompok7
{
    partial class FormDaftarMotor
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
            this.dataGridViewMotor = new System.Windows.Forms.DataGridView();
            this.IdMotor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Owner = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdOwner = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Plat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nonaktif = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMotor)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Daftar Motor Driver";
            // 
            // dataGridViewMotor
            // 
            this.dataGridViewMotor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMotor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdMotor,
            this.Nama,
            this.Owner,
            this.IdOwner,
            this.Usia,
            this.Plat,
            this.Nonaktif});
            this.dataGridViewMotor.Location = new System.Drawing.Point(2, 74);
            this.dataGridViewMotor.Name = "dataGridViewMotor";
            this.dataGridViewMotor.Size = new System.Drawing.Size(739, 347);
            this.dataGridViewMotor.TabIndex = 1;
            this.dataGridViewMotor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMotor_CellContentClick);
            // 
            // IdMotor
            // 
            this.IdMotor.HeaderText = "Id Motor";
            this.IdMotor.Name = "IdMotor";
            // 
            // Nama
            // 
            this.Nama.HeaderText = "Nama";
            this.Nama.Name = "Nama";
            // 
            // Owner
            // 
            this.Owner.HeaderText = "Owner";
            this.Owner.Name = "Owner";
            // 
            // IdOwner
            // 
            this.IdOwner.HeaderText = "Id Owner";
            this.IdOwner.Name = "IdOwner";
            this.IdOwner.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IdOwner.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Usia
            // 
            this.Usia.HeaderText = "Usia Motor";
            this.Usia.Name = "Usia";
            // 
            // Plat
            // 
            this.Plat.HeaderText = "Plat Nomor";
            this.Plat.Name = "Plat";
            // 
            // Nonaktif
            // 
            this.Nonaktif.HeaderText = "Nonaktifkan Driver";
            this.Nonaktif.Name = "Nonaktif";
            // 
            // FormDaftarMotor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 450);
            this.Controls.Add(this.dataGridViewMotor);
            this.Controls.Add(this.label1);
            this.Name = "FormDaftarMotor";
            this.Text = "FormDaftarMotor";
            this.Load += new System.EventHandler(this.FormDaftarMotor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMotor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewMotor;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdMotor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nama;
        private System.Windows.Forms.DataGridViewTextBoxColumn Owner;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdOwner;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Plat;
        private System.Windows.Forms.DataGridViewButtonColumn Nonaktif;
    }
}