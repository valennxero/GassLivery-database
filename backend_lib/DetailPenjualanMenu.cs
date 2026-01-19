using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backend_lib
{
    public class DetailPenjualanMenu
    {
        private DateTime tanggalOrder;
        private string namaMenu;
        private int totalJumlah;
        private int hargaSatuan;
        private int subtotal;

        public DetailPenjualanMenu(DateTime tanggalOrder, string namaMenu, int totalJumlah, int hargaSatuan, int subtotal)
        {
            TanggalOrder = tanggalOrder;
            NamaMenu = namaMenu;
            TotalJumlah = totalJumlah;
            HargaSatuan = hargaSatuan;
            Subtotal = subtotal;
        }
        public DetailPenjualanMenu()
        {
            TanggalOrder = DateTime.MinValue;
            NamaMenu = "";
            TotalJumlah = 0;
            HargaSatuan = 0;
            Subtotal = 0;
        }
        public DateTime TanggalOrder { get => tanggalOrder; set => tanggalOrder = value; }
        public string NamaMenu { get => namaMenu; set => namaMenu = value; }
        public int TotalJumlah { get => totalJumlah; set => totalJumlah = value; }
        public int HargaSatuan { get => hargaSatuan; set => hargaSatuan = value; }
        public int Subtotal { get => subtotal; set => subtotal = value; }

        public static List<DetailPenjualanMenu> FilterByDate(DateTime startDate, DateTime endDate, List<DetailPenjualanMenu> listDetail)
        {
            List<DetailPenjualanMenu> filtered = new List<DetailPenjualanMenu>(listDetail);
            filtered.RemoveAll(f => f.TanggalOrder < startDate || f.TanggalOrder > endDate);
            return filtered;
        }
    }

}
