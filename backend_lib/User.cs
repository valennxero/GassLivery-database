using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backend_lib
{
    public class User
    {
        private int id;
        private string gender;
        private string noHp;
        private string nama;
        private string username;
        private string password;
        private Gassmon idGassmon;

        public User(int id, string pgender, string noHp, string nama, string username, string password, Gassmon idGassmon)
        {
            this.id = id;
            this.gender = pgender;
            this.noHp = noHp;
            this.nama = nama;
            this.username = username;
            this.password = password;
            this.idGassmon = idGassmon;
        }

        public User()
        {
            this.Id = 0;
            this.Gender = "";
            this.NoHp = "";
            this.Nama = "";
            this.Username = "";
            this.Password = "";
            this.IdGassmon = new Gassmon();
        }

        public int Id { get => id; set => id = value; }
        public string Gender { get => gender; set => gender = value; }
        public string NoHp { get => noHp; set => noHp = value; }
        public string Nama { get => nama; set => nama = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public Gassmon IdGassmon { get => idGassmon; set => idGassmon = value; }

        public static User CekLogin(string uid, string pwd)
        {
            string perintah = "select k.id, k.gender, k.nama, k.username, k.`password`, g.id, g.saldo, g.poin "+
                "from konsumen k join `gass-mon` g on k.idGassmon = g.id" +
                " where username='" + uid + "' and password = '" + pwd + "'";
            MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(perintah);
            if (hasil.Read())
            {
                Gassmon g = new Gassmon();
                g.Id = hasil.GetInt32(5);
                g.Saldo = hasil.GetInt32(6);
                g.Poin = hasil.GetInt32(7);
                User u = new User();
                u.Id = hasil.GetInt32(0);
                u.Gender = hasil.GetValue(1).ToString();
                u.Nama = hasil.GetValue(2).ToString();
                u.Username = hasil.GetValue(3).ToString();
                u.Password = hasil.GetValue(4).ToString();
                u.IdGassmon = g;
                return u;
            }
            else
            {
                return null;
            }
        }

        public static User BacaData(string uid)
        {
            string perintah = "select k.id, k.gender, k.nama, k.username, k.`password`, g.id, g.saldo, g.poin " +
                "from konsumen k join `gass-mon` g on k.idGassmon = g.id" +
                " where username='" + uid + "';";
            MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(perintah);
            if (hasil.Read())
            {
                Gassmon g = new Gassmon();
                g.Id = hasil.GetInt32(5);
                g.Saldo = hasil.GetInt32(6);
                g.Poin = hasil.GetInt32(7);
                User u = new User();
                u.Id = hasil.GetInt32(0);
                u.Gender = hasil.GetValue(1).ToString();
                u.Nama = hasil.GetValue(2).ToString();
                u.Username = hasil.GetValue(3).ToString();
                u.Password = hasil.GetValue(4).ToString();
                u.IdGassmon = g;
                return u;
            }
            else
            {
                return null;
            }
        }
        public static void CreateUser(string username, string pwd, string name, string gender, string noHP)
        {
            string perintah =
                "INSERT INTO `gass-mon` (poin, saldo) VALUES (0, 0); " +
                "INSERT INTO konsumen (nama, gender, username, password, nomorHP, idGassmon) " +
                "VALUES ('" + name + "', '" + gender + "', '" + username + "', '" + pwd + "', '" + noHP + "', LAST_INSERT_ID());";

            Koneksi.JalankanQuery(perintah);
        }

    }
}
