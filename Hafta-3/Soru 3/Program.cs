using System.Diagnostics.Metrics;
using System.Runtime.ConstrainedExecution;

namespace Soru_3
{
    internal class Program
    {
        static void ödeme_hesapla(int tutar, out int iki_yuz, out int yuz, out int elli, out int yirmi, out int on, out int bes)
        {
            iki_yuz = tutar / 200;
            tutar %= 200;
            yuz = tutar / 100;
            tutar %= 100;
            elli = tutar / 50;
            tutar %= 50;
            yirmi = tutar / 20;
            tutar %= 20;
            on = tutar / 10;
            tutar %= 10;
            bes = tutar / 5;
            tutar %= 5;
        }

        static void Main(string[] args)
        {
            /*Bir ATM düşünün. Kullanıcı belirli bir miktar para çekmek istiyor. 
            ATM, parayı en az sayıda banknot vererek ödemeye çalışmalıdır.
            out parametresini kullanarak, verilen her banknot türünün adetlerini döndüren bir metot yazın.
            Banknotlar: 200, 100, 50, 20, 10, 5 TL
            Eğer para 5 TL'nin katı değilse, "Bu miktar çekilemez!" mesajı döndürülmelidir.*/

            Console.Write("Çekmek istediğiniz tutarı giriniz:");
            int tutar = Convert.ToInt32(Console.ReadLine());
            if (tutar != 0 && tutar % 5 != 0)
            {
                throw new Exception("Bu miktar çekilemez!");
            }
            ödeme_hesapla(tutar, out int iki_yuz, out int yuz, out int elli, out int yirmi, out int on, out int bes);
            Console.WriteLine("200 TL: " + iki_yuz + "\n100 TL: " + yuz + "\n50 TL: " + elli + "\n20 TL: " + yirmi +
            "\n10 TL: " + on + "5 TL: " + bes);
        }
    }
}
