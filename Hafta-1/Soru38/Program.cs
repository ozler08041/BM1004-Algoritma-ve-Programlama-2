using System.Runtime.ConstrainedExecution;
using static System.Net.WebRequestMethods;

namespace Soru38
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Bir sayı tahmin oyunu yazın.Program 1 ile 100 arasında rastgele bir sayı üretsin ve kullanıcıdan bu sayıyı
            tahmin etmesini istesin. Kullanıcının tahmini doğru olana kadar program çalışmaya devam etsin.
            Her tahminde program ipucu versin:
            · Eğer tahmin büyükse,"Daha küçük bir sayı girin!"
            · Eğer tahmin küçükse, "Daha büyük bir sayı girin!"
            · Doğru tahminde "Tebrikler! Doğru tahmin ettiniz." mesajını veriniz.*/
            Random rsgl = new Random();
            int dogru_sayi = rsgl.Next(1, 101);
            while (true)
            {
                Console.Write("Bir sayı tahmin ediniz:");
                int tahmin = Convert.ToInt32(Console.ReadLine());
                if (tahmin == dogru_sayi)
                    break;
                else if (tahmin > dogru_sayi)
                {
                    Console.WriteLine("Daha küçük bir sayı girin!");
                }
                else if (tahmin < dogru_sayi)
                {
                    Console.WriteLine("Daha büyük bir sayı girin!");

                }
            }
            Console.WriteLine("Tebrikler! Doğru tahmin ettiniz.");
        }
    }
}
