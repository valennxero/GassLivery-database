using backend_lib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GassLivery_Kelompok7
{
    public partial class FormDriver : Form
    {
        public FormDriver()
        {
            InitializeComponent();
        }
        public Driver driverLogin;

        int kelipatan = 10000;
        int pendapatan;
        private void FormDriver_Load(object sender, EventArgs e)
        {
            try
            {
                Koneksi k = new Koneksi();
                MessageBox.Show("Koneksi berhasil");
                labelNamaDriver.Text = driverLogin.Nama;
                labelPendapatan.Text = driverLogin.TotalPendapatan.ToString();
                //Driver dapat menarik dana setiap akhir minggu, dengan kelipatan Rp 10.000
                numericUpDownNominal.Increment = kelipatan;
                numericUpDownNominal.Maximum = driverLogin.TotalPendapatan;
                pendapatan = driverLogin.TotalPendapatan;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Koneksi gagal : " + ex.Message);
            }
        }
        decimal newValue;
        private void numericUpDownNominal_ValueChanged(object sender, EventArgs e)
        {
            //atur supaya hanya bisa input kelipatan 10rb dan maksimal adalah total pendapatan
            decimal value = numericUpDownNominal.Value;
            //bulatkan value
            newValue = Math.Floor(value / kelipatan) * kelipatan;

            if (newValue > numericUpDownNominal.Maximum)
                newValue = numericUpDownNominal.Maximum;

            if (numericUpDownNominal.Value != newValue)
                numericUpDownNominal.Value = newValue;
        }

        private void buttonTarik_Click(object sender, EventArgs e)
        {
            //update ke database
            if(DateTime.Now.DayOfWeek != DayOfWeek.Sunday)
            {
                PenarikanDana PenarikanDana = new PenarikanDana(0, (int)newValue, DateTime.Now, driverLogin);
                PenarikanDana.TarikDana(PenarikanDana);
                MessageBox.Show("Penarikan dana berhasil dengan nominal Rp " + newValue);
                //update label pendapatan
                driverLogin =  Driver.BacaData(driverLogin);
                labelPendapatan.Text = driverLogin.TotalPendapatan.ToString();
            }
            else
            {
                MessageBox.Show("Penarikan dana hanya dapat dilakukan pada hari Minggu");
            }
        }
    }
}
