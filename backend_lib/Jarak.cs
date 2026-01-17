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

        public static List<Jarak> BacaData(Lokasi lAwal, Lokasi lAkhir)
        {
            string perintah = "select * from jarak where lokasiIdLokasiAwal = " + lAwal.Id + " and lokasiIdLokasiAkhir = " + lAkhir.Id;
            MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(perintah);
            List<Jarak> ListData = new List<Jarak>();
            while (hasil.Read() == true)
            {
                Jarak j = new Jarak();
                j.Id = hasil.GetInt32(0);
                j.jarakKM = hasil.GetInt32(1);
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
                j.JarakKM = hasil.GetInt32(1);
                j.LokasiAwal = Lokasi.BacaDataLokasi(hasil.GetInt32(2));
                j.lokasiAkhir = Lokasi.BacaDataLokasi(hasil.GetInt32(3));
                hasil.Close();
                return j;
            }
            else return null;
        }
    }
}
