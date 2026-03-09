namespace Soru47
{
    internal class Program
    {
        static void ortak_carpan_bul(int x, int y)
        {
            if (x > y)
            {
                for (int i = 1 ; i <= x ; i++)
                {
                    if(x % i == 0 & y % i==0)
                    {
                        Console.Write(i+ " ");
                    }
                }
            }
            else
            {
                for (int i = 1; i <= y; i++)
                {
                    if (x % i == 0 & y % i == 0)
                    {
                        Console.Write(i + " ");
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            /*Girilen iki sayının ortak bölenlerini bulan bir metot yazın.
            İki int parametre alsın.
            Ortak bölenleri bulup Main içinde ekrana yazdırsın.
            Geriye void döndürsün(sadece yazdırsın).*/
            Console.Write("1. sayıyı giriniz: ");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2. sayıyı giriniz: ");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            ortak_carpan_bul(sayi1 , sayi2);
        }
    }
}
