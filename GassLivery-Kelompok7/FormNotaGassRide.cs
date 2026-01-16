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
    public partial class FormNotaGassRide : Form
    {
        OrderRide pesanan;
        public FormNotaGassRide(OrderRide pPesanan)
        {
            InitializeComponent();
            pesanan = pPesanan;
        }

        private void FormNotaGassRide_Load(object sender, EventArgs e)
        {
            labelIdOrder.Text = pesanan.Id.ToString();
            labelKosnumen.Text = pesanan.Konsumen.Nama;
            labelTanggal.Text = pesanan.TanggalOrder.ToString("dd/MM/yyyy HH:mm");
            labelNamaDriver.Text = pesanan.Driver.Nama;
            labelPlat.Text = pesanan.Driver.Motor.PlatNomor;
            labelLokasiAwal.Text = pesanan.Jarak.LokasiAwal.Nama;
            labelLokasiTujuan.Text = pesanan.Jarak.LokasiAkhir.Nama;
            labelBiaya.Text = pesanan.TotalTransaksi.ToString();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
