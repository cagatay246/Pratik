using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Limit değerini girin: ");
            int limit = int.Parse(Console.ReadLine()); // Kullanıcıdan limit alınır
            int sayac = 0;

            // do-while döngüsü
            do
            {
                Console.WriteLine("Ben bir Patika'lıyım");
                sayac++;
            }
            while (sayac <= limit);


            Console.WriteLine("----------------------------");


            Console.Write("Limit değerini girin: ");
            int limit1 = int.Parse(Console.ReadLine()); // Kullanıcıdan limit alınır
            int sayac1 = 0;

            // while döngüsü
            while (sayac <= limit)
            {
                Console.WriteLine("Ben bir Patika'lıyım");
                sayac++; 
            }

            // Test sonrası farklar:
            // - while döngüsünde koşul, döngü başlamadan önce kontrol edilir.
            // - Eğer koşul baştan yanlışsa, döngü hiç çalışmaz. Örneğin limit -5 verilirse, hiç yazı yazdırılmaz.














        }
    }
}