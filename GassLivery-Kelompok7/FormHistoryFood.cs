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
    public partial class FormHistoryFood : Form
    {
        User userLogin;
        Driver driverLogin;
        public FormHistoryFood(User pUser, Driver pDriver)
        {
            InitializeComponent();
            userLogin = pUser;
            driverLogin = pDriver;
        }
        List<OrderFood> listOrder;
        private void FormHistoryFood_Load(object sender, EventArgs e)
        {
            if (userLogin != null)
            {
                listOrder = OrderFood.BacaData(userLogin, 0, 0);
            }
            else
            {
                listOrder = OrderFood.BacaData(null, 0, driverLogin.Id);
            }
            for (int i = 0; i < listOrder.Count; i++)
            {
                int id = listOrder[i].Id;
                DateTime tglOrder = listOrder[i].TanggalOrder;
                int biaya = listOrder[i].TotalBiaya;
                string namaDriver = listOrder[i].Driver.Nama;
                string namaTenant = listOrder[i].Tenant.NamaTenant;
                double honorDriver = listOrder[i].Tip;
                dataGridViewDataRiwayat.Rows.Add(id, tglOrder, biaya, namaDriver, namaTenant, honorDriver);
            }
        }

        private void dataGridViewDataRiwayat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int idx = dataGridViewDataRiwayat.CurrentRow.Index;
            if (e.ColumnIndex == dataGridViewDataRiwayat.Columns["Detail"].Index)
            {
                int idOrder = (int)dataGridViewDataRiwayat.Rows[idx].Cells[0].Value;
                FormNotaGassKan formNota = new FormNotaGassKan(OrderFood.BacaData(null, idOrder, 0)[0]);
                formNota.ShowDialog();
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            DateTime awal = dateTimePickerAwal.Value;
            DateTime akhir = dateTimePickerAkhir.Value.AddDays(1).AddTicks(-1);
            List<OrderFood> hasilFilter = OrderFood.FilterOrderRideByDate(awal, akhir, listOrder);
            dataGridViewDataRiwayat.Rows.Clear();

            for (int i = 0; i < hasilFilter.Count; i++)
            {
                int id = hasilFilter[i].Id;
                DateTime tglOrder = hasilFilter[i].TanggalOrder;
                int biaya = hasilFilter[i].TotalBiaya;
                string namaDriver = hasilFilter[i].Driver.Nama;
                string namaTenant = hasilFilter[i].Tenant.NamaTenant;
                double honorDriver = hasilFilter[i].Tip;
                dataGridViewDataRiwayat.Rows.Add(id, tglOrder, biaya, namaDriver, namaTenant, honorDriver);
            }
        }
    }
}
