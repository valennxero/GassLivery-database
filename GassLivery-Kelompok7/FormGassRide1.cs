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
    public partial class FormGassRide1 : Form
    {
        public FormGassRide1()
        {
            InitializeComponent();
        }
        bool reqWanita;
        bool reqMotorBaru;
        private void FormGassRide1_Load(object sender, EventArgs e)
        {
            List<Lokasi> listLokasi = Lokasi.BacaData("", "");
            comboBoxLokasiAwal.DataSource = listLokasi;
            List<Lokasi> listLokasi1 = Lokasi.BacaData("", "");
            comboBoxLokasiAkhir.DataSource = listLokasi1;
            FormUtama frm = (FormUtama)this.MdiParent;

            dateTimePickerJam.Value = DateTime.Now;

            //Pria tidak bisa menggunakan fitur request driver wanita
            if (frm.userLogin.Gender != "Female")
            {
                checkBoxDriverWanita.Visible = false;
                reqWanita = false;
            }
            groupBoxPesan.Visible = false;
        }
        Jarak jarakLokasi;
        private void buttonCekHarga_Click(object sender, EventArgs e)
        {
            try
            {
                buttonPesan.Visible = true;
                groupBoxPesan.Visible = true;

                Lokasi awal = Lokasi.BacaData("nama", comboBoxLokasiAwal.Text)[0];
                Lokasi akhir = Lokasi.BacaData("nama", comboBoxLokasiAkhir.Text)[0];
                jarakLokasi = Jarak.BacaData(awal, akhir)[0];
                labelJarak.Text = jarakLokasi.JarakKM.ToString();
                Waktu waktu = Waktu.BacaData(DateTime.Now.Hour)[0];

                int biayaDriverWanita = 0;
                if (checkBoxDriverWanita.Checked)
                {
                    //Jika ada permintaan driver Wanita, ada tambahan Rp 1.500
                    biayaDriverWanita = 1500;
                    reqWanita = true;
                }
                else
                {
                    reqWanita = false;
                    biayaDriverWanita = 0;
                }
                int biayaMotorBaru = 0;
                if (checkBoxMotorBru.Checked)
                {
                    //Jika ada permintaan motor baru, ada tambahan Rp 5.000
                    biayaMotorBaru = 5000;
                    reqMotorBaru = true;
                }
                else
                {
                    reqMotorBaru = false;
                    biayaMotorBaru = 0;
                }
                int hargaPerKM = waktu.Harga;
                int jarakTotal = jarakLokasi.JarakKM;
                int hargaTotal = (hargaPerKM * jarakTotal) + biayaMotorBaru + biayaDriverWanita;
                labelHarga.Text = hargaTotal.ToString();
            }catch(Exception ex)
            {
                MessageBox.Show("Terjadi error saat memilih lokasi. Coba lagi." + ex.Message);
                buttonPesan.Visible = false;
            }
        }

        private void buttonPesan_Click(object sender, EventArgs e)
        {
            try
            {
                FormUtama frm = (FormUtama)this.MdiParent;
                int sisaSaldo = frm.userLogin.IdGassmon.Saldo;
                int sisaPoin = frm.userLogin.IdGassmon.Poin;
                int biaya = int.Parse(labelHarga.Text);
                if (biaya > sisaPoin && biaya > sisaSaldo)
                {
                    MessageBox.Show("Saldo dan poin anda tidak mencukupi, silahkan top up terlebih dahulu");
                }

                else
                {
                    this.Visible = false;
                    if (checkBoxPoin.Checked == true)
                    {
                        //logic pakai poin, kurangi biaya sesuai poin yang ada dengan kelipatan 5000
                        int maxPotongan =biaya - ( biaya % 5000);
                        int poinTersedia = sisaPoin - (sisaPoin % 5000);
                        int poinDipakai = Math.Min(maxPotongan, poinTersedia);
                        if (poinDipakai < 5000)
                        {
                            poinDipakai = 0;
                        }

                        if ((biaya-poinDipakai) <= sisaSaldo)
                        {
                            //Bayar
                            MessageBox.Show("Pembayaran anda berhasil, poin akan terpotong " + biaya);
                            //kurangi poin pada database
                            Gassmon.BayarPakaiPoin(poinDipakai, frm.userLogin);
                            //kurangi saldo pada database
                            Gassmon.BayarPakaiSaldo(biaya-poinDipakai, frm.userLogin);
                        }
                    }
                    else
                    {
                        if (biaya <= sisaSaldo && biaya > sisaPoin || biaya <= sisaSaldo && biaya <= sisaPoin)
                        {
                            MessageBox.Show("Pembayaran anda berhasil, saldo akan terpotong " + biaya);
                            Gassmon.BayarPakaiSaldo(biaya, frm.userLogin);
                        }
                        else
                        {
                            MessageBox.Show("Pembayaran anda berhasil, poin akan terpotong " + biaya);
                            Gassmon.BayarPakaiPoin(biaya, frm.userLogin);
                        }
                    }
                    //buat pesanan
                    //nt biayaTransaksi = int.Parse(labelHarga.Text);
                    double tip = biaya * 0.2;
                    User konsumen = frm.userLogin;
                    Driver newDriver = Driver.PanggilDriver(reqWanita, reqMotorBaru);

                    Waktu waktuOrder;
                    DateTime jamOrder;
                    if (radioButtonSekarang.Checked)
                    {
                        waktuOrder = Waktu.BacaData(DateTime.Now.Hour)[0];
                        jamOrder = DateTime.Now;
                    }
                    else
                    {
                        waktuOrder = Waktu.BacaData(dateTimePickerJam.Value.Hour)[0];
                        jamOrder = dateTimePickerJam.Value;
                    }

                    OrderRide pesanan = OrderRide.BuatPesanan(tip, konsumen, newDriver, waktuOrder, jarakLokasi, reqWanita,
                        reqMotorBaru, jamOrder, biaya);
                    FormGassRideKonfirmasi frmKonfirmasi = new FormGassRideKonfirmasi(pesanan);
                    frmKonfirmasi.ShowDialog();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void radioButtonSekarang_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePickerJam.Enabled = false;
        }

        private void radioButtonPesanNanti_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePickerJam.Enabled = true;
        }
    }
}
