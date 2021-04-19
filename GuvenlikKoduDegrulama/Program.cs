using System;

namespace _09MetotOdev_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string guvenlikKodu;
            guvenlikKodu = KodOlustur();

            Console.WriteLine((string)guvenlikKodu);
            Console.WriteLine("\n");


            bool flag = KodGirilsin(guvenlikKodu);

            while (flag == false)
            {
                guvenlikKodu = KodOlustur();
                Console.WriteLine((string)guvenlikKodu);
                Console.WriteLine("\n");
                flag = KodGirilsin(guvenlikKodu);
            }

            Console.ReadKey();
        }

        private static bool KodGirilsin(string guvenlikKodu)
        {
            string girilenKod;
            Console.WriteLine("Lutfen Guvenlik Kodunu Giriniz : ");
            girilenKod = Console.ReadLine();

            if (girilenKod == guvenlikKodu)
            {
                Console.WriteLine("Tebrikler. Guvenlik Kodunu Dogru Girdiniz.");
                return true;
            }
            else
            {
                Console.WriteLine("!!! Hatalı Kod Girdiniz !!!");
                return false;
            }
        }

        private static string KodOlustur()
        {
            string karakterler = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var guvenlikKodu = new char[4];
            var rnd = new Random();

            for (int i = 0; i < guvenlikKodu.Length; i++)
            {
                guvenlikKodu[i] = karakterler[rnd.Next(karakterler.Length)];
            }
            var finalString = new String(guvenlikKodu);
            return finalString;
        }
    }
}
