namespace GassLivery_Kelompok7
{
    partial class FormUtama
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
            this.buttonRide = new System.Windows.Forms.Button();
            this.buttonGassKan = new System.Windows.Forms.Button();
            this.labelHomeMenu = new System.Windows.Forms.Label();
            this.buttonGassSend = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelSaldo = new System.Windows.Forms.Label();
            this.labelPoin = new System.Windows.Forms.Label();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonRide
            // 
            this.buttonRide.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRide.Location = new System.Drawing.Point(12, 169);
            this.buttonRide.Name = "buttonRide";
            this.buttonRide.Size = new System.Drawing.Size(107, 65);
            this.buttonRide.TabIndex = 0;
            this.buttonRide.Text = "Gass-Ride";
            this.buttonRide.UseVisualStyleBackColor = true;
            this.buttonRide.Click += new System.EventHandler(this.buttonRide_Click);
            // 
            // buttonGassKan
            // 
            this.buttonGassKan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGassKan.Location = new System.Drawing.Point(125, 169);
            this.buttonGassKan.Name = "buttonGassKan";
            this.buttonGassKan.Size = new System.Drawing.Size(107, 65);
            this.buttonGassKan.TabIndex = 1;
            this.buttonGassKan.Text = "Gass-Kan";
            this.buttonGassKan.UseVisualStyleBackColor = true;
            // 
            // labelHomeMenu
            // 
            this.labelHomeMenu.BackColor = System.Drawing.Color.MediumBlue;
            this.labelHomeMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHomeMenu.ForeColor = System.Drawing.SystemColors.Control;
            this.labelHomeMenu.Location = new System.Drawing.Point(1, 15);
            this.labelHomeMenu.Name = "labelHomeMenu";
            this.labelHomeMenu.Size = new System.Drawing.Size(356, 35);
            this.labelHomeMenu.TabIndex = 6;
            this.labelHomeMenu.Text = "Home Menu";
            this.labelHomeMenu.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelHomeMenu.UseCompatibleTextRendering = true;
            // 
            // buttonGassSend
            // 
            this.buttonGassSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGassSend.Location = new System.Drawing.Point(238, 169);
            this.buttonGassSend.Name = "buttonGassSend";
            this.buttonGassSend.Size = new System.Drawing.Size(107, 63);
            this.buttonGassSend.TabIndex = 8;
            this.buttonGassSend.Text = "Gass-Send";
            this.buttonGassSend.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Saldo :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(192, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Poin :";
            // 
            // labelSaldo
            // 
            this.labelSaldo.AutoSize = true;
            this.labelSaldo.Location = new System.Drawing.Point(80, 68);
            this.labelSaldo.Name = "labelSaldo";
            this.labelSaldo.Size = new System.Drawing.Size(13, 13);
            this.labelSaldo.TabIndex = 12;
            this.labelSaldo.Text = "0";
            // 
            // labelPoin
            // 
            this.labelPoin.AutoSize = true;
            this.labelPoin.Location = new System.Drawing.Point(247, 68);
            this.labelPoin.Name = "labelPoin";
            this.labelPoin.Size = new System.Drawing.Size(13, 13);
            this.labelPoin.TabIndex = 13;
            this.labelPoin.Text = "0";
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(18, 101);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(75, 23);
            this.buttonRefresh.TabIndex = 14;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // FormUtama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 365);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.labelPoin);
            this.Controls.Add(this.labelSaldo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonGassSend);
            this.Controls.Add(this.labelHomeMenu);
            this.Controls.Add(this.buttonGassKan);
            this.Controls.Add(this.buttonRide);
            this.IsMdiContainer = true;
            this.Name = "FormUtama";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormUtama_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRide;
        private System.Windows.Forms.Button buttonGassKan;
        private System.Windows.Forms.Label labelHomeMenu;
        private System.Windows.Forms.Button buttonGassSend;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelSaldo;
        private System.Windows.Forms.Label labelPoin;
        private System.Windows.Forms.Button buttonRefresh;
    }
}

