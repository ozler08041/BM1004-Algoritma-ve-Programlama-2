namespace Soru6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcıdan iki tam sayı alıp, bunların yerlerini değiştiren bir program yazınız.
            Console.Write("1. sayıyı giriniz:");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2. sayıyı giriniz:");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Değiştiriliyor...");
            int yeni_sayi1 = sayi2;
            int yeni_sayi2 = sayi1;
            Console.WriteLine("1. sayınız:" + yeni_sayi1);
            Console.WriteLine("2. sayınız:" + yeni_sayi2);
        }
    }
}
