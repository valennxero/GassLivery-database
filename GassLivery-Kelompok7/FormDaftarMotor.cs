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
    public partial class FormDaftarMotor : Form
    {
        public FormDaftarMotor()
        {
            InitializeComponent();
        }

        private void FormDaftarMotor_Load(object sender, EventArgs e)
        {
            List<Motor> listMotor = Motor.BacaDataMotor(0);
            if(listMotor.Count == 0)
            {
                MessageBox.Show("Data motor tidak ditemukan.", "Peringatan");
                return;
            }
            for (int i = 0; i < listMotor.Count; i++)
            {
                int idMotor = listMotor[i].Id;
                string namaMotor = listMotor[i].Nama;
                Driver driverMotor = Driver.BacaData("motorId", idMotor);
                string namaOwner = driverMotor.Nama;
                int idOwner = driverMotor.Id;
                double usiaMotor = listMotor[i].Usia;
                string platNomor = listMotor[i].PlatNomor;
                dataGridViewMotor.Rows.Add(idMotor, namaMotor, namaOwner, idOwner, usiaMotor, platNomor);
            }
        }

        private void dataGridViewMotor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int idx = dataGridViewMotor.CurrentRow.Index;
            if (e.ColumnIndex == dataGridViewMotor.Columns["Nonaktif"].Index)
            {
                int idDriver = (int)dataGridViewMotor.Rows[idx].Cells[3].Value;
                Driver driver = Driver.BacaData("idDriver", idDriver);
                //nonaktifkan driver
                if (driver.Motor.Usia > 10)
                {
                    Driver.NonaktifkanDriver(driver);
                }
                else
                {
                    MessageBox.Show("Motor belum memenuhi syarat untuk dinonaktifkan (usia motor kurang dari 10 tahun).", "Peringatan");
                }
            }
        }
    }
}
