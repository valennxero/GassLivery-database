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
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
        }
        public Admin adminLogin;
        private void FormAdmin_Load(object sender, EventArgs e)
        {

        }

        private void cekLaporanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDaftarReport formDaftarReport = new FormDaftarReport();
            formDaftarReport.adminLogin = this.adminLogin;
            formDaftarReport.ShowDialog();
        }

        private void daftarMotorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDaftarMotor formDaftarMotor = new FormDaftarMotor();
            formDaftarMotor.ShowDialog();
        }
    }
}
