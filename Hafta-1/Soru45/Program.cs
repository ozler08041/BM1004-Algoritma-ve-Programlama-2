using System.Diagnostics.Metrics;
using System.Reflection.Metadata;

namespace Soru45
{
    internal class Program
    {
        static int karesini_hesapla(int n)
        {
            int karesi = n * n;
            return karesi;
        }
        static void Main(string[] args)
        {
            /*Girilen bir sayının karesini hesaplayan ve döndüren bir metot yazın.
            Geriye int döndürmeli.
            Parametre olarak bir int sayı almalı.
            Main içinde kullanıcıdan bir sayı alıp sonucu ekrana yazdırın.*/
            Console.Write("Bir sayı giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int sayi_karesi = karesini_hesapla(sayi);
            Console.WriteLine("Bu sayının karesi " + sayi_karesi +"'dir.");
        }
    }
}
