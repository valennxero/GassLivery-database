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
    public partial class FormPilihMenu : Form
    {
        Tenant tenantPilihan;
        User userLogin;
        Jarak jarakLokasi;
        public FormPilihMenu(Tenant pTenant, User pUser, Jarak pJarak)
        {
            InitializeComponent();
            tenantPilihan = pTenant;
            userLogin = pUser;
            jarakLokasi = pJarak;
        }

        private void FormPilihMenu_Load(object sender, EventArgs e)
        {
            labelNamaTenant.Text = tenantPilihan.NamaTenant;
            labelLokasi.Text = $" Lokasi: {tenantPilihan.LokasiTenant.Nama}";
            //tentukan harga ongkir
            Waktu waktu = Waktu.BacaDataGassKan(DateTime.Now.Hour);
            int biayaPerKm = waktu.Harga;
            int jarakTotal = jarakLokasi.JarakKM;
            int ongkir = biayaPerKm * jarakTotal;
            labelOngkir.Text = ongkir.ToString();

            //tampilkan menu tenant
            string uid = tenantPilihan.Id.ToString();
            List<MenuTenant> listMenu = MenuTenant.BacaDataMenu("tenantId", uid);
            for (int i = 0; i < listMenu.Count; i++)
            {
                string namaMenu = listMenu[i].NamaMenu;
                int hargaJual = listMenu[i].HargaJual;
                string statusHalal;
                if (listMenu[i].StatusHalal)
                {
                    statusHalal = "Halal";
                }
                else
                {
                    statusHalal = "Non-Halal";
                }
                dataGridViewMenu.Rows.Add(namaMenu, hargaJual, statusHalal);
            }
        }
        public void HitungTotal()
        {
            int total = 0;
            for (int i = 0; i < dataGridViewKeranjang.Rows.Count - 1; i++)
            {
                int subtotal = int.Parse(dataGridViewKeranjang.Rows[i].Cells["HargaTotal"].Value.ToString());
                total += subtotal;
            }
            labelHargaTotal.Text = total.ToString();
            labelTotal.Text = (int.Parse(labelOngkir.Text) + total).ToString();
        }
        private void dataGridViewMenu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            int idxMenu = e.RowIndex;

            string namaMenu = dataGridViewMenu.Rows[idxMenu].Cells[0].Value.ToString();
            int harga = int.Parse(dataGridViewMenu.Rows[idxMenu].Cells[1].Value.ToString());

            // pilih (tambahkan ke keranjang)
            if (e.ColumnIndex == dataGridViewMenu.Columns["Pilih"].Index)
            {
                bool ditemukan = false;

                foreach (DataGridViewRow row in dataGridViewKeranjang.Rows)
                {
                    if (row.IsNewRow) continue;

                    string namaDiKeranjang = Convert.ToString(row.Cells[0].Value);

                    if (namaDiKeranjang == namaMenu)
                    {
                        int jumlah = Convert.ToInt32(row.Cells[2].Value);
                        jumlah++;

                        row.Cells[2].Value = jumlah;
                        row.Cells[3].Value = jumlah * harga;

                        ditemukan = true;
                        break;
                    }
                }

                if (!ditemukan)
                {
                    dataGridViewKeranjang.Rows.Add(namaMenu, harga, 1, harga);
                }
                HitungTotal();
            }

            // hapus (kurangi dari keranjang)
            if (e.ColumnIndex == dataGridViewMenu.Columns["Hapus"].Index)
            {
                if (dataGridViewKeranjang.CurrentRow == null)
                    return;

                if (dataGridViewKeranjang.Rows.Count == 0)
                    return;

                DataGridViewRow row = dataGridViewKeranjang.CurrentRow;

                if (row.IsNewRow)
                    return;

                int jumlah = Convert.ToInt32(row.Cells[2].Value);
                int harga1 = Convert.ToInt32(row.Cells[1].Value);

                jumlah--;

                if (jumlah <= 0)
                {
                    dataGridViewKeranjang.Rows.Remove(row);
                }
                else
                {
                    row.Cells[2].Value = jumlah;
                    row.Cells[3].Value = jumlah * harga1;
                }
                HitungTotal();
            }
        }

        private void buttonKonfirmasi_Click(object sender, EventArgs e)
        {
            //buat list food detail dari data grid view keranjang
            List<FoodDetail> listFoodDetail = new List<FoodDetail>();
            for (int i = 0; i < dataGridViewKeranjang.Rows.Count - 1; i++)
            {
                string namaMenu = dataGridViewKeranjang.Rows[i].Cells[0].Value.ToString();
                int harga = int.Parse(dataGridViewKeranjang.Rows[i].Cells[1].Value.ToString());
                int jumlah = int.Parse(dataGridViewKeranjang.Rows[i].Cells[2].Value.ToString());
                MenuTenant menu = MenuTenant.BacaDataMenu("nama", namaMenu)[0];
                FoodDetail fd = new FoodDetail();
                fd.Menu = menu;
                fd.Harga = harga;
                fd.Jumlah = jumlah;
                listFoodDetail.Add(fd);
            }
            //buat objek orderFood
            DateTime tanggalPesan = DateTime.Now;
            Waktu waktu = Waktu.BacaDataGassKan(DateTime.Now.Hour);
            int biayaPerKm = waktu.Harga;
            int jarakTotal = jarakLokasi.JarakKM;
            int ongkir = biayaPerKm * jarakTotal;
            int biayaMakanan = int.Parse(labelHargaTotal.Text);
            double tip = 0.2 * ongkir;
            int biayaTotal = ongkir + biayaMakanan;
            //panggil driver
            Driver driver = Driver.PanggilDriver(false, false);

            OrderFood od = OrderFood.BuatPesanan(
                tanggalPesan,
                ongkir,
                tip,
                driver,
                userLogin,
                waktu,
                jarakLokasi,
                false,
                biayaTotal,
                listFoodDetail,
                tenantPilihan
                );

            if(dataGridViewKeranjang.Rows.Count - 1 == 0)
            {
                MessageBox.Show(Text = "Keranjang kosong!", "Info");
                return;
            }

            FoodDetail.TambahData(od);
            Gassmon.Bayar(checkBoxPoin.Checked, biayaTotal, userLogin.IdGassmon.Poin, userLogin.IdGassmon.Saldo, userLogin);
            this.Close();

            MessageBox.Show(Text = "Pesanan berhasil dibuat!", "Info");
            FormGassKanKonfirmasi frm = new FormGassKanKonfirmasi(od);
            frm.ShowDialog();
        }

        private void dataGridViewKeranjang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
