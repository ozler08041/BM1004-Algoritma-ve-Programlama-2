using System.Data;

namespace Soru42
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Kullanıcıdan 20 adet sayı alarak bir diziye kaydedin. Dizide tekrar eden sayıları ve kaç kez tekrar
            ettiklerini ekrana yazdırın*/
            Console.Write("20 adet sayı giriniz: ");
            int[] sayilar = new int[20];
            for (int i = 0; i < 20; i++)
            {
                sayilar[i] =Convert.ToInt32(Console.ReadLine());
            }
            Console.Clear();
            
            for (int i = 0;i < sayilar.Length;i++)
            {
                int sayac = 0;
                for (int j = 0; j < sayilar.Length; j++)
                {
                    if (sayilar[i] == sayilar[j])
                        sayac++;
                }
                bool daha_once_yazildi = false;
                for (int k = 0; k < i; k++)
                {
                    if (sayilar[i] == sayilar[k])
                    {
                        daha_once_yazildi = true;
                        break;
                    }
                }
                if (!daha_once_yazildi && sayac>1)
                {
                    Console.WriteLine($"Sayı {sayilar[i]} -> {sayac} kez tekrar etti.");
                }
            }
        }
    }
}
