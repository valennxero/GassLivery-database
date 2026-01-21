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
            formDaftarReport.ShowDialog();
        }

        private void daftarMotorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDaftarMotor formDaftarMotor = new FormDaftarMotor();
            formDaftarMotor.ShowDialog();
        }

        private void gassRideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHistoryRide formHistoryRide = new FormHistoryRide(null, null);
            formHistoryRide.ShowDialog();
        }

        private void gassKanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHistoryFood formHistoryFood = new FormHistoryFood(null, null);
            formHistoryFood.ShowDialog();
        }

        private void cancelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDaftarCancel formDaftarCancel = new FormDaftarCancel();
            formDaftarCancel.ShowDialog();
        }

        private void gassSendToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
