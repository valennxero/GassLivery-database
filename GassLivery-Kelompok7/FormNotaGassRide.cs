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
        OrderGassSend pesananSend;
        public FormNotaGassRide(OrderRide pPesanan, OrderGassSend sPesanan)
        {
            InitializeComponent();
            pesanan = pPesanan;
            pesananSend = sPesanan;

        }

        private void FormNotaGassRide_Load(object sender, EventArgs e)
        {
            if (pesanan != null)
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
            else if (pesananSend != null)
            {
                labelIdOrder.Text = pesananSend.IdOrderGassSend.ToString();
                labelKosnumen.Text = pesananSend.Konsumen.Nama;
                labelTanggal.Text = pesananSend.TanggalOrder.ToString("dd/MM/yyyy HH:mm");
                labelNamaDriver.Text = pesananSend.Driver.Nama;
                labelPlat.Text = pesananSend.Driver.Motor.PlatNomor;
                labelLokasiAwal.Text = pesananSend.Jarak.LokasiAwal.Nama;
                labelLokasiTujuan.Text = pesananSend.Jarak.LokasiAkhir.Nama;
                labelBiaya.Text = pesananSend.TotalHarga.ToString();
            }
           
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
