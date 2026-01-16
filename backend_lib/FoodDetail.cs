using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backend_lib
{
    public class FoodDetail
    {
        private int harga;
        private int jumlah;
        private MenuTenant menu;

        public FoodDetail(int harga, int jumlah, MenuTenant menu)
        {
            Harga = harga;
            Jumlah = jumlah;
            Menu = menu;
        }

        public FoodDetail()
        {
            Harga = 0;
            Jumlah = 0;
            Menu = null;
        }

        public int Harga { get => harga; set => harga = value; }
        public int Jumlah { get => jumlah; set => jumlah = value; }
        public MenuTenant Menu { get => menu; set => menu = value; }
    }
}
