using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backend_lib
{
    public class Admin
    {
        private int id;
        private string username;
        private string password;

        public Admin(int id, string username, string password)
        {
            Id = id;
            Username = username;
            Password = password;
        }

        public int Id { get => id; set => id = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }

        public static Admin CekLogin(string uid, string pwd)
        {
            string perintah = "select * from admin " +
                "where username='" + uid + "' and password = '" + pwd + "'";
            MySql.Data.MySqlClient.MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(perintah);
            if (hasil.Read())
            {
                Admin a = new Admin(hasil.GetInt32("id"), hasil.GetString("username"), hasil.GetString("password"));
                hasil.Close();
                return a;
            }
            else
            {
                hasil.Close();
                return null;
            }
        }
    }
}
