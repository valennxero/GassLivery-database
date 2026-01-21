using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backend_lib
{
    public class OrderGassSend
    {
        // Fields
        private int idOrderGassSend;
        private DateTime tanggalOrder;
        private User konsumen;
        private Driver driver;
        private Jarak jarak;
        private Waktu waktu;
        private int beratBarang;
        private int totalHarga; // Tambahan untuk menyimpan harga total saat objek dibuat
        private int tip;
        private bool statusSelesai;

        // Constructor
        public OrderGassSend(int id, DateTime tanggal, User konsumen, Driver driver, Jarak jarak, int berat, int harga, int tip, Waktu pWaktu)
        {
            this.IdOrderGassSend = id;
            this.TanggalOrder = tanggal;
            this.Konsumen = konsumen;
            this.Driver = driver;
            this.Jarak = jarak;
            this.BeratBarang = berat;
            this.TotalHarga = harga;
            this.Tip = tip;
            this.StatusSelesai = false;
            this.Waktu = pWaktu;
        }

        // Properties
        public int IdOrderGassSend { get => idOrderGassSend; set => idOrderGassSend = value; }
        public DateTime TanggalOrder { get => tanggalOrder; set => tanggalOrder = value; }
        public User Konsumen { get => konsumen; set => konsumen = value; }
        public Driver Driver { get => driver; set => driver = value; }
        public Jarak Jarak { get => jarak; set => jarak = value; }
        public int BeratBarang { get => beratBarang; set => beratBarang = value; }
        public int TotalHarga { get => totalHarga; set => totalHarga = value; }
        public int Tip { get => tip; set => tip = value; }
        public bool StatusSelesai { get => statusSelesai; set => statusSelesai = value; }
        public Waktu Waktu { get => waktu; set => waktu = value; }


        // METHOD: Buat Pesanan (Insert & Return Object)
        public static OrderGassSend BuatPesanan(User konsumen, Driver driver, Jarak jarak, int berat, int totalHarga, int tip, Waktu pWaktu)
        {
            
            string perintah = "INSERT INTO ordergasssend (tanggalOrder, Konsumen_id, Jarak_idJarak, Waktu_idWaktu,Driver_idDriver, BeratBarang, tip, status, totalHarga) " +
                              $"VALUES (NOW(), {konsumen.Id}, {jarak.Id},{pWaktu.Id}, {driver.Id}, {berat}, {tip}, {false}, {totalHarga}); " +
                              "SELECT * FROM ordergasssend WHERE idOrderGassSend = LAST_INSERT_ID();";

            MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(perintah);

            if (hasil.Read())
            {
                OrderGassSend order = new OrderGassSend(
                    hasil.GetInt32("idOrderGassSend"),
                    hasil.GetDateTime("tanggalOrder"),
                    konsumen,
                    driver,
                    jarak,
                    hasil.GetInt32("BeratBarang"), 
                    totalHarga,
                    hasil.GetInt32("tip"),
                    pWaktu);
                return order;
            }
            else
            {
                return null;
            }
        }

        // METHOD: Baca Data (Select List)
        public static List<OrderGassSend> BacaData(string filter, string nilai)
        {
            string perintah = "";
            if (filter == "Konsumen_id")
            {
                perintah = $"SELECT * FROM ordergasssend WHERE Konsumen_id = {nilai};";
            }
            else if (filter == "idOrderGassSend")
            {
                perintah = $"SELECT * FROM ordergasssend WHERE idOrderGassSend = {nilai};";
            }
            else if (filter == "Driver_idDriver")
            {
                perintah = $"SELECT * FROM ordergasssend WHERE Driver_idDriver = {nilai};";
            }
            else
            {
                perintah = "SELECT * FROM ordergasssend;";
            }

            MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(perintah);
            List<OrderGassSend> listOrder = new List<OrderGassSend>();

            while (hasil.Read())
            {
                int idKonsumen = hasil.GetInt32("Konsumen_id");
                int idDriver = hasil.GetInt32("Driver_idDriver");
                int idJarak = hasil.GetInt32("Jarak_idJarak");
                int berat = hasil.GetInt32("BeratBarang");
                int tip = hasil.GetInt32("tip");
                int estimasiHarga = hasil.GetInt32("totalHarga");
                int waktu = hasil.GetInt32("Waktu_idWaktu");

                OrderGassSend o = new OrderGassSend(
                    hasil.GetInt32("idOrderGassSend"),
                    hasil.GetDateTime("tanggalOrder"),
                    User.BacaData("id", idKonsumen.ToString()),
                    Driver.BacaData("idDriver", idDriver),
                    Jarak.BacaDataJarak(idJarak),
                    berat,
                    estimasiHarga, tip,
                    Waktu.BacaDataWaktu(waktu)
                    
                );

                listOrder.Add(o);
            }
            hasil.Close();
            return listOrder;
        }

        public static void UpdateSelesai(OrderGassSend order)
        {
            string perintah = $"update ordergasssend set status = 1 where idOrderGassSend = {order.IdOrderGassSend};";
            Koneksi.JalankanQuery(perintah);
        }
        public static List<OrderGassSend> Filtered(DateTime startDate, DateTime endDate, List<OrderGassSend> orders)
        {
            List<OrderGassSend> filteredOrders = new List<OrderGassSend>(orders);
            filteredOrders.RemoveAll(od => od.TanggalOrder < startDate || od.TanggalOrder > endDate);
            return filteredOrders;
        }
    }
}