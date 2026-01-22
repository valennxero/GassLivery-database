namespace GassLivery_Kelompok7
{
    partial class FormTopUp
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
            this.numericUpDownNominal = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonTopUp = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.labelSaldo = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNominal)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 97);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Masukkan Nominal Top Up";
            // 
            // numericUpDownNominal
            // 
            this.numericUpDownNominal.Location = new System.Drawing.Point(101, 148);
            this.numericUpDownNominal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericUpDownNominal.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.numericUpDownNominal.Name = "numericUpDownNominal";
            this.numericUpDownNominal.Size = new System.Drawing.Size(179, 22);
            this.numericUpDownNominal.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 151);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Rp";
            // 
            // buttonTopUp
            // 
            this.buttonTopUp.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonTopUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTopUp.Location = new System.Drawing.Point(101, 211);
            this.buttonTopUp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonTopUp.Name = "buttonTopUp";
            this.buttonTopUp.Size = new System.Drawing.Size(179, 83);
            this.buttonTopUp.TabIndex = 3;
            this.buttonTopUp.Text = "Top Up";
            this.buttonTopUp.UseVisualStyleBackColor = false;
            this.buttonTopUp.Click += new System.EventHandler(this.buttonTopUp_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 43);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Saldo :";
            // 
            // labelSaldo
            // 
            this.labelSaldo.AutoSize = true;
            this.labelSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSaldo.Location = new System.Drawing.Point(97, 43);
            this.labelSaldo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSaldo.Name = "labelSaldo";
            this.labelSaldo.Size = new System.Drawing.Size(36, 20);
            this.labelSaldo.TabIndex = 5;
            this.labelSaldo.Text = "000";
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.Red;
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Location = new System.Drawing.Point(101, 322);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(179, 83);
            this.buttonCancel.TabIndex = 6;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // FormTopUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 418);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.labelSaldo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonTopUp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDownNominal);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormTopUp";
            this.Text = "FormTopUp";
            this.Load += new System.EventHandler(this.FormTopUp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNominal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownNominal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonTopUp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelSaldo;
        private System.Windows.Forms.Button buttonCancel;
    }
}