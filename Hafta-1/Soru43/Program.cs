using System.Runtime.ConstrainedExecution;

namespace Soru43
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Kullanıcıdan 30 adet tam sayı alarak bir diziye kaydedin.Bu dizideki tek sayıları bir diziye, çift sayıları
            başka bir diziye yerleştirin. Daha sonra her iki diziyi ekrana yazdırın.*/
            Console.WriteLine("30 adet sayı giriniz:");
            int[] sayilar = new int[30];
            for (int i = 0; i < 30; i++)
            {
                Console.Write($"{i+1}. sayı: ");
                sayilar[i] = Convert.ToInt32(Console.ReadLine());
            }
            int cift_uzunluk = 0;
            int tek_uzunluk = 0;
            for (int i = 0;i < sayilar.Length;i++)
            {
                if (sayilar[i] % 2 == 0)
                {
                    cift_uzunluk++;
                }
                if (sayilar[i] % 2 == 1)
                {
                    tek_uzunluk++;
                }
            }
            int[] cift = new int[cift_uzunluk];
            int[] tek = new int[tek_uzunluk];
            int c=0; 
            int t=0;
            for (int i = 0; i < sayilar.Length; i++)
            {
                if (sayilar[i] % 2 == 0)
                {
                    cift[c] = sayilar[i];
                    c++;
                }
                else
                {
                    tek[t] = sayilar[i];
                    t++;
                }
            }
            Console.Write("Çift sayılar: ");
            for (int i = 0; i < cift.Length;i++)
            {
                Console.Write(cift[i] + " ");
            }
            Console.WriteLine();
            Console.Write("Tek sayılar: ");
            for (int i = 0;i < tek.Length;i++)
            {
                Console.Write(tek[i] + " ");
            }
        }
    }
}
