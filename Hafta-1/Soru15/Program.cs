namespace Soru15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcıdan üç basamaklı bir sayı alıp, rakamlarını büyükten küçüğe sıralayan bir program yazınız.
            Console.Write("Üç basamaklı bir sayı giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            if (sayi< 100 || sayi > 999)
            {
                Console.WriteLine("Lütfen üç basamaklı bir sayı giriniz.");
                return;
            }
            int b = sayi % 10;
            int o = (sayi / 10) % 10;
            int y = sayi / 100;
            if (y > o && y > b)
            {
                if (o > b)
                {
                    Console.WriteLine($"Büyükten küçüğe sıralama: {y} {o} {b}");
                }
                else
                {
                    Console.WriteLine($"Büyükten küçüğe sıralama: {y} {b} {o}");
                }
            }
            else if (o > y && o > b)
            {
                if (y > b)
                {
                    Console.WriteLine($"Büyükten küçüğe sıralama: {o} {y} {b}");
                }
                else
                {
                    Console.WriteLine($"Büyükten küçüğe sıralama: {o} {b} {y}");
                }
            }
            else
            {
                if (y > o)
                {
                    Console.WriteLine($"Büyükten küçüğe sıralama: {b} {y} {o}");
                }
                else
                {
                    Console.WriteLine($"Büyükten küçüğe sıralama: {b} {o} {y}");
                }
            }
            }
    }
}
