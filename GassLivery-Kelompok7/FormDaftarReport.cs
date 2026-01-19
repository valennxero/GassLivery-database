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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GassLivery_Kelompok7
{
    public partial class FormDaftarReport : Form
    {
        public FormDaftarReport()
        {
            InitializeComponent();
        }

        List<Report> listReport;
        private void FormDaftarReport_Load(object sender, EventArgs e)
        {
            listReport = Report.BacaDataReport(0);
            for (int i = 0; i < listReport.Count; i++)
            {
                string status = "";
                if(listReport[i].StatusReport == true)
                {
                    status = "Dikonfirmasi";
                }
                else
                {
                    status = "Belum Dikonfirmasi";
                }
                dataGridViewReport.Rows.Add(
                    listReport[i].Id,
                    listReport[i].Order.Id,
                    listReport[i].Order.TanggalOrder.ToString("dd/MM/yyyy"),
                    listReport[i].Order.Konsumen.Id,
                    listReport[i].Order.Konsumen.Nama,
                    status
                    );
            }
        }

        private void dataGridViewReport_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int idx = dataGridViewReport.CurrentRow.Index;
            if (e.ColumnIndex == dataGridViewReport.Columns["CekNota"].Index)
            {
                int idOrder = (int)dataGridViewReport.Rows[idx].Cells[1].Value;
                FormNotaGassRide formNota = new FormNotaGassRide(OrderRide.BacaData("idOrderRide", idOrder)[0]);
                formNota.ShowDialog();
            }
            if (e.ColumnIndex == dataGridViewReport.Columns["Konfirmasi"].Index)
            {
                DialogResult result = MessageBox.Show("Apakah anda yakin ingin mengkonfirmasi report ini?", "Konfirmasi Report", MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                {
                    return;
                }
                int idReport = (int)dataGridViewReport.Rows[idx].Cells[0].Value;
                Report reportDipilih = Report.BacaDataReport(idReport)[0];
                //panggil method ubah status report
                Report.UpdateStatusReport(reportDipilih);
                //panggil method kurangi rating driver
                Report.KurangiBintangDriver(reportDipilih.Order.Driver);
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            DateTime awal = dateTimePickerAwal.Value;
            DateTime akhir = dateTimePickerAkhir.Value.AddDays(1).AddTicks(-1);
            List<Report> hasilFilter = Report.FilterReportByDate(awal, akhir, listReport);
            dataGridViewReport.Rows.Clear();

            for (int i = 0; i < hasilFilter.Count; i++)
            {
                string status = "";
                if (hasilFilter[i].StatusReport == true)
                {
                    status = "Dikonfirmasi";
                }
                else
                {
                    status = "Belum Dikonfirmasi";
                }
                dataGridViewReport.Rows.Add(
                    hasilFilter[i].Id,
                    hasilFilter[i].Order.Id,
                    hasilFilter[i].Order.TanggalOrder.ToString("dd/MM/yyyy"),
                    hasilFilter[i].Order.Konsumen.Id,
                    hasilFilter[i].Order.Konsumen.Nama,
                    status
                    );
            }
        }
    }
}
