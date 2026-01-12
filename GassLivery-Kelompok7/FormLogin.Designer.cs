namespace GassLivery_Kelompok7
{
    partial class FormLogin
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
            this.labelHomeMenu = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonSignUp = new System.Windows.Forms.Button();
            this.comboBoxLogin = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelHomeMenu
            // 
            this.labelHomeMenu.BackColor = System.Drawing.Color.MediumBlue;
            this.labelHomeMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHomeMenu.ForeColor = System.Drawing.SystemColors.Control;
            this.labelHomeMenu.Location = new System.Drawing.Point(2, 9);
            this.labelHomeMenu.Name = "labelHomeMenu";
            this.labelHomeMenu.Size = new System.Drawing.Size(356, 35);
            this.labelHomeMenu.TabIndex = 7;
            this.labelHomeMenu.Text = "Login";
            this.labelHomeMenu.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelHomeMenu.UseCompatibleTextRendering = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Username :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Password :";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(141, 118);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(193, 20);
            this.textBoxUsername.TabIndex = 10;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(141, 170);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(193, 20);
            this.textBoxPassword.TabIndex = 11;
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(96, 241);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(142, 23);
            this.buttonLogin.TabIndex = 12;
            this.buttonLogin.Text = "Sign In";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 291);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Don\'t have Account ? Sign Up here!";
            // 
            // buttonSignUp
            // 
            this.buttonSignUp.Location = new System.Drawing.Point(105, 316);
            this.buttonSignUp.Name = "buttonSignUp";
            this.buttonSignUp.Size = new System.Drawing.Size(133, 23);
            this.buttonSignUp.TabIndex = 14;
            this.buttonSignUp.Text = "Sign Up";
            this.buttonSignUp.UseVisualStyleBackColor = true;
            this.buttonSignUp.Click += new System.EventHandler(this.buttonSignUp_Click);
            // 
            // comboBoxLogin
            // 
            this.comboBoxLogin.FormattingEnabled = true;
            this.comboBoxLogin.Items.AddRange(new object[] {
            "Konsumen",
            "Driver",
            "Admin"});
            this.comboBoxLogin.Location = new System.Drawing.Point(141, 71);
            this.comboBoxLogin.Name = "comboBoxLogin";
            this.comboBoxLogin.Size = new System.Drawing.Size(121, 21);
            this.comboBoxLogin.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Login sebagai";
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxLogin);
            this.Controls.Add(this.buttonSignUp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelHomeMenu);
            this.Name = "FormLogin";
            this.Text = "FormLogin";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHomeMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonSignUp;
        private System.Windows.Forms.ComboBox comboBoxLogin;
        private System.Windows.Forms.Label label4;
    }
}