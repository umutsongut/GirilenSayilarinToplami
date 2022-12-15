using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GirilenSayilarinToplami
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            int toplam = 0;
            int deneme = 0;

            while (x > 0)
            {
                Console.Write("Bir Sayı Giriniz----> ");
                x = Convert.ToInt32(Console.ReadLine());

                toplam += x;
                deneme++;

                Console.WriteLine($"{deneme}.Denemede Girilen Sayıların Toplamı---> {toplam}\n");
            }

            Console.Read();
        }
    }
}
