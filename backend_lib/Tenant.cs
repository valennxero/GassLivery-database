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

        public static Tenant CekLogin(string pUsername, string pPassword)
        {
            string perintah = "select * from tenant " +
                " where username = '" + pUsername + "' " +
                " and password = '" + pPassword + "' ";
            MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(perintah);
            if (hasil.Read())
            {
                Tenant t = new Tenant();
                t.Id = int.Parse(hasil.GetValue(0).ToString());
                t.NamaTenant = hasil.GetValue(1).ToString();
                t.LokasiTenant = Lokasi.BacaDataLokasi(hasil.GetInt32(2));
                t.RatingTenant = hasil.GetDouble(3);
                t.Username = hasil.GetString(4).ToString();
                t.Password = hasil.GetString(5).ToString();
                hasil.Close();
                return t;
            }
            else
            {
                return null;
            }
        }

        public static List<DetailPenjualanMenu> BacaLaporanPenjualan(int pId)
        {
            string perintah = "select date(o.tanggalOrder) as tanggalOrder," +
                "m.nama, sum(n.jumlah) as total_jumlah, n.harga, sum(n.jumlah * n.harga) as subtotal " +
                "from notaFoodDetail n join menu m on n.menuId = m.idMenu " +
                "join tenant t on t.idTenant = m.tenantId " +
                "join orderFood o on o.idOrderFood = n.orderFoodId " +
                $"where t.idTenant = {pId} " +
                "group by date(o.tanggalorder), m.idMenu, m.nama, n.harga " +
                "order by o.tanggalorder;";
            MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(perintah);
            List<DetailPenjualanMenu> laporan = new List<DetailPenjualanMenu>();
            while (hasil.Read())
            {
                DateTime tanggalOrder = hasil.GetDateTime(0);
                string namaMenu = hasil.GetString(1);
                int totalJumlah = hasil.GetInt32(2);
                int hargaSatuan = hasil.GetInt32(3);
                int subtotal = hasil.GetInt32(4);
                DetailPenjualanMenu temp = new DetailPenjualanMenu
                {
                    TanggalOrder = tanggalOrder,
                    NamaMenu = namaMenu,
                    TotalJumlah = totalJumlah,
                    HargaSatuan = hargaSatuan,
                    Subtotal = subtotal
                };
                laporan.Add(temp);
            }
            hasil.Close();
            return laporan;
        }
    }
}
