using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace backend_lib
{
    public class Gassmon
    {
        private int id;
        private int saldo;
        private int poin;

        public Gassmon(int id, int saldo, int poin)
        {
            this.Id = id;
            this.Saldo = saldo;
            this.Poin = poin;
        }

        public Gassmon()
        {
            this.Id = 0;
            this.Saldo = 0;
            this.Poin = 0;
        }
        public int Id { get => id; set => id = value; }
        public int Saldo { get => saldo; set => saldo = value; }
        public int Poin { get => poin; set => poin = value; }


        public static Gassmon BacaData(User pUser)
        {
            string perintah = $"Select * from `gass-mon` where id = {pUser.Id}; ";
            MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(perintah);
            if (hasil.Read())
            {
                Gassmon g = new Gassmon(hasil.GetInt32(0), hasil.GetInt32(1), hasil.GetInt32(2));
                return g;
            }
            else
            {
                return null;
            }
        }
        public static void BayarPakaiSaldo(int harga, User akun)
        {
            string perintah = "update `gass-mon` set saldo = saldo - " + harga +
                " where id = " + akun.IdGassmon.Id;
            MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(perintah);

            while (hasil.Read())
            {
                akun.IdGassmon.Saldo = akun.IdGassmon.Saldo - harga;
            }
        }

        public static void BayarPakaiPoin(int harga, User akun)
        {
            string perintah = "update `gass-mon` set poin = poin - " + harga +
                " where id = " + akun.IdGassmon.Id;
            MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(perintah);

            while (hasil.Read())
            {
                akun.IdGassmon.Poin = akun.IdGassmon.Poin - harga;
            }
        }

        public static void TambahPoin(int poin, User akun)
        {
            string perintah = "update `gass-mon` set poin = poin + " + poin +
                " where id = " + akun.IdGassmon.Id;
            MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(perintah);
        }

        public static void Bayar(bool pPoin, int biaya, int sisaPoin, int sisaSaldo, User pUserLogin)
        {
            if (pPoin)
            {
                //logic pakai poin, kurangi biaya sesuai poin yang ada dengan kelipatan 5000
                int maxPotongan = biaya - (biaya % 5000);
                int poinTersedia = sisaPoin - (sisaPoin % 5000);
                int poinDipakai = Math.Min(maxPotongan, poinTersedia);
                if (poinDipakai < 5000)
                {
                    poinDipakai = 0;
                }

                if ((biaya - poinDipakai) <= sisaSaldo)
                {
                    //Bayar
                    //kurangi poin pada database
                    Gassmon.BayarPakaiPoin(poinDipakai, pUserLogin);
                    //kurangi saldo pada database
                    Gassmon.BayarPakaiSaldo(biaya - poinDipakai, pUserLogin);
                }
            }
            else
            {
                if (biaya <= sisaSaldo && biaya > sisaPoin || biaya <= sisaSaldo && biaya <= sisaPoin)
                {
                    Gassmon.BayarPakaiSaldo(biaya, pUserLogin);
                }
                else
                {
                    Gassmon.BayarPakaiPoin(biaya, pUserLogin);
                }
            }
        }
    }
}
