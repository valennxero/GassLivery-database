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
    public partial class FormGassSend : Form
    {
        public FormGassSend()
        {
            InitializeComponent();
        }

        User userLogin;
        Driver driverLogin;
        public FormGassSend(User pUser, Driver pDriver)
        {
            InitializeComponent();
            userLogin = pUser;
            driverLogin = pDriver;
        }

        Jarak jarakTerpilih;
        int beratBarangValue = 0;

        private void comboBoxLokasiAwal_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FormGassSend_Load(object sender, EventArgs e)
        {
            try
            {
                // Load Data Lokasi ke ComboBox
                List<Lokasi> listLokasiAwal = Lokasi.BacaData("", "");
                comboBoxLokasiAwal.DataSource = listLokasiAwal;
                comboBoxLokasiAwal.DisplayMember = "Nama";

                List<Lokasi> listLokasiTujuan = Lokasi.BacaData("", "");
                comboBoxLokasiAkhir.DataSource = listLokasiTujuan;
                comboBoxLokasiAkhir.DisplayMember = "Nama";

                // Default state
                buttonPesan.Visible = false;

                // Set default jam (jika ada logic waktu seperti GassRide)
                // dateTimePickerJam.Value = DateTime.Now; 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data lokasi: " + ex.Message);
            }
        }

        Jarak jarakLokasi;

        private void buttonCekHarga_Click(object sender, EventArgs e)
        {
            try
            {
                Lokasi awal = Lokasi.BacaData("nama", comboBoxLokasiAwal.Text)[0];
                Lokasi akhir = Lokasi.BacaData("nama", comboBoxLokasiAkhir.Text)[0];
                jarakLokasi = Jarak.BacaData(awal, akhir)[0];
                Waktu waktu = Waktu.BacaData(DateTime.Now.Hour)[0];

                
                if (awal.Id== akhir.Id) 
                {
                    MessageBox.Show("Lokasi asal dan tujuan tidak boleh sama!");
                    return;
                }

                List<Jarak> listJarak = Jarak.BacaData(awal, akhir);

                if (listJarak.Count > 0)
                {
                    jarakTerpilih = listJarak[0];                 
                }
                else
                {
                    MessageBox.Show("Rute tidak ditemukan! Silakan pilih lokasi lain.");
                    return;
                }

                int biayaBerat = 0;
                beratBarangValue = 0;

                if (checkBoxKurangDari5Kilo.Checked)
                {
                    checkBoxDiantara10dengan20Kilo.Checked = false;
                    checkBoxDiantara5dengan10Kilo.Checked = false;
                    biayaBerat = 5000;
                    beratBarangValue = 5; // Simpan nilai int untuk database
                }
                else if (checkBoxDiantara5dengan10Kilo.Checked)
                {
                    checkBoxKurangDari5Kilo.Checked = false;
                    checkBoxDiantara10dengan20Kilo.Checked= false;
                    biayaBerat = 10000;
                    beratBarangValue = 10;
                }
                else if (checkBoxDiantara10dengan20Kilo.Checked)
                {
                    checkBoxKurangDari5Kilo.Checked=false;
                    checkBoxDiantara5dengan10Kilo.Checked = false;
                    biayaBerat = 20000;
                    beratBarangValue = 20;
                }
                else 
                {
                    MessageBox.Show("Mohon pilih berat barang terlebih dahulu.");
                    return;
                }

                int hargaPerKM = waktu.Harga;
                int jarakTotal = jarakLokasi.JarakKM;
                int hargaTotal = (hargaPerKM * jarakTotal) + biayaBerat;
             
                labelHarga.Text = hargaTotal.ToString();
                buttonPesan.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Cek Harga: " + ex.Message);
                buttonPesan.Visible = false;
            }
        }

        private void checkBoxKurangDari5Kilo_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxDiantara10dengan20Kilo.Checked = false;
            checkBoxDiantara5dengan10Kilo.Checked = false;
        }

        private void checkBoxDiantara5dengan10Kilo_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxKurangDari5Kilo.Checked = false;
            checkBoxDiantara10dengan20Kilo.Checked = false;
        }

        private void checkBoxDiantara10dengan20Kilo_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxKurangDari5Kilo.Checked = false;
            checkBoxDiantara5dengan10Kilo.Checked = false;
        }

        private void buttonPesan_Click(object sender, EventArgs e)
        {
            try
            {
                FormUtama frm = (FormUtama)this.MdiParent;
                int sisaSaldo = frm.userLogin.IdGassmon.Saldo;
                int sisaPoin = frm.userLogin.IdGassmon.Poin;
                int biaya = int.Parse(labelHarga.Text);
                int tip = (int)(biaya * 0.2);
                if (biaya > sisaPoin && biaya > sisaSaldo)
                {
                    MessageBox.Show("Saldo dan poin anda tidak mencukupi, silahkan top up terlebih dahulu");
                }

                else
                {
                    this.Visible = false;
                    Gassmon.Bayar(checkBoxPoin.Checked, biaya, sisaPoin, sisaSaldo, frm.userLogin);
                    //buat pesanan
                    User konsumen = frm.userLogin;
                    Driver newDriver = Driver.PanggilDriver(false, false);

                    Waktu waktuOrder = Waktu.BacaData(DateTime.Now.Hour)[0];
                    DateTime jamOrder = DateTime.Now;
                    

                    OrderGassSend pesanan = OrderGassSend.BuatPesanan(konsumen, newDriver, jarakLokasi, 
                        beratBarangValue, biaya, tip, waktuOrder);
                    FormGassRideKonfirmasi frmKonfirmasi = new FormGassRideKonfirmasi(null, pesanan);
                    frmKonfirmasi.ShowDialog();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
