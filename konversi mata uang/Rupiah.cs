using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace konversi_mata_uang
{
    internal class Rupiah
    {
        private double nilai;
        public double Nilai
        {
            get { return nilai; }
            set { nilai = value; }
        }
        public double convertToDolar()
        {
            double hasilConvertDolar = nilai / 15000;
            return hasilConvertDolar;
        }
        public void tampilkanHasil()
        {
            double hasil = convertToDolar();
            Console.WriteLine($"Rupiah >> Rp.{nilai}");
            Console.WriteLine($"Dollar >> $.{hasil}");
        }
    }
}
