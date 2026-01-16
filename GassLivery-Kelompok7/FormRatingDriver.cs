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
    public partial class FormRatingDriver : Form
    {
        OrderRide pesanan;
        OrderFood pesananFood;
        public FormRatingDriver(OrderRide pPesanan, OrderFood pPesananFood)
        {
            InitializeComponent();
            pesanan = pPesanan;
            pesananFood = pPesananFood;
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            int nilai = 5;
            if (radioButton1.Checked)
            {
                nilai = 1;
            }
            else if (radioButton2.Checked)
            {
                nilai = 2;
            }
            else if (radioButton3.Checked)
            {
                nilai = 3;
            }
            else if (radioButton4.Checked)
            {
                nilai = 4;
            }
            else
            {
                nilai = 5;
            }
            if (pesanan != null)
            {
                RatingDriver.RateDriver(pesanan.Konsumen, pesanan.Driver, nilai);
                RatingDriver.UpdateTotalRatingDriver(pesanan.Driver);
                MessageBox.Show("Terimakasih atas rating anda");
                this.Close();
                this.Owner.Close();
                FormNotaGassRide formNota = new FormNotaGassRide(pesanan);
                formNota.Owner = this;
                formNota.ShowDialog();
            }
            else if (pesananFood != null)
            {
                RatingDriver.RateDriver(pesananFood.Konsumen, pesananFood.Driver, nilai);
                RatingDriver.UpdateTotalRatingDriver(pesananFood.Driver);
                MessageBox.Show("Terimakasih atas rating anda");
                this.Close();
                this.Owner.Close();
                FormRatingTenant formNota = new FormRatingTenant(pesananFood);
                formNota.Owner = this;
                formNota.ShowDialog();
            }
        }

        private void FormRatingDriver_Load(object sender, EventArgs e)
        {
            if(pesanan != null)
                labelNamaDriver.Text = pesanan.Driver.Nama;
            if (pesananFood != null)
            {
                labelNamaDriver.Text = pesananFood.Driver.Nama;
                buttonReport.Visible = false;
            }

        }

        private void buttonReport_Click(object sender, EventArgs e)
        {
            
            DialogResult result = MessageBox.Show("Anda yakin ingin melaporkan driver ini?","Report Driver", MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes)
            {
                Report.LaporkanDriver(pesanan);
                MessageBox.Show("Driver telah dilaporkan. Terimakasih atas laporannya.");
                this.Close();
                this.Owner.Close();
                FormNotaGassRide formNota = new FormNotaGassRide(pesanan);
                formNota.Owner = this;
                formNota.ShowDialog();
            }
        }
    }
}
