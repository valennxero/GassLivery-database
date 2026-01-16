using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backend_lib
{
    public class OrderFood
    {
        private int id;
        private DateTime tanggalOrder;
        private int ongkir;
        private double tip;
        private Driver driver;
        private User konsumen;
        private Waktu waktu;
        private Jarak jarak;
        private bool statusSelesai;
        private List<FoodDetail> listDetail;
        private int totalBiaya;
        private Tenant tenant;

        public OrderFood(int id, DateTime tanggalOrder, int ongkir, double tip, Driver driver, User konsumen, Waktu waktu, Jarak jarak, bool statusSelesai, List<FoodDetail> foodDetails, int pBiaya, Tenant pTenant)
        {
            Id = id;
            TanggalOrder = tanggalOrder;
            Ongkir = ongkir;
            Tip = tip;
            Driver = driver;
            Konsumen = konsumen;
            Waktu = waktu;
            Jarak = jarak;
            StatusSelesai = statusSelesai;
            ListDetail = foodDetails;
            TotalBiaya = pBiaya;
            Tenant = pTenant;
        }

        public int Id { get => id; set => id = value; }
        public DateTime TanggalOrder { get => tanggalOrder; set => tanggalOrder = value; }
        public int Ongkir { get => ongkir; set => ongkir = value; }
        public double Tip { get => tip; set => tip = value; }
        public Driver Driver { get => driver; set => driver = value; }
        public User Konsumen { get => konsumen; set => konsumen = value; }
        public Waktu Waktu { get => waktu; set => waktu = value; }
        public Jarak Jarak { get => jarak; set => jarak = value; }
        public bool StatusSelesai { get => statusSelesai; set => statusSelesai = value; }
        public int TotalBiaya { get => totalBiaya; set => totalBiaya = value; }
        public List<FoodDetail> ListDetail { get => listDetail; set => listDetail = value; }
        public Tenant Tenant { get => tenant; set => tenant = value; }

        public static OrderFood BuatPesanan(DateTime pTglOrder, int pOngkir, double pTip, Driver pDriver, User pUser, Waktu pWaktu, Jarak pJarak, bool statusSelesai, int pTotalBiaya, List<FoodDetail>pListFd, Tenant pTenan)
        {
            string perintah = "insert into orderFood (tanggalOrder, ongkir, tips, driverId, konsumenId, waktuId, jarakId, statusSelesai, totalBiaya, tenantId)" +
                $"values (now(), {pOngkir}, {pTip},{pDriver.Id},{pUser.Id},{pWaktu.Id},{pJarak.Id},false, {pTotalBiaya}, {pTenan.Id});" +
                "select * from orderFood where idOrderFood = last_insert_id();";
            MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(perintah);

            if (hasil.Read())
            {
                OrderFood order = new OrderFood(
                hasil.GetInt32("idOrderFood"),//Id = id;
                hasil.GetDateTime("tanggalOrder"),//TanggalOrder = tanggalOrder;
                hasil.GetInt32("ongkir"),//Ongkir = ongkir;
                hasil.GetDouble("tips"),//Tip = tip;
                pDriver,//Driver = driver;
                pUser,//Konsumen = konsumen;
                pWaktu,//Waktu = waktu;
                pJarak,//Jarak = jarak;
                hasil.GetBoolean("statusSelesai"),//StatusSelesai = statusSelesai;
                pListFd,//ListDetail = foodDetails;
                hasil.GetInt32("totalBiaya"),//TotalBiaya = pBiaya;
                pTenan
                    );
                return order;
            }
            else
            {
                return null;
            }
        }
        
    }
}
