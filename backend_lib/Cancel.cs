using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backend_lib
{
    public class Cancel
    {
        private User konsumen;
        private OrderRide pesanan;
        private string alasan;

        public Cancel(User konsumen, OrderRide pesanan, string alasan)
        {
            Konsumen = konsumen;
            Pesanan = pesanan;
            Alasan = alasan;
        }

        public User Konsumen { get => konsumen; set => konsumen = value; }
        public OrderRide Pesanan { get => pesanan; set => pesanan = value; }
        public string Alasan { get => alasan; set => alasan = value; }

        public static void CancelOrder(Cancel cancel)
        {
            string perintah = "insert into cancelOrder (konsumenId, orderRideId, alasan) " +
                $"values ('{cancel.Konsumen.Id}', '{cancel.Pesanan.Id}', '{cancel.Alasan}');";
            Koneksi.JalankanPerintahSelect(perintah);
        }
    }
}
