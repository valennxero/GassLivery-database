using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Drawing;
using System.IO;

namespace backend_lib
{
    public class Lokasi
    {
        private int id;
        private string nama;

        public Lokasi(int pId, string pNama)
        {
            this.Id = pId;
            this.Nama = pNama;
        }

        public int Id { get => id; set => id = value; }
        public string Nama { get => nama; set => nama = value; }

        public static List<Lokasi> BacaData(string filter, string nilai)
        {
            string perintah;
            if (filter == "")
            {
                perintah = "Select * from lokasi; ";
            }
            else
            {
                perintah = "Select * from lokasi" +
                   " where " + filter + " like '%" + nilai + "%'";
            }
            MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(perintah);
            List<Lokasi> ListData = new List<Lokasi>();
            while (hasil.Read() == true)
            {
                Lokasi l = new Lokasi (hasil.GetInt32(0), hasil.GetValue(1).ToString());
                ListData.Add(l);
            }
            return ListData;
        }

        public static Lokasi BacaDataLokasi(int pId)
        {
            string perintah = $"select * from lokasi where idLokasi = {pId};";
            MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(perintah);
            if (hasil.Read() == true)
            {
                Lokasi l = new Lokasi(hasil.GetInt32(0), hasil.GetValue(1).ToString());
                hasil.Close();
                return l;
            }
            else return null;
        }
        public override string ToString()
        {
            return Nama;
        }
    }
}
