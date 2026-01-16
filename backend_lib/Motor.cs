using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backend_lib
{
    public class Motor
    {
        private int id;
        private string nama;
        private double usia;
        private string platNomor;

        public Motor(int id, string nama, double usia, string platNomor)
        {
            this.Id = id;
            this.Nama = nama;
            this.Usia = usia;
            this.PlatNomor = platNomor;
        }

        public Motor()
        {
            this.Id = 0;
            this.Nama = "";
            this.Usia = 0;
            this.PlatNomor = "";
        }
        public int Id { get => id; set => id = value; }
        public string Nama { get => nama; set => nama = value; }
        public double Usia { get => usia; set => usia = value; }
        public string PlatNomor { get => platNomor; set => platNomor = value; }

        public static Motor BacaDataMotor(int pId)
        {
            string perintah = "select * from motor where idMotor = " + pId;
            MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(perintah);
            if (hasil.Read())
            {
                Motor m = new Motor();
                m.Id = hasil.GetInt32(0);
                m.Nama = hasil.GetValue(1).ToString();
                m.Usia = hasil.GetInt32(2);
                m.PlatNomor = hasil.GetValue(4).ToString();
                hasil.Close();
                return m;
            }
            else
            {
                return null;
            }
        }
    }
}
