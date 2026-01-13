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
    }
}
