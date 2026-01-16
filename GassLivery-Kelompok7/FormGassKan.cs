using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using backend_lib;

namespace GassLivery_Kelompok7
{
    public partial class FormGassKan : Form
    {
        public FormGassKan()
        {
            InitializeComponent();
        }

        private void FormGassKan_Load(object sender, EventArgs e)
        {
            List<Lokasi> listLokasi = Lokasi.BacaData("", "");
            comboBoxAlamat.DataSource = listLokasi;
            List<Tenant> listTenant = Tenant.BacaData("","");
            comboBoxTenant.DataSource = listTenant;
            FormUtama frm = (FormUtama)this.MdiParent;
        }

        private void buttonCek_Click(object sender, EventArgs e)
        {
            FormUtama frm = (FormUtama)this.MdiParent;
            try
            {
                //tentukan jarak
                Lokasi akhir = Lokasi.BacaData("nama", comboBoxAlamat.Text)[0];
                string namaTenan = comboBoxTenant.Text;
                Tenant tenantTujuan = Tenant.BacaData("nama", namaTenan)[0];
                Lokasi awal = Lokasi.BacaData("nama", tenantTujuan.LokasiTenant.Nama)[0];
                Jarak j = Jarak.BacaData(awal, akhir)[0];

                string namaTenant = comboBoxTenant.Text;
                Tenant tenantPilihan = Tenant.BacaData("nama", namaTenant)[0];
                FormPilihMenu formPilihMenu = new FormPilihMenu(tenantPilihan, frm.userLogin, j);
                formPilihMenu.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message);
            }
        }
    }
}
