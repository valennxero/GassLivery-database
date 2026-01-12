namespace GassLivery_Kelompok7
{
    partial class FormCancel
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
            this.buttonCancel = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBoxAlasan = new System.Windows.Forms.TextBox();
            this.comboBoxAlasan = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Berikan Alasan Anda Membatalkan :(";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(191, 205);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(124, 23);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Cancel Order";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(30, 205);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Lanjut Pesan";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBoxAlasan
            // 
            this.textBoxAlasan.Location = new System.Drawing.Point(69, 137);
            this.textBoxAlasan.Name = "textBoxAlasan";
            this.textBoxAlasan.Size = new System.Drawing.Size(246, 20);
            this.textBoxAlasan.TabIndex = 3;
            this.textBoxAlasan.Visible = false;
            // 
            // comboBoxAlasan
            // 
            this.comboBoxAlasan.FormattingEnabled = true;
            this.comboBoxAlasan.Items.AddRange(new object[] {
            "Pengemudi Terlalu Lama",
            "Mau Mengubah Tujuan",
            "Pengemudi Galak",
            "Berubah Pikiran",
            "Lainnya"});
            this.comboBoxAlasan.Location = new System.Drawing.Point(88, 89);
            this.comboBoxAlasan.Name = "comboBoxAlasan";
            this.comboBoxAlasan.Size = new System.Drawing.Size(186, 21);
            this.comboBoxAlasan.TabIndex = 4;
            this.comboBoxAlasan.SelectedIndexChanged += new System.EventHandler(this.comboBoxAlasan_SelectedIndexChanged);
            // 
            // FormCancel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 240);
            this.Controls.Add(this.comboBoxAlasan);
            this.Controls.Add(this.textBoxAlasan);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.label1);
            this.Name = "FormCancel";
            this.Text = "FormCancel";
            this.Load += new System.EventHandler(this.FormCancel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBoxAlasan;
        private System.Windows.Forms.ComboBox comboBoxAlasan;
    }
}