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
        private double latitude;
        private double longitude;

        public Lokasi(int pId, string pNama, double latitude, double longitude)
        {
            this.Id = pId;
            this.Nama = pNama;
            this.Latitude = latitude;
            this.Longitude = longitude;

        }

        public int Id { get => id; set => id = value; }
        public string Nama { get => nama; set => nama = value; }
        public double Latitude { get => latitude; set => latitude = value; }
        public double Longitude { get => longitude; set => longitude = value; }

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
                Lokasi l = new Lokasi(hasil.GetInt32(0), hasil.GetValue(1).ToString(), hasil.GetDouble(2), hasil.GetDouble(3));
                ListData.Add(l);
            }
            hasil.Close();
            return ListData;
        }

        public static Lokasi BacaDataLokasi(int pId)
        {
            string perintah = $"select * from lokasi where idLokasi = {pId};";
            MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(perintah);
            if (hasil.Read() == true)
            {
                Lokasi l = new Lokasi(hasil.GetInt32(0), hasil.GetValue(1).ToString(), hasil.GetDouble(2), hasil.GetDouble(3));
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