using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backend_lib
{
    public class DetailCancel
    {
        private string namaDriver;
        private int idDriver;
        private DateTime tanggalOrder;
        private int idKonsumen;
        private string alasan;

        public DetailCancel(string namaDriver, int idDriver, DateTime tanggalOrder, int idKonsumen, string alasan)
        {
            NamaDriver = namaDriver;
            IdDriver = idDriver;
            TanggalOrder = tanggalOrder;
            IdKonsumen = idKonsumen;
            Alasan = alasan;
        }

        public string NamaDriver { get => namaDriver; set => namaDriver = value; }
        public int IdDriver { get => idDriver; set => idDriver = value; }
        public DateTime TanggalOrder { get => tanggalOrder; set => tanggalOrder = value; }
        public int IdKonsumen { get => idKonsumen; set => idKonsumen = value; }
        public string Alasan { get => alasan; set => alasan = value; }

        public static List<DetailCancel> BacaData()
        {
            string perintah = "select d.nama, d.idDriver, o.tanggalOrder, c.konsumenId, c.alasan " +
                "from orderride o join cancelOrder c on o.idOrderRide = c.orderRideId " +
                "join driver d on o.driverid = d.idDriver order by alasan;";
            MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(perintah);
            List<DetailCancel> listDetail = new List<DetailCancel>();
            while (hasil.Read())
            {
                string namaDriver = hasil.GetValue(0).ToString();
                int idDriver = int.Parse(hasil.GetValue(1).ToString());
                DateTime tanggalOrder = DateTime.Parse(hasil.GetValue(2).ToString());
                int idKonsumen = int.Parse(hasil.GetValue(3).ToString());
                string alasan = hasil.GetValue(4).ToString();
                DetailCancel dc = new DetailCancel(namaDriver, idDriver, tanggalOrder, idKonsumen, alasan);
                listDetail.Add(dc);
            }
            hasil.Close();
            return listDetail;

        }
        public static List<DetailCancel> FilterByDate(DateTime startDate, DateTime endDate, List<DetailCancel> listDetail)
        {
            List<DetailCancel> filtered = new List<DetailCancel>(listDetail);
            filtered.RemoveAll(f => f.TanggalOrder < startDate || f.TanggalOrder > endDate);
            return filtered;
        }
    }
}
