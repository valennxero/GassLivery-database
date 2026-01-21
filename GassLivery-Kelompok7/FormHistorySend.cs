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
    public partial class FormHistorySend : Form
    {
        User userLogin;

        public FormHistorySend(User pUser)
        {
            InitializeComponent();
            userLogin = pUser;
        }
        List<OrderGassSend> listOrder = new List<OrderGassSend>();
        private void FormHistorySend_Load(object sender, EventArgs e)
        {
            if (userLogin != null)
            {
                listOrder = OrderGassSend.BacaData("konsumenId", userLogin.Id.ToString());
            }
            for (int i = 0; i < listOrder.Count; i++)
            {
                int id = listOrder[i].IdOrderGassSend;
                DateTime tglOrder = listOrder[i].TanggalOrder;
                int biaya = listOrder[i].TotalHarga;
                string namaDriver = listOrder[i].Driver.Nama;
                double honor = listOrder[i].Tip;
                int berat = listOrder[i].BeratBarang;
                dataGridViewDataRiwayat.Rows.Add(id, tglOrder, biaya, namaDriver, honor, berat);
            }
        }

        private void dataGridViewDataRiwayat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int idx = dataGridViewDataRiwayat.CurrentRow.Index;
            if (e.ColumnIndex == dataGridViewDataRiwayat.Columns["Detail"].Index)
            {
                int idOrder = (int)dataGridViewDataRiwayat.Rows[idx].Cells[0].Value;
                FormNotaGassRide formNota = new FormNotaGassRide(null, OrderGassSend.BacaData("idOrderGassSend", idOrder.ToString())[0]);
                formNota.ShowDialog();
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            DateTime awal = dateTimePickerAwal.Value;
            DateTime akhir = dateTimePickerAkhir.Value.AddDays(1).AddTicks(-1);
            List<OrderGassSend> hasilFilter = OrderGassSend.Filtered(awal, akhir, listOrder);
            dataGridViewDataRiwayat.Rows.Clear();

            for (int i = 0; i < hasilFilter.Count; i++)
            {
                int id = hasilFilter[i].IdOrderGassSend;
                DateTime tglOrder = hasilFilter[i].TanggalOrder;
                int biaya = hasilFilter[i].TotalHarga;
                string namaDriver = hasilFilter[i].Driver.Nama;
                double honor = hasilFilter[i].Tip;
                dataGridViewDataRiwayat.Rows.Add(id, tglOrder, biaya, namaDriver, honor);
            }
        }
    }
}
