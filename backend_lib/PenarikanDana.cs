using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backend_lib
{
    public class PenarikanDana
    {
        private int id;
        private int nominal;
        private DateTime tanggalPenarikan;
        private Driver driver;

        public PenarikanDana(int id, int nominal, DateTime tanggalPenarikan, Driver driver)
        {
            Id = id;
            Nominal = nominal;
            TanggalPenarikan = tanggalPenarikan;
            Driver = driver;
        }

        public int Id { get => id; set => id = value; }
        public int Nominal { get => nominal; set => nominal = value; }
        public DateTime TanggalPenarikan { get => tanggalPenarikan; set => tanggalPenarikan = value; }
        public Driver Driver { get => driver; set => driver = value; }

        public static void TambahData(PenarikanDana pTarikDana)
        {
            string perintah = "INSERT INTO PenarikanDana (Nominal, TanggalPenarikan, DriverId) " +
                             "VALUES (" + pTarikDana.Nominal + ", '" + pTarikDana.TanggalPenarikan.ToString("yyyy-MM-dd") + "', " + pTarikDana.Driver.Id + ")";
            Koneksi.JalankanQuery(perintah);
        }
    }
}
