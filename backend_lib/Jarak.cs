using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backend_lib
{
    public class Jarak
    {
        private int id;
        private int jarakKM;
        private Lokasi lokasiAwal;
        private Lokasi lokasiAkhir;

        public int Id { get => id; set => id = value; }
        public int JarakKM { get => jarakKM; set => jarakKM = value; }
        public Lokasi LokasiAwal { get => lokasiAwal; set => lokasiAwal = value; }
        public Lokasi LokasiAkhir { get => lokasiAkhir; set => lokasiAkhir = value; }

        //hitung jarak dari longtitude dan latitude
        static double Haversine(double lat1, double lon1, double lat2, double lon2)
        {
            double R = 6371; // radius bumi dalam km

            double dLat = ToRadians(lat2 - lat1);
            double dLon = ToRadians(lon2 - lon1);

            double a = Math.Sin(dLat / 2) * Math.Sin(dLat / 2) +
                       Math.Cos(ToRadians(lat1)) * Math.Cos(ToRadians(lat2)) *
                       Math.Sin(dLon / 2) * Math.Sin(dLon / 2);

            double c = 2 * Math.Asin(Math.Sqrt(a));
            return R * c;
        }
        static double ToRadians(double deg)
        {
            return deg * Math.PI / 180;
        }
        public static List<Jarak> BacaData(Lokasi lAwal, Lokasi lAkhir)
        {
            string perintah = "select * from jarak where lokasiIdLokasiAwal = " + lAwal.Id + " and lokasiIdLokasiAkhir = " + lAkhir.Id;
            MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(perintah);
            List<Jarak> ListData = new List<Jarak>();
            while (hasil.Read() == true)
            {
                Jarak j = new Jarak();
                j.Id = hasil.GetInt32(0);
                double lat1 = lAwal.Latitude;
                double lon1 = lAwal.Longitude;

                double lat2 = lAkhir.Latitude;
                double lon2 = lAkhir.Longitude;

                j.jarakKM = (int)Haversine(lat1, lon1, lat2, lon2);
                j.LokasiAwal = lAwal;
                j.LokasiAkhir = lAkhir;
                ListData.Add(j);
            }
            hasil.Close();
            return ListData;
        }

        public static Jarak BacaDataJarak(int pId)
        {
            string perintah = $"select * from jarak where idJarak = {pId};";
            MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(perintah);
            if (hasil.Read() == true)
            {
                Jarak j = new Jarak();
                j.Id = hasil.GetInt32(0);
                j.LokasiAwal = Lokasi.BacaDataLokasi(hasil.GetInt32(2));
                j.lokasiAkhir = Lokasi.BacaDataLokasi(hasil.GetInt32(3));
                j.JarakKM = (int)Haversine(j.LokasiAwal.Latitude, j.LokasiAwal.Longitude, j.LokasiAkhir.Latitude, j.LokasiAkhir.Longitude);
                hasil.Close();
                return j;
            }
            else return null;
        }
    }
}
