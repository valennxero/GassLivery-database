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
        public FormHistoryFood(User pUser)
        {
            InitializeComponent();
            userLogin = pUser;
        }

        private void FormHistoryFood_Load(object sender, EventArgs e)
        {
            List<OrderFood> listOrder = OrderFood.BacaData(userLogin, 0);
            for (int i = 0; i < listOrder.Count; i++)
            {
                int id = listOrder[i].Id;
                DateTime tglOrder = listOrder[i].TanggalOrder;
                int biaya = listOrder[i].TotalBiaya;
                string namaDriver = listOrder[i].Driver.Nama;
                string namaTenant = listOrder[i].Tenant.NamaTenant;
                dataGridViewDataRiwayat.Rows.Add(id, tglOrder, biaya, namaDriver, namaTenant);
            }
        }

        private void dataGridViewDataRiwayat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int idx = dataGridViewDataRiwayat.CurrentRow.Index;
            if (e.ColumnIndex == dataGridViewDataRiwayat.Columns["Detail"].Index)
            {
                int idOrder = (int)dataGridViewDataRiwayat.Rows[idx].Cells[0].Value;
                FormNotaGassKan formNota = new FormNotaGassKan(OrderFood.BacaData(null, idOrder)[0]);
                formNota.ShowDialog();
            }
        }
    }
}
