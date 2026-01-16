using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backend_lib
{
    public class RatingDriver
    {
        public static void RateDriver(User pUser, Driver pDriver, int pNilai)
        {
            string perintah = "insert into rating (konsumenId, driverId, nilai)" +
                $" values ({pUser.Id}, {pDriver.Id}, {pNilai});";
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
