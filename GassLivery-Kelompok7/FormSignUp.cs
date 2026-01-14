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
    public partial class FormSignUp : Form
    {
        public FormSignUp()
        {
            InitializeComponent();
        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            try
            {
                string nameUser = textBoxNama.Text;
                string genderUser = comboBoxGender.Text;
                string username = textBoxUsername.Text;
                string password = textBoxPassword.Text;
                string noHPUser = textBoxNoHP.Text;

                User.CreateUser(username, password, nameUser, genderUser, noHPUser);
                MessageBox.Show("Akun berhasil dibuat");
                this.Close();
            }catch(Exception ex)
            {
                MessageBox.Show("Akun gagal dibuat. " + ex.Message);
            }
        }
    }
}
