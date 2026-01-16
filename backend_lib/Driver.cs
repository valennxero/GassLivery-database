using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace backend_lib
{
    public class Driver
    {
        private int id;
        private string nama;
        private string gender;
        private double rating;
        private bool statusAktif;
        private int totalPendapatan;
        private Motor motor;
        private string username;
        private string password;

        public Driver(int id, string nama, string gender, double rating, bool statusAktif, int totalPendapatan, Motor motor)
        {
            Id = id;
            Nama = nama;
            Gender = gender;
            Rating = rating;
            StatusAktif = statusAktif;
            TotalPendapatan = totalPendapatan;
            Motor = motor;

        }
        public Driver()
        {
            Id = 0;
            Nama = "";
            Gender = "";
            Rating = 0;
            StatusAktif = true;
            TotalPendapatan = 0;
            Motor = new Motor();
        }
        public int Id { get => id; set => id = value; }
        public string Nama { get => nama; set => nama = value; }
        public string Gender { get => gender; set => gender = value; }
        public double Rating { get => rating; set => rating = value; }
        public bool StatusAktif { get => statusAktif; set => statusAktif = value; }
        public int TotalPendapatan { get => totalPendapatan; set => totalPendapatan = value; }
        public Motor Motor { get => motor; set => motor = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }

        private static Random rant = new Random();//untuk memanggil driver secara random
        public static Driver PanggilDriver(bool ReqWanita, bool reqMotorBaru)
        {
            string perintah;
            if (ReqWanita)
            {
                //Khusus untuk konsumen Wanita, diijinkan untuk menginputkan permintaan driver harus
                //Wanita juga.
                if (!reqMotorBaru)
                {
                    perintah = "select * from driver where gender = 'female'";
                }
                else
                {
                    perintah = "select * from driver d join motor m on d.motorId = m.idMotor" +
                        " where d.gender = 'Female' and m.usia < 3;";
                }
            }
            else
            { 
                if (reqMotorBaru)
                {
                    //Jika konsumen merasa membutuhkan motor dengan performa baik, maka konsumen
                    //dapat menginputkan permintaan motor baru.Motor baru adalah motor yang berusia
                    //kurang dari 3 tahun.
                    perintah = "select * from driver d join motor m on d.motorId = m.idMotor" +
                        " where m.usia < 3;";
                }
                else
                    perintah = "select * from driver";
            }
            MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(perintah);
            List<Driver> ListData = new List<Driver>();
            while (hasil.Read() == true)
            {
                Driver d = new Driver();
                d.Id = hasil.GetInt32(0);
                d.Nama = hasil.GetValue(1).ToString();
                d.Gender = hasil.GetValue(2).ToString();
                d.Rating = hasil.GetDouble(3);
                d.Motor = Motor.BacaDataMotor(hasil.GetInt32(4));
                d.StatusAktif = hasil.GetBoolean(5);
                d.TotalPendapatan = hasil.GetInt32(6);
                ListData.Add(d);
            }
            //pilih acak driver dari list
            Driver SelectDriver = ListData[rant.Next(ListData.Count)];
            return SelectDriver;
        }

        public static void UangMasuk(double nilaiTip, Driver driver)//20% masuk ke pendapatan driver
        {
            string perintah = $"update driver set totalPendapatan = totalPendapatan + {nilaiTip}" +
                $" where idDriver = {driver.Id};";
            Koneksi.JalankanQuery(perintah);
        }

        public static Driver CekLogin(string uid, string pwd)
        {
            string perintah = "select m.idMotor, m.nama, m.usia, m.platNomor, d.idDriver, d.nama, d.gender, d.ratingTotal, d.statusAktif, d.totalPendapatan," +
                "d.username, d.password " +
                "from driver d join motor m on d.motorId = m.idMotor" +
                " where username='" + uid + "' and password = '" + pwd + "'";
            MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(perintah);
            if (hasil.Read())
            {
                Motor m = new Motor();
                m.Id = hasil.GetInt32(0);
                m.Nama = hasil.GetValue(1).ToString();
                m.Usia = hasil.GetDouble(2);
                m.PlatNomor = hasil.GetValue(3).ToString();
                Driver d = new Driver();
                d.Id = hasil.GetInt32(4);
                d.Nama = hasil.GetValue(5).ToString();
                d.Gender = hasil.GetValue(6).ToString();
                d.Rating = hasil.GetDouble(7);
                d.StatusAktif = hasil.GetBoolean(8);
                d.TotalPendapatan = hasil.GetInt32(9);
                d.Username = hasil.GetValue(10).ToString();
                d.Password =hasil.GetValue(11).ToString();
                d.Motor = m;
                return d;
            }
            else
            {
                return null;
            }
        }
        public static Driver BacaData(int pId)
        {
            string perintah = "select m.idMotor, m.nama, m.usia, m.platNomor, d.idDriver, d.nama, d.gender, d.ratingTotal, d.statusAktif, d.totalPendapatan," +
                "d.username, d.password " +
                "from driver d join motor m on d.motorId = m.idMotor" +
                " where d.IdDriver =" + pId;
            MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(perintah);
            if (hasil.Read())
            {
                Motor m = new Motor();
                m.Id = hasil.GetInt32(0);
                m.Nama = hasil.GetValue(1).ToString();
                m.Usia = hasil.GetDouble(2);
                m.PlatNomor = hasil.GetValue(3).ToString();
                Driver d = new Driver();
                d.Id = hasil.GetInt32(4);
                d.Nama = hasil.GetValue(5).ToString();
                d.Gender = hasil.GetValue(6).ToString();
                d.Rating = hasil.GetDouble(7);
                d.StatusAktif = hasil.GetBoolean(8);
                d.TotalPendapatan = hasil.GetInt32(9);
                d.Username = hasil.GetValue(10).ToString();
                d.Password = hasil.GetValue(11).ToString();
                d.Motor = m;
                hasil.Close();
                return d;
            }
            else
            {
                return null;
            }
        }
    }
}
