using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backend_lib
{
    public class RatingDriver
    {
        private User konsumen;
        private Driver driver;
        private int id;
        private int nilai;

        public RatingDriver(User konsumen, Driver driver, int id, int nilai)
        {
            Konsumen = konsumen;
            Driver = driver;
            Id = id;
            Nilai = nilai;
        }

        public User Konsumen { get => konsumen; set => konsumen = value; }
        public Driver Driver { get => driver; set => driver = value; }
        public int Id { get => id; set => id = value; }
        public int Nilai { get => nilai; set => nilai = value; }

        public static void RateDriver(OrderRide pOrder, int pNilai)
        {
            string perintah = "insert into rating (konsumenId, driverId, nilai)" +
                $" values ({pOrder.Konsumen.Id}, {pOrder.Driver.Id}, {pNilai});";
            Koneksi.JalankanQuery(perintah);
        }

        public static void UpdateTotalRatingDriver(Driver pDriver)
        {
            string perintah = "update driver d" +
                " set d.ratingTotal = (select avg(r.nilai)" +
                " from rating r where r.driverId = d.idDriver)WHERE d.idDriver ="+ pDriver.Id;
            Koneksi.JalankanQuery(perintah);
        }
    }
}
