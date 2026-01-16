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
        public FormHistoryRide(User pUser)
        {
            InitializeComponent();
            userLogin = pUser;
        }

        private void FormHistoryRide_Load(object sender, EventArgs e)
        {
            List<OrderRide> listOrder = OrderRide.BacaData(userLogin);
            for (int i = 0; i < listOrder.Count; i++)
            {
                int id = listOrder[i].Id;
                DateTime tglOrder = listOrder[i].TanggalOrder;
                int biaya = listOrder[i].TotalTransaksi;
                string namaDriver = listOrder[i].Driver.Nama;
                dataGridViewDataRiwayat.Rows.Add(id,  tglOrder, biaya, namaDriver);
            }
        }

        private void dataGridViewDataRiwayat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int idx = dataGridViewDataRiwayat.CurrentRow.Index;
            if (e.ColumnIndex == dataGridViewDataRiwayat.Columns["Detail"].Index)
            {
                FormNotaGassRide formNota = new FormNotaGassRide(OrderRide.BacaDataById((int)dataGridViewDataRiwayat.Rows[idx].Cells[0].Value));
                formNota.ShowDialog();
            }
        }
    }
}
