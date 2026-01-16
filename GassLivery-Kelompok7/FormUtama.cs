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
    public partial class FormUtama : Form
    {
        public FormUtama()
        {
            InitializeComponent();
        }
        public User userLogin;

        private void FormUtama_Load(object sender, EventArgs e)
        {
            try
            {
                Koneksi k = new Koneksi();
                MessageBox.Show("Koneksi berhasil");
                //FormLogin frm = new FormLogin();
                //frm.Owner = this;
                //frm.ShowDialog();
                labelSaldo.Text = userLogin.IdGassmon.Saldo.ToString();
                labelPoin.Text = userLogin.IdGassmon.Poin.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Koneksi gagal : " + ex.Message);
            }
        }

        public void HideButton()
        {
            buttonGassKan.Visible = false;
            buttonGassSend.Visible = false;
            buttonRide.Visible = false;
            labelHomeMenu.Visible = false;
        }

        private void buttonRide_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["FormGassRide1"];
            if (form == null)
            {
                FormGassRide1 frm = new FormGassRide1();
                frm.MdiParent = this;
               
                frm.Show();
            }
            else
            {
                form.Show();
                form.BringToFront();
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            userLogin = User.BacaData(userLogin.Username);
            labelSaldo.Text = userLogin.IdGassmon.Saldo.ToString();
            labelPoin.Text = userLogin.IdGassmon.Poin.ToString();
        }

        private void topUpSaldoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["FormTopUp"];
            if (form == null)
            {
                FormTopUp frm = new FormTopUp(userLogin);
                frm.MdiParent = this;

                frm.Show();
            }
            else
            {
                form.Show();
                form.BringToFront();
            }
        }

        private void topUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHistoryTopUp frm = new FormHistoryTopUp(userLogin);
            frm.MdiParent = this;
            frm.Show();
        }

        private void gassRideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHistoryRide frm = new FormHistoryRide(userLogin);
            frm.MdiParent = this;
            frm.Show();
        }

        private void buttonGassKan_Click(object sender, EventArgs e)
        {
            FormGassKan frm = new FormGassKan();
            frm.MdiParent = this;
            frm.Show();
        }

        private void gassKanToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
