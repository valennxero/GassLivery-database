using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backend_lib
{
    public class MenuTenant
    {
        private int id;
        private bool statusHalal;
        private string jenis;
        private string namaMenu;
        private int hargaJual;
        private Tenant tenant;

        public MenuTenant(int id, bool statusHalal, string jenis, string namaMenu, int hargaJual, Tenant tenant)
        {
            Id = id;
            StatusHalal = statusHalal;
            Jenis = jenis;
            NamaMenu = namaMenu;
            HargaJual = hargaJual;
            Tenant = tenant;
        }

        public int Id { get => id; set => id = value; }
        public bool StatusHalal { get => statusHalal; set => statusHalal = value; }
        public string Jenis { get => jenis; set => jenis = value; }
        public string NamaMenu { get => namaMenu; set => namaMenu = value; }
        public int HargaJual { get => hargaJual; set => hargaJual = value; }
        public Tenant Tenant { get => tenant; set => tenant = value; }

        public static List<MenuTenant> BacaDataMenu (string filter, string nilai)
        {
            string perintah;
            if (filter == "")
            {
                perintah = "Select * from menu; ";
            }
            else
            {
                perintah = "Select * from menu" +
                   " where " + filter + " like '%" + nilai + "%'";
            }
            MySql.Data.MySqlClient.MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(perintah);
            List<MenuTenant> ListData = new List<MenuTenant>();
            while (hasil.Read())
            {
                MenuTenant m = new MenuTenant(
                    hasil.GetInt32(0),//id
                    hasil.GetBoolean(1),//statusHalal
                    hasil.GetValue(2).ToString(),//jenis
                    hasil.GetValue(5).ToString(),//namaMenu
                    hasil.GetInt32(3),//hargaJual
                    Tenant.BacaData("idTenant", hasil.GetValue(4).ToString())[0]
                    );
                ListData.Add(m);
            }
            return ListData;
        }
    }
}
