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
    public partial class FormGassKanKonfirmasi : Form
    {
        OrderFood pesanan;
        public FormGassKanKonfirmasi(OrderFood pPesanan)
        {
            InitializeComponent();
            pesanan = pPesanan;
        }

        private void FormGassKanKonfirmasi_Load(object sender, EventArgs e)
        {
            labelNamaDriver.Text = pesanan.Driver.Nama;
            labelRating.Text = pesanan.Driver.Rating.ToString();
            labelTenan.Text = pesanan.Tenant.NamaTenant;
            labelHarga.Text = pesanan.TotalBiaya.ToString();
            labelRatingTenan.Text = pesanan.Tenant.RatingTenant.ToString();
        }

        private void buttonSelesaikanPesanan_Click(object sender, EventArgs e)
        {
            //tambahkan poin ke gassmon user
            int poin = (int)((pesanan.TotalBiaya / 1000) * 10);
            Gassmon.TambahPoin(poin, pesanan.Konsumen);

            this.Visible = false;
            OrderFood.UpdateSelesai(pesanan);
            MessageBox.Show("Pesanan telah selesai");
            Driver.UangMasuk(pesanan.Tip, pesanan.Driver);
            FormRatingDriver frm = new FormRatingDriver(null, pesanan,null);
            frm.Owner = this;
            this.Close();
            frm.ShowDialog();
        }
    }
}
