namespace Soru34
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Kullanıcıdan bir sayı alıp, 1'den bu sayıya kadar olan sayılar içinde 3 veya 7'ye bölünebilenleri
            ekrana yazdıran bir program yazınız.Ancak 3 ve 7'ye aynı anda bölünebilenleri yazdırmayınız.*/
            Console.Write("Bir sayı giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= sayi; i++)
            {
                if ( (i % 3 == 0 || i % 7 == 0) && !(i % 3 == 0 && i % 7 == 0))
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
