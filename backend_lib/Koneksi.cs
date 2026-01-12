using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backend_lib
{
    public class Koneksi
    {
        private MySqlConnection koneksiDB;
        public void Connect()
        {
            if (koneksiDB.State == System.Data.ConnectionState.Open)
            {
                koneksiDB.Close();
            }
            koneksiDB.Open();
        }

        public Koneksi(string pS, string pD, string pU, string pP)
        {
            string conString = "Server =" + pS + ";Database=" + pD + ";Uid=" + pU + ";Pwd=" + pP + ";";
            koneksiDB = new MySqlConnection();
            koneksiDB.ConnectionString = conString;
            Connect();
        }

        public Koneksi()
        {
            Configuration myConf = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            
            ConfigurationSectionGroup userSettings = myConf.SectionGroups["userSettings"];
          
            var settingsSection = userSettings.Sections["GassLivery_Kelompok7.db"] as ClientSettingsSection;

            string DbServer = settingsSection.Settings.Get("DBServer").Value.ValueXml.InnerText;
            string DbName = settingsSection.Settings.Get("DBName").Value.ValueXml.InnerText;
            string DbUsername = settingsSection.Settings.Get("DBUsername").Value.ValueXml.InnerText;
            string DbPassword = settingsSection.Settings.Get("DBPassword").Value.ValueXml.InnerText;

            string conString = "server=" + DbServer + ";database=" + DbName + ";uid=" + DbUsername
                + ";password=" + DbPassword + ";";
            koneksiDB = new MySqlConnection();
            koneksiDB.ConnectionString = conString;
            Connect();

        }

        public static MySqlDataReader JalankanPerintahSelect(string perintah)
        {
            Koneksi k = new Koneksi();
            MySqlCommand cmd = new MySqlCommand(perintah, k.koneksiDB);
            MySqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }

        public static void JalankanQuery(string p)
        {
            Koneksi kon = new Koneksi();
            MySqlCommand cmd = new MySqlCommand(p, kon.koneksiDB);
            cmd.ExecuteNonQuery();
        }
    }
}
