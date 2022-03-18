using System;

namespace projek_kalkulator_sederhana
{
    class Program
    {
        static void Main(string[] args)
        {


            int angka1 = 0;
            int angka2 = 0;
            int total = 0;

            Console.WriteLine("=====================");
            Console.WriteLine(" Aplikasi Kalkulator ");
            Console.WriteLine("=====================");
            Console.WriteLine("\n");
            Console.WriteLine("List Opsi Kalkulator :");

            Console.WriteLine("1. Penambahan  (+)");
            Console.WriteLine("2. Pengurangan (-)");
            Console.WriteLine("3. Perkalian   (*)");
            Console.WriteLine("4. pembagian   (/)");
            Console.WriteLine("\n");

            Console.WriteLine("Masukan Angka Pertama");
            angka1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Masukan Angka Kedua");
            angka2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\t");

            Console.WriteLine("Masukan Operator : ");
            switch (Console.ReadLine())
            {
                case "1":
                    total = angka1 + angka2;
                    Console.WriteLine("\nHasil = " + total);
                    break;
                case "2":
                    total = angka1 - angka2;
                    Console.WriteLine("\nHasil = " + total);
                    break;
                case "3":
                    total = angka1 * angka2;
                    Console.WriteLine("\nHasil = " + total);
                    break;
                case "4":
                    double totalbagi = (double)angka1 / angka2;
                    Console.WriteLine("\nHasil = " + totalbagi);
                    break;       
            }

            Console.WriteLine("\nTekan Sembarang Key Untuk Keluar");
            Console.ReadKey();
        }
       
    }

}
