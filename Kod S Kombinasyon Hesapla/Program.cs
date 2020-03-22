using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kod_S_Kombinasyon_Hesapla
{
    class Program
    {
        static int fakt1(int n)
        {
            if (n == 0)
                return 1;
            else
                return n * fakt1(n - 1);

        }

        static void Main(string[] args)
        {
            int n, r;

            Console.WriteLine("n Değerini Giriniz:");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("r Değerini Giriniz=");
            r = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.Write("C(" + n + "," + r + ")="+fakt1(n) / (fakt1(n - r) * fakt1(r)));

            Console.ReadKey();
        }
    }
}
