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
    public partial class FormDaftarCancel : Form
    {
        public FormDaftarCancel()
        {
            InitializeComponent();
        }
        List<DetailCancel> listDetail = new List<DetailCancel>();
        private void FormDaftarCancel_Load(object sender, EventArgs e)
        {
            listDetail = DetailCancel.BacaData();
            dataGridViewCancel.DataSource = listDetail;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            DateTime awal = dateTimePickerAwal.Value;
            DateTime akhir = dateTimePickerAkhir.Value.AddDays(1).AddTicks(-1);
            List<DetailCancel> hasilFilter = DetailCancel.FilterByDate(awal, akhir, listDetail);
            dataGridViewCancel.DataSource = null;

            dataGridViewCancel.DataSource = hasilFilter;
        }
    }
}
