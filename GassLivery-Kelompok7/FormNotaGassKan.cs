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
    public partial class FormNotaGassKan : Form
    {
        OrderFood pesanan;
        public FormNotaGassKan(OrderFood pPesanan)
        {
            InitializeComponent();
            pesanan = pPesanan;
        }

        private void FormNotaGassKan_Load(object sender, EventArgs e)
        {
            labelIdOrder.Text = pesanan.Id.ToString();
            labelTanggal.Text = pesanan.TanggalOrder.ToString("dd/MM/yyyy HH:mm");
            labelTenant.Text = pesanan.Tenant.NamaTenant;
            labelLokasiTenant.Text = pesanan.Tenant.LokasiTenant.Nama;
            labelLokasiTujuan.Text = pesanan.Jarak.LokasiAkhir.Nama;
            labelOngkir.Text = $"Rp. {pesanan.Ongkir}";

            for (int i = 0; i < pesanan.ListDetail.Count; i++)
            {
                string namaMenu = pesanan.ListDetail[i].Menu.NamaMenu;
                int hargaMenu = pesanan.ListDetail[i].Harga;
                int jumlah = pesanan.ListDetail[i].Jumlah;
                int subtotal = hargaMenu * jumlah;
                dataGridViewKeranjang.Rows.Add(namaMenu, hargaMenu, jumlah, subtotal);
            }
            labelBiaya.Text = $"Rp. {pesanan.TotalBiaya}";
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
