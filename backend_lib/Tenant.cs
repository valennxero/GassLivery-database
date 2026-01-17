using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backend_lib
{
    public class Tenant
    {
        private int id;
        private string namaTenant;
        private Lokasi lokasiTenant;
        private double ratingTenant;
        private string username;
        private string password;

        public Tenant(int id, string namaTenant, Lokasi lokasiTenant, double ratingTenant, string username, string password)
        {
            Id = id;
            NamaTenant = namaTenant;
            LokasiTenant = lokasiTenant;
            RatingTenant = ratingTenant;
            Username = username;
            Password = password;
        }

        public Tenant()
        {
            this.Id = 0;
            this.NamaTenant = "";
            this.lokasiTenant = null;
            this.RatingTenant = 0;
            this.Username = "";
            this.Password = "";
        }
        public int Id { get => id; set => id = value; }
        public string NamaTenant { get => namaTenant; set => namaTenant = value; }
        public Lokasi LokasiTenant { get => lokasiTenant; set => lokasiTenant = value; }
        public double RatingTenant { get => ratingTenant; set => ratingTenant = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }

        public static List<Tenant> BacaData(string filter, string nilai)
        {
            string perintah;
            if (filter == "")
            {
                perintah = "Select * from tenant; ";
            }
            else if (filter == "idTenant")
            {
                perintah = "SELECT * FROM tenant WHERE idTenant = " + nilai;
            }
            else
            {
                perintah = "Select * from tenant" +
                   " where " + filter + " like '%" + nilai + "%'";
            }
            MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(perintah);
            List<Tenant> ListData = new List<Tenant>();
            while (hasil.Read() == true)
            {
                Tenant t = new Tenant();
                t.Id = int.Parse(hasil.GetValue(0).ToString());
                t.NamaTenant = hasil.GetValue(1).ToString();
                t.LokasiTenant = Lokasi.BacaDataLokasi(hasil.GetInt32(2));
                t.RatingTenant = hasil.GetDouble(3);
                t.Username = hasil.GetString(4).ToString();
                t.Password = hasil.GetString(5).ToString();
                ListData.Add(t);
            }
            hasil.Close();
            return ListData;
        }
        public override string ToString()
        {
            return NamaTenant;
        }
    }
}
