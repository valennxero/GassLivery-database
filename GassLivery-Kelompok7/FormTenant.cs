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
    public partial class FormTenant : Form
    {
        public FormTenant()
        {
            InitializeComponent();
        }
        public Tenant tenantLogin;

        List<DetailPenjualanMenu> listDetailPenjualanMenu;
        private void FormTenant_Load(object sender, EventArgs e)
        {
            listDetailPenjualanMenu = Tenant.BacaLaporanPenjualan(tenantLogin.Id);
            dataGridViewLaporan.DataSource = listDetailPenjualanMenu;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            DateTime awal = dateTimePickerAwal.Value;
            DateTime akhir = dateTimePickerAkhir.Value.AddDays(1).AddTicks(-1);
            List<DetailPenjualanMenu> hasilFilter = DetailPenjualanMenu.FilterByDate(awal, akhir, listDetailPenjualanMenu);
            dataGridViewLaporan.DataSource = null;

            dataGridViewLaporan.DataSource = hasilFilter;
        }
    }
}
