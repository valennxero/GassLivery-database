using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
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
    }
}
