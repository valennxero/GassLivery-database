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
    public partial class FormHistoryPenarikanDana : Form
    {
        Driver driverLogin;
        public FormHistoryPenarikanDana(Driver pDriver)
        {
            InitializeComponent();
            driverLogin = pDriver;
        }

        private void FormHistoryPenarikanDana_Load(object sender, EventArgs e)
        {
            List<PenarikanDana> listPenarikan = PenarikanDana.BacaDataPenarikanByDriver(driverLogin);
            for (int i = 0; i < listPenarikan.Count; i++)
            {
                int id = listPenarikan[i].Id;
                DateTime tglPenarikan = listPenarikan[i].TanggalPenarikan;
                int jumlahPenarikan = listPenarikan[i].Nominal;
                dataGridViewPenarikan.Rows.Add(id, tglPenarikan, jumlahPenarikan);
            }
        }
    }
}
