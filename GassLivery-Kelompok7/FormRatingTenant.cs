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
    public partial class FormRatingTenant : Form
    {
        OrderFood pesanan;
        public FormRatingTenant(OrderFood pPesanan)
        {
            InitializeComponent();
            pesanan = pPesanan;
        }

        private void FormRatingTenant_Load(object sender, EventArgs e)
        {
            labelNamaTenan.Text = pesanan.Tenant.NamaTenant;
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

            RatingTenant.RateTenant(pesanan.Konsumen, pesanan.Tenant, nilai);
            RatingTenant.UpdateTotalRatingTenan(pesanan.Tenant);
            MessageBox.Show("Terimakasih atas rating anda");
            this.Close();
            this.Owner.Close();
        }
    }
}
