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

        public Tenant(int id, string namaTenant, Lokasi lokasiTenant)
        {
            Id = id;
            NamaTenant = namaTenant;
            LokasiTenant = lokasiTenant;
        }

        public Tenant()
        {
            this.Id = 0;
            this.NamaTenant = "";
            this.lokasiTenant = null;
        }
        public int Id { get => id; set => id = value; }
        public string NamaTenant { get => namaTenant; set => namaTenant = value; }
        public Lokasi LokasiTenant { get => lokasiTenant; set => lokasiTenant = value; }

        public static List<Tenant> BacaData(string filter, string nilai)
        {
            string perintah;
            if (filter == "")
            {
                perintah = "Select * from tenant; ";
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
                ListData.Add(t);
            }
            return ListData;
        }
        public override string ToString()
        {
            return NamaTenant;
        }
    }
}
