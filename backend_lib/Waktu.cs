using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backend_lib
{
    public class Waktu
    {
        private int id;
        private int jamAwal;
        private int jamAkhir;
        private int harga;

        public Waktu(int id, int jamAwal, int jamAkhir, int harga)
        {
            this.Id = id;
            this.JamAwal = jamAwal;
            this.JamAkhir = jamAkhir;
            this.Harga = harga;
        }
        public Waktu()
        {
            this.Id = 0;
            this.JamAwal = 0;
            this.JamAkhir = 0;
            this.Harga = 0;
        }
        public int Id { get => id; set => id = value; }
        public int JamAwal { get => jamAwal; set => jamAwal = value; }
        public int JamAkhir { get => jamAkhir; set => jamAkhir = value; }
        public int Harga { get => harga; set => harga = value; }

        public static List<Waktu> BacaData(int dt)
        {
            string perintah = "select * from waktu where " + dt + " between jamAwal and jamAkhir and kategori = 'gassride';";
            MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(perintah);
            List<Waktu> ListData = new List<Waktu>();
            while (hasil.Read() == true)
            {
                Waktu w = new Waktu();
                w.Id = hasil.GetInt32(0);
                w.JamAwal = hasil.GetInt32(1);
                w.harga = hasil.GetInt32(2);
                w.JamAkhir = hasil.GetInt32(3);
                ListData.Add(w);
            }
            return ListData;
        }

        public static Waktu BacaDataWaktu(int pId)
        {
            string perintah = $"select * from waktu where idWaktu = {pId};";
            MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(perintah);
            if (hasil.Read() == true)
            {
                Waktu w = new Waktu();
                w.Id = hasil.GetInt32(0);
                w.JamAwal = hasil.GetInt32(1);
                w.harga = hasil.GetInt32(2);
                w.JamAkhir = hasil.GetInt32(3);
                hasil.Close();
                return w;
            }
            else return null;
        }

        public static Waktu BacaDataGassKan(int dt)
        {
            string perintah = "select * from waktu where " + dt + " between jamAwal and jamAkhir and kategori = 'gasskan';";
            MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(perintah);
            if (hasil.Read() == true)
            {
                Waktu w = new Waktu();
                w.Id = hasil.GetInt32(0);
                w.JamAwal = hasil.GetInt32(1);
                w.harga = hasil.GetInt32(2);
                w.JamAkhir = hasil.GetInt32(3);
                return w;
            }
            else
            {
                return null;
            }
        }
    }


}
