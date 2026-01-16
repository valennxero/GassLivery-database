namespace GassLivery_Kelompok7
{
    partial class FormPilihMenu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelNamaTenant = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridViewMenu = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelHargaTotal = new System.Windows.Forms.Label();
            this.buttonKonfirmasi = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Nama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Harga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Halal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pilih = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Hapus = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewKeranjang = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Jumlah = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HargaTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKeranjang)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.labelNamaTenant);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Location = new System.Drawing.Point(8, 3);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(574, 86);
            this.panel1.TabIndex = 3;
            // 
            // labelNamaTenant
            // 
            this.labelNamaTenant.AutoSize = true;
            this.labelNamaTenant.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNamaTenant.Location = new System.Drawing.Point(164, 19);
            this.labelNamaTenant.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNamaTenant.Name = "labelNamaTenant";
            this.labelNamaTenant.Size = new System.Drawing.Size(190, 31);
            this.labelNamaTenant.TabIndex = 7;
            this.labelNamaTenant.Text = "(nama_tenant)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(18, 19);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 31);
            this.label10.TabIndex = 6;
            this.label10.Text = "Tenant :";
            // 
            // dataGridViewMenu
            // 
            this.dataGridViewMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMenu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nama,
            this.Harga,
            this.Halal,
            this.Pilih,
            this.Hapus});
            this.dataGridViewMenu.Location = new System.Drawing.Point(8, 161);
            this.dataGridViewMenu.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewMenu.Name = "dataGridViewMenu";
            this.dataGridViewMenu.RowHeadersWidth = 51;
            this.dataGridViewMenu.RowTemplate.Height = 24;
            this.dataGridViewMenu.Size = new System.Drawing.Size(561, 148);
            this.dataGridViewMenu.TabIndex = 5;
            this.dataGridViewMenu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMenu_CellContentClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(198, 94);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(66, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 547);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Harga Total : Rp ";
            // 
            // labelHargaTotal
            // 
            this.labelHargaTotal.AutoSize = true;
            this.labelHargaTotal.Location = new System.Drawing.Point(127, 547);
            this.labelHargaTotal.Name = "labelHargaTotal";
            this.labelHargaTotal.Size = new System.Drawing.Size(25, 13);
            this.labelHargaTotal.TabIndex = 7;
            this.labelHargaTotal.Text = "000";
            // 
            // buttonKonfirmasi
            // 
            this.buttonKonfirmasi.Location = new System.Drawing.Point(340, 547);
            this.buttonKonfirmasi.Name = "buttonKonfirmasi";
            this.buttonKonfirmasi.Size = new System.Drawing.Size(121, 23);
            this.buttonKonfirmasi.TabIndex = 8;
            this.buttonKonfirmasi.Text = "Konfirmasi";
            this.buttonKonfirmasi.UseVisualStyleBackColor = true;
            this.buttonKonfirmasi.Click += new System.EventHandler(this.buttonKonfirmasi_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 327);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Keranjang :";
            // 
            // Nama
            // 
            this.Nama.HeaderText = "Nama Menu";
            this.Nama.Name = "Nama";
            // 
            // Harga
            // 
            this.Harga.HeaderText = "Harga Satuan";
            this.Harga.Name = "Harga";
            // 
            // Halal
            // 
            this.Halal.HeaderText = "Halal";
            this.Halal.Name = "Halal";
            // 
            // Pilih
            // 
            this.Pilih.HeaderText = "+";
            this.Pilih.Name = "Pilih";
            // 
            // Hapus
            // 
            this.Hapus.HeaderText = "-";
            this.Hapus.Name = "Hapus";
            this.Hapus.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Hapus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewKeranjang
            // 
            this.dataGridViewKeranjang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKeranjang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.Jumlah,
            this.HargaTotal});
            this.dataGridViewKeranjang.Location = new System.Drawing.Point(43, 362);
            this.dataGridViewKeranjang.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewKeranjang.Name = "dataGridViewKeranjang";
            this.dataGridViewKeranjang.RowHeadersWidth = 51;
            this.dataGridViewKeranjang.RowTemplate.Height = 24;
            this.dataGridViewKeranjang.Size = new System.Drawing.Size(455, 157);
            this.dataGridViewKeranjang.TabIndex = 11;
            this.dataGridViewKeranjang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewKeranjang_CellContentClick);
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
            // FormPilihMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 613);
            this.Controls.Add(this.dataGridViewKeranjang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonKonfirmasi);
            this.Controls.Add(this.labelHargaTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridViewMenu);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormPilihMenu";
            this.Text = "FormPilihMenu";
            this.Load += new System.EventHandler(this.FormPilihMenu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKeranjang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dataGridViewMenu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelNamaTenant;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelHargaTotal;
        private System.Windows.Forms.Button buttonKonfirmasi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nama;
        private System.Windows.Forms.DataGridViewTextBoxColumn Harga;
        private System.Windows.Forms.DataGridViewTextBoxColumn Halal;
        private System.Windows.Forms.DataGridViewButtonColumn Pilih;
        private System.Windows.Forms.DataGridViewButtonColumn Hapus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewKeranjang;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Jumlah;
        private System.Windows.Forms.DataGridViewTextBoxColumn HargaTotal;
    }
}