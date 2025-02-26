using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace konversi_mata_uang
{
    internal class Dollar
    {
        private double nilai;
        public double Nilai 
        { 
            get { return nilai; }
            set { nilai = value; } 
        }
        public double convertToRupiah()
        {
            double hasilConvertRupiah = nilai * 15000;
            return hasilConvertRupiah;
        }
        public void tampilkanHasil()
        {
            double hasil = convertToRupiah();
            Console.WriteLine($"Dollar >> $.{nilai}");
            Console.WriteLine($"Rupiah >> Rp.{hasil}");
        }
    }
}
