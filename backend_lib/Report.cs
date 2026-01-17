using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backend_lib
{
    public class Report
    {
        private int id;
        private OrderRide order;
        private bool statusReport;

        public Report(int id,OrderRide order, bool statusReport)
        {
            Id = id;
            Order = order;
            StatusReport = statusReport;
        }

        public OrderRide Order { get => order; set => order = value; }
        public bool StatusReport { get => statusReport; set => statusReport = value; }
        public int Id { get => id; set => id = value; }

        public static void LaporkanDriver(OrderRide order)
        {
            string perintah = "insert into report (konsumenId, orderRideId, statusReport)" +
                              $" values ({order.Konsumen.Id},{order.Id},{false});";
            //saat laporan dibuat, statusReport otomatis false sebelum dicek oleh admin
            Koneksi.JalankanQuery(perintah);
        }

        public static List<Report> BacaDataReport(int pId)
        {
            string perintah = "";
            if (pId == 0)
            {
                perintah = "select * from report;";
            }
            else
            {
                perintah = "select * from report " +
                           $"where idReport = {pId};";
            }
            MySql.Data.MySqlClient.MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(perintah);
            List<Report> ListData = new List<Report>();
            while (hasil.Read())
            {
                User konsumen = User.BacaData("id",hasil.GetInt32("konsumenId").ToString());
                OrderRide order = OrderRide.BacaData("idOrderRide", hasil.GetInt32("orderRideId"))[0];
                Report r = new Report(hasil.GetInt32("idReport"), order, hasil.GetBoolean("statusReport"));
                ListData.Add(r);
            }
            hasil.Close();
            return ListData;
        }

        public static void UpdateStatusReport(Report report)
        {
            string perintah = $"update report set statusReport = true " +
                              $"where idReport = {report.Id};";
            Koneksi.JalankanQuery(perintah);
        }

        public static void KurangiBintangDriver(Driver driver)
        {
            string perintah = $"update driver set ratingTotal = ratingTotal - 1 where idDriver = {driver.Id};";
            Koneksi.JalankanQuery(perintah);
        }

        public static List<Report> FilterReportByDate(DateTime startDate, DateTime endDate, List<Report> orders)
        {
            List<Report> filteredReport = new List<Report>(orders);
            filteredReport.RemoveAll(rp => rp.Order.TanggalOrder < startDate || rp.Order.TanggalOrder > endDate);
            return filteredReport;
        }

    }
}
