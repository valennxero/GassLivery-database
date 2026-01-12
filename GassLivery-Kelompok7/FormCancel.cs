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
    public partial class FormCancel : Form
    {
        Cancel cancel;
        public FormCancel(Cancel pCancel)
        {
            InitializeComponent();
            cancel = pCancel;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBoxAlasan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxAlasan.Text == "Lainnya")
            {
                textBoxAlasan.Visible = true;
            }
            else
            {
                textBoxAlasan.Visible = false;
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            try
            {
                cancel.Alasan = comboBoxAlasan.Text;
                if (textBoxAlasan.Visible && textBoxAlasan != null)
                {
                    cancel.Alasan = textBoxAlasan.Text;
                }
                
                Cancel.CancelOrder(cancel);

                //kembalikan dana ke user
                int dana = cancel.Pesanan.TotalTransaksi;
                User user = cancel.Konsumen;
                OrderRide.RefundDana(dana, user);
                MessageBox.Show("Pembatalan Berhasil");
                this.Close();
                this.Owner.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormCancel_Load(object sender, EventArgs e)
        {

        }
    }
}
