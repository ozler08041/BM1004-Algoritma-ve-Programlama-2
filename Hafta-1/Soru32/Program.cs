namespace Soru32
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcıdan sürekli olarak sayı alıp, bu sayının en küçük asal çarpanını bulan bir program yazınız.
            while (true)
            {
                Console.Write("Sayı: ");
                int sayi = Convert.ToInt32(Console.ReadLine());
                if (sayi < 2)
                {
                    Console.WriteLine("Lütfen 2 veya daha büyük bir sayı giriniz.");
                    continue;
                }
                for (int i = 2; i < sayi; i++)
                {
                    if (sayi % i == 0)
                    {
                        Console.WriteLine("En küçük asal çarpan: " + i);
                        break;
                    }
                }
            }
        }
    }
}
