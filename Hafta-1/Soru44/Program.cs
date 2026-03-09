using System.Reflection.Metadata;

namespace Soru44
{
    internal class Program
    {
        static int carp(int x, int y)
        {
            int carpım = x * y;
            return carpım;
        }
        static void Main(string[] args)
        {
            /*Geriye değer döndüren ve parametre alan bir metot yazın.
            İki sayıyı parametre olarak alsın ve bu iki sayının çarpımını döndürsün.
            Main içinde kullanıcıdan iki sayı alıp metodu çağırın.
            Sonucu ekrana yazdırın.*/
            Console.WriteLine("1. sayıyı giriniz:");
            int sayi1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2. sayıyı giriniz:");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            int sayi1_sayi2_carpım = carp(sayi1, sayi2);
            Console.WriteLine("Bu iki sayının çarpımı " + carpım + "'dır.");
        }
    }
}
