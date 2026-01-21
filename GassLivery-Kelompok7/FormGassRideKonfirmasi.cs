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
    public partial class FormGassRideKonfirmasi : Form
    {
        OrderRide pesanan;
        OrderGassSend pesananSend;
        public FormGassRideKonfirmasi(OrderRide pPesanan, OrderGassSend sPesanan)
        {
            InitializeComponent();
            pesanan = pPesanan;
            pesananSend = sPesanan;
        }

        
        private void FormGassRideKonfirmasi_Load(object sender, EventArgs e)
        {
            //ambil data motor dari driver
            if (pesanan != null)
            {
                labelNamaDriver.Text = pesanan.Driver.Nama;
                labelMotor.Text = pesanan.Driver.Motor.Nama;
                labelRating.Text = pesanan.Driver.Rating.ToString();
                labelPlat.Text = pesanan.Driver.Motor.PlatNomor;
            }
            else if (pesananSend !=null)
            {
                labelNamaDriver.Text = pesananSend.Driver.Nama;
                labelMotor.Text = pesananSend.Driver.Motor.Nama;
                labelRating.Text = pesananSend.Driver.Rating.ToString();
                labelPlat.Text = pesananSend.Driver.Motor.PlatNomor;
                buttonCancelOrder.Visible = false;
            }          
        }

        private void buttonCancelOrder_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Cancel cancelPesanan = new Cancel(pesanan.Konsumen, pesanan, "");
            FormCancel frm = new FormCancel(cancelPesanan);
            frm.Owner = this;
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void buttonSelesaikanPesanan_Click(object sender, EventArgs e)
        {
            if (pesanan != null)
            {
                int poin = (int)((pesanan.TotalTransaksi / 1000) * 10);
                Gassmon.TambahPoin(poin, pesanan.Konsumen);

                this.Visible = false;
                OrderRide.UpdateSelesai(pesanan);
                MessageBox.Show("Pesanan telah selesai");
                Driver.UangMasuk(pesanan.Tip, pesanan.Driver);
                FormRatingDriver frm = new FormRatingDriver(pesanan, null, null);
                frm.Owner = this;
                frm.ShowDialog();
            }
            else if (pesananSend != null)
            {
                int poin = (int)((pesananSend.TotalHarga / 1000) * 10);
                Gassmon.TambahPoin(poin, pesananSend.Konsumen);

                this.Visible = false;
                OrderGassSend.UpdateSelesai(pesananSend);
                MessageBox.Show("Pesanan telah selesai");
                Driver.UangMasuk(pesananSend.Tip, pesananSend.Driver);
                FormRatingDriver frm = new FormRatingDriver(null, null, pesananSend);
                frm.Owner = this;
                frm.ShowDialog();
            }
           

            
        }
    }
}
