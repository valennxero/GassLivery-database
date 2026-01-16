using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backend_lib
{
    public class OrderRide
    {
        private int id;
        private double tip;
        private DateTime tanggalOrder;
        private User konsumen;
        private Driver driver;
        private Waktu waktu;
        private Jarak jarak;
        private bool reqWanita;
        private bool reqMotorBaru;
        private DateTime jadwalOrder;
        private bool statusSelesai;
        private int totalTransaksi;
        
        public OrderRide(int id, double tip, User konsumen, Driver driver, Waktu waktu, Jarak jarak, bool reqWanita, bool reqMotorBaru, DateTime jadwalOrder, bool statusSelesai, int totalTransaksi)
        {
            this.Id =id;
            this.Tip = tip;
            this.TanggalOrder = DateTime.Now;
            this.Konsumen = konsumen;
            this.Driver = driver;
            this.Waktu = waktu;
            this.Jarak = jarak;
            this.ReqWanita = reqWanita;
            this.ReqMotorBaru = reqMotorBaru;
            this.JadwalOrder = jadwalOrder;
            this.StatusSelesai = false;
            this.TotalTransaksi = totalTransaksi;
        }

        public int Id { get => id; set => id = value; }
        public double Tip { get => tip; set => tip = value; }
        public DateTime TanggalOrder { get => tanggalOrder; set => tanggalOrder = value; }
        public User Konsumen { get => konsumen; set => konsumen = value; }
        public Driver Driver { get => driver; set => driver = value; }
        public Waktu Waktu { get => waktu; set => waktu = value; }
        public Jarak Jarak { get => jarak; set => jarak = value; }
        public bool ReqWanita { get => reqWanita; set => reqWanita = value; }
        public bool ReqMotorBaru { get => reqMotorBaru; set => reqMotorBaru = value; }
        public DateTime JadwalOrder { get => jadwalOrder; set => jadwalOrder = value; }
        public bool StatusSelesai { get => statusSelesai; set => statusSelesai = value; }
        public int TotalTransaksi { get => totalTransaksi; set => totalTransaksi = value; }

        public static OrderRide BuatPesanan(double tip, User konsumen, Driver driver, Waktu waktu, Jarak jarak, bool reqWanita, bool reqMotorBaru, DateTime postOrder, int totalTransaksi)
        {
            if (postOrder < DateTime.Now)
            {
                // konsumen dapat menentukan ingin dijemput saat ini juga, atau di waktu lain
                // maksimal 24 jam dari saat ini
                postOrder = postOrder.AddDays(1);
            }
            string perintah = "insert into orderride (tips, tanggalOrder, konsumenId, driverId, waktuId, jarakId, reqWanita, reqMotorBaru,postOrder, statusSelesai, totalTransaksi)" +
                $"values ({tip}, now(), {konsumen.Id}, {driver.Id}, {waktu.Id}, {jarak.Id}, {reqWanita}, {reqMotorBaru}, '{postOrder:yyyy-MM-dd HH:mm:ss}', false, {totalTransaksi});" +
                "select * from orderride where idOrderRide = last_insert_id();";
            MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(perintah);

            if (hasil.Read())
            {
                OrderRide order = new OrderRide(
                    hasil.GetInt32("idOrderRide"),//id
                    tip,//tip
                    konsumen,//userId
                    driver,//driver
                    waktu,//waktu
                    jarak,//jarak
                    reqWanita,//reqWanita
                    reqMotorBaru,//reqMotor
                    postOrder,//jadwalOrder
                    false,//statusSelesai
                    totalTransaksi);//totalTransaksi
                return order;
            }
            else
            {
                return null;
            }
        }
        public static void UpdateSelesai(OrderRide order)
        {
            string perintah = $"update orderride set statusSelesai = 1 where idOrderRide = {order.Id};";
            Koneksi.JalankanQuery(perintah);
        }
        public static void RefundDana(int nilai, User user)
        {
            string perintah = $"update `gass-mon` set saldo = saldo + {nilai} where id = {user.IdGassmon.Id}; ";
            Koneksi.JalankanQuery(perintah);
        }

        public static List<OrderRide> BacaData(User pUser)
        {
            string perintah = $"select * from orderRide where konsumenId = {pUser.Id};";
            MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(perintah);

            List<OrderRide> listOrder = new List<OrderRide>();

            // TEMPORARY STORAGE
            List<(int idOrder, double tips, int driverId, int waktuId, int jarakId,
                  bool reqWanita, bool reqMotorBaru, DateTime postOrder,
                  bool statusSelesai, int totalTransaksi, DateTime tanggalOrder)> temp
                = new List<(int, double, int, int, int, bool, bool, DateTime, bool, int, DateTime)>();

            while (hasil.Read())
            {
                temp.Add((
                    hasil.GetInt32("idOrderRide"),
                    hasil.GetDouble("tips"),
                    hasil.GetInt32("driverId"),
                    hasil.GetInt32("waktuId"),
                    hasil.GetInt32("jarakId"),
                    hasil.GetBoolean("reqWanita"),
                    hasil.GetBoolean("reqMotorBaru"),
                    hasil.GetDateTime("postOrder"),
                    hasil.GetBoolean("statusSelesai"),
                    hasil.GetInt32("totalTransaksi"),
                    hasil.GetDateTime("tanggalOrder")
                ));
            }

            hasil.Close();

            foreach (var t in temp)
            {
                OrderRide o = new OrderRide(
                    t.idOrder,
                    t.tips,
                    pUser,
                    Driver.BacaData(t.driverId),
                    Waktu.BacaDataWaktu(t.waktuId),
                    Jarak.BacaDataJarak(t.jarakId),
                    t.reqWanita,
                    t.reqMotorBaru,
                    t.postOrder,
                    t.statusSelesai,
                    t.totalTransaksi
                );
                o.TanggalOrder = t.tanggalOrder;
                listOrder.Add(o);
            }

            return listOrder;
        }
        public static OrderRide BacaDataById(int pId)
        {
            string sql = $"select * from orderride where idOrderRide = {pId}";
            MySqlDataReader dr = Koneksi.JalankanPerintahSelect(sql);

            // Variabel penampung data mentah
            int idOrder = 0;
            double tips = 0;
            int konsumenId = 0;
            int driverId = 0;
            int waktuId = 0;
            int jarakId = 0;
            bool reqWanita = false;
            bool reqMotorBaru = false;
            DateTime postOrder = DateTime.MinValue;
            bool statusSelesai = false;
            int totalTransaksi = 0;
            DateTime tanggalOrder = DateTime.MinValue;

            bool adaData = false;

            if (dr.Read())
            {
                adaData = true;

                idOrder = dr.GetInt32("idOrderRide");
                tips = dr.GetDouble("tips");
                konsumenId = dr.GetInt32("konsumenId");
                driverId = dr.GetInt32("driverId");
                waktuId = dr.GetInt32("waktuId");
                jarakId = dr.GetInt32("jarakId");
                reqWanita = dr.GetBoolean("reqWanita");
                reqMotorBaru = dr.GetBoolean("reqMotorBaru");
                postOrder = dr.GetDateTime("postOrder");
                statusSelesai = dr.GetBoolean("statusSelesai");
                totalTransaksi = dr.GetInt32("totalTransaksi");
                tanggalOrder = dr.GetDateTime("tanggalOrder");
            }

            // 🔥 WAJIB: tutup reader SEBELUM query lain
            dr.Close();

            if (!adaData)
                return null;

            // Baru aman panggil method BacaData lain
            User konsumen = User.BacaData(konsumenId);
            Driver driver = Driver.BacaData(driverId);
            Waktu waktu = Waktu.BacaDataWaktu(waktuId);
            Jarak jarak = Jarak.BacaDataJarak(jarakId);

            OrderRide order = new OrderRide(
                idOrder,
                tips,
                konsumen,
                driver,
                waktu,
                jarak,
                reqWanita,
                reqMotorBaru,
                postOrder,
                statusSelesai,
                totalTransaksi
            );

            order.TanggalOrder = tanggalOrder;

            return order;
        }
    }
}
