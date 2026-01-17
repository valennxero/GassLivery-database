using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backend_lib
{
    public class TopUp
    {
        private DateTime tanggalTopUp;
        private int jumlahTopUp;
        private Gassmon akunGassmon;
        public TopUp(DateTime tanggalTopUp, int jumlahTopUp, Gassmon gassmon)
        {
            this.TanggalTopUp = tanggalTopUp;
            this.JumlahTopUp = jumlahTopUp;
            this.AkunGassmon = akunGassmon;
        }
        public DateTime TanggalTopUp { get => tanggalTopUp; set => tanggalTopUp = value; }
        public int JumlahTopUp { get => jumlahTopUp; set => jumlahTopUp = value; }
        public Gassmon AkunGassmon { get => akunGassmon; set => akunGassmon = value; }

        public static void IsiSaldo(User pUser, int pNominal)
        {
            string perintah = "insert into topup (konsumenId, gassmonId, nominal, tanggal) " +
                $"values ({pUser.Id}, {pUser.IdGassmon.Id}, {pNominal}, now());"+
                $"update `gass-mon` set saldo = saldo + {pNominal} where id = {pUser.IdGassmon.Id}; ";
            Koneksi.JalankanQuery(perintah);
        }

        public static List<TopUp> BacaData(User pUser)
        {
            string perintah = $"Select * from topup where konsumenId = {pUser.Id};";
            MySql.Data.MySqlClient.MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(perintah);
            List<TopUp> ListData = new List<TopUp>();
            while (hasil.Read())
            {
                Gassmon gassmon = Gassmon.BacaData(pUser);
                TopUp t = new TopUp(hasil.GetDateTime("tanggal"), hasil.GetInt32("nominal"), gassmon);
                ListData.Add(t);
            }
            hasil.Close();
            return ListData;
        }
    }
}
