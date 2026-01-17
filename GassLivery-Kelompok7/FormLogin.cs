using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using backend_lib;

namespace GassLivery_Kelompok7
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string uid = textBoxUsername.Text;
            string pwd = textBoxPassword.Text;
            if (comboBoxLogin.Text == "Konsumen")
            {

                FormUtama frm = new FormUtama();
                frm.userLogin = User.CekLogin(uid, pwd);
                if (frm.userLogin is null)
                {
                    MessageBox.Show("Username atau password salah");
                }
                else
                {
                    frm.Owner = this;
                    frm.ShowDialog();
                    this.Close();
                }
            }
            else if(comboBoxLogin.Text == "Driver")
            {
                FormDriver frm = new FormDriver();

                frm.driverLogin = Driver.CekLogin(uid, pwd);
                if (frm.driverLogin is null)
                {
                    MessageBox.Show("Username atau password salah");
                }
                else
                {
                    frm.Owner = this;
                    frm.ShowDialog();
                    this.Close();
                }
            }
            else if (comboBoxLogin.Text == "Admin")
            {
                FormAdmin frm = new FormAdmin();

                frm.adminLogin = Admin.CekLogin(uid, pwd);
                if (frm.adminLogin is null)
                {
                    MessageBox.Show("Username atau password salah");
                }
                else
                {
                    frm.Owner = this;
                    frm.ShowDialog();
                    this.Close();
                }
            }
        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            FormSignUp frm = new FormSignUp();
            frm.Owner = this;
            frm.ShowDialog();

        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
