using System.Reflection.Metadata;

namespace Soru_2
{
    internal class Program
    {
        static void buyuk_kucuk_deger_bul(int[] dizi , out int kucuk , out int buyuk)
        {
                kucuk = dizi[0];
                buyuk = dizi[0];
    
                for (int i = 1; i < dizi.Length; i++)
                {
                    if (dizi[i] < kucuk)
                    {
                        kucuk = dizi[i];
                    }
                    if (dizi[i] > buyuk)
                    {
                        buyuk = dizi[i];
                    }
            }
        }
        static void Main(string[] args)
        {
            /*Bir diziyi parametre olarak alan ve out parametrelerini kullanarak
            dizinin en büyük ve en küçük elemanlarını bulan bir metot yazınız.*/

            int[] dizi = { 5, 2, 9, 1, 5, 6 };
            buyuk_kucuk_deger_bul(dizi, out int kucuk, out int buyuk);
            Console.WriteLine("Büyük değer: " + buyuk);
            Console.WriteLine("Küçük değer: " + kucuk);
        }
    }
}
