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
    
    public partial class FormHistoryRide : Form
    {
        User userLogin;
        Driver driverLogin;
        public FormHistoryRide(User pUser, Driver pDriver)
        {
            InitializeComponent();
            userLogin = pUser;
            driverLogin = pDriver;
        }
        List<OrderRide> listOrder;

        private void FormHistoryRide_Load(object sender, EventArgs e)
        {

            if (userLogin != null)
            {
                listOrder = OrderRide.BacaData(userLogin, 0, 0);
            }
            else
            {
                listOrder = OrderRide.BacaData(null, 0, driverLogin.Id);
            }
            for (int i = 0; i < listOrder.Count; i++)
            {
                int id = listOrder[i].Id;
                DateTime tglOrder = listOrder[i].TanggalOrder;
                int biaya = listOrder[i].TotalTransaksi;
                string namaDriver = listOrder[i].Driver.Nama;
                double honor = listOrder[i].Tip;
                dataGridViewDataRiwayat.Rows.Add(id, tglOrder, biaya, namaDriver, honor);
            }
        }

        private void dataGridViewDataRiwayat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int idx = dataGridViewDataRiwayat.CurrentRow.Index;
            if (e.ColumnIndex == dataGridViewDataRiwayat.Columns["Detail"].Index)
            {
                int idOrder = (int)dataGridViewDataRiwayat.Rows[idx].Cells[0].Value;
                FormNotaGassRide formNota = new FormNotaGassRide(OrderRide.BacaData(null, idOrder, 0)[0]);
                formNota.ShowDialog();
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            DateTime awal = dateTimePickerAwal.Value;
            DateTime akhir = dateTimePickerAkhir.Value.AddDays(1).AddTicks(-1);
            List<OrderRide> hasilFilter = OrderRide.FilterOrderRideByDate(awal, akhir, listOrder);
            dataGridViewDataRiwayat.Rows.Clear();

            for (int i = 0; i < hasilFilter.Count; i++)
            {
                int id = hasilFilter[i].Id;
                DateTime tglOrder = hasilFilter[i].TanggalOrder;
                int biaya = hasilFilter[i].TotalTransaksi;
                string namaDriver = hasilFilter[i].Driver.Nama;
                double honor = hasilFilter[i].Tip;
                dataGridViewDataRiwayat.Rows.Add(id, tglOrder, biaya, namaDriver, honor);
            }
        }
    }
}
