using System.Diagnostics.Metrics;
using System.Reflection.Metadata;

namespace Soru46
{
    internal class Program
    {
        static string mesaj_yaz(string a , int y)
        {
            string mesaj = $"Merhaba {a}, sen {y} yaşındasın.";
            return mesaj ;
        }
        static void Main(string[] args)
        {
            /*Geriye değer döndüren ve hem string hem de int parametre alan bir metot yazın.
            Parametre olarak bir isim(string) ve bir yaş(int) alsın.
            "Merhaba [isim], sen [yaş] yaşındasın." şeklinde bir cümle oluşturarak döndürsün.
            Main içinde metodu çağırıp ekrana sonucu yazdırın.*/
            Console.Write("Adınızı giriniz: ");
            string ad = Console.ReadLine();
            Console.Write("Yaşınızı giriniz: ");
            int yas=Convert.ToInt32(Console.ReadLine());
            string mesaj1 = mesaj_yaz(ad, yas);
            Console.WriteLine(mesaj1);
        }
    }
}
