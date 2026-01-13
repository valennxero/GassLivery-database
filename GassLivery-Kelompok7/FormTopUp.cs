using backend_lib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GassLivery_Kelompok7
{
    public partial class FormTopUp : Form
    {
        User userLogin;
        public FormTopUp(User pUser)
        {
            InitializeComponent();
            userLogin = pUser;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormTopUp_Load(object sender, EventArgs e)
        {
            labelSaldo.Text = userLogin.IdGassmon.Saldo.ToString();
        }

        private void buttonTopUp_Click(object sender, EventArgs e)
        {
            int value = (int)numericUpDownNominal.Value;
            TopUp.IsiSaldo(userLogin, value);
            MessageBox.Show($"Top Up Sebesar Rp {value} Berhasil!");
            this.Close();
        }
    }
}
