using System;
using System.Linq;
using System.Collections.Generic;

namespace P3_2_1214073
{
    public static class Program
    {
        public static void Main()
        {
            bool start = false;
            do
            {
                Console.WriteLine(" ");
                Console.WriteLine(" Menu");
                Console.WriteLine("1. Hitung luas persegi panjang ");
                Console.WriteLine("2. Hitung keliling Persegi panjang ");
                Console.WriteLine(" ");
                Console.WriteLine(" Menu Pilihan ");
                string opsi = Console.ReadLine();

                Console.WriteLine(" ");
                switch (opsi)
                {
                    case "1":
                        Console.WriteLine(" == Menghitung Luas Persegi Panjang == ");
                        Console.WriteLine(" Luas Persegi panjang adalah Panjang x Lebar ");
                        Console.WriteLine(" == Masukan Panjang Persegi Panjang == ");
                        int panjang = int.Parse(Console.ReadLine());
                        Console.WriteLine(" == Masukan Lebar Persegi Panjang == ");
                        int lebar = int.Parse(Console.ReadLine());
                        int hasil = panjang * lebar;
                        Console.WriteLine(" Luas Persegi Panjang Adalah : " + hasil);
                        break;
                    case "2":
                        Console.WriteLine(" Menghitung keliling persegi panjanh");
                        Console.WriteLine(" Keliling persegi panjang rumusnya 2xpanjang + 2xlebar ");
                        Console.WriteLine(" == Masukan panjang persegi panjang == ");
                        int panjang2 = int.Parse(Console.ReadLine());

                        Console.WriteLine(" == Masukakan Lebar persegi panjang ==  ");
                        int lebar2 = int.Parse(Console.ReadLine());
                        int total = panjang2 * 2 + 2 * lebar2;
                        Console.WriteLine(" Hasil Keliling Persegi Panjang = " + total);
                        break;
                }
                Console.WriteLine("\n\nIngin Mengulangi Kembali? (Y/T)?");
                char c = char.Parse(Console.ReadLine());

                if (c == 'y')
                {
                    start = false;
                }
                else
                {
                    start = true;
                }
                Console.Clear();
            } while (!start);
        }
    }
}
