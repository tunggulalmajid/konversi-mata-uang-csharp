using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace konversi_mata_uang
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            header();
            Console.WriteLine("konversi mata uang dari :");
            Console.WriteLine($"1. Dolar\n" + $"2. Rupiah" );
            garis();
            try
            {
                Console.Write("masukkan pilihan >> ");
                int pilihan = Convert.ToInt32(Console.ReadLine());
                if (pilihan == 1)
                {
                    convertDolar();
                }
                else if (pilihan == 2)
                {

                }
                else
                {
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("inputan tidak valid");
            }
            void garis() 
            {
                Console.WriteLine("============================================================");
            }
            void header()
            {
                garis();
                Console.WriteLine("Koverter Mata Uang".PadLeft(37));
                garis();
            }
            void convertDolar()
            {
                Console.Clear();
                header();
                Dollar dolar = new Dollar();
                Console.Write("masukkan nilai uang yang iongin dikonversikan >> ");
                dolar.Nilai = Convert.ToDouble(Console.ReadLine());
                dolar.tampilkanHasil();
                garis();
                Console.WriteLine("apakah ingin convert lagi [y] or [n] >> ");
            } 








            Console.ReadLine();
        }

    }
}
