namespace Soru8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcıdan üç basamaklı bir sayı alıp, bu sayının basamaklarını toplamak için bir program yazınız.
            Console.WriteLine("Üç basamaklı bir sayı giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            if (sayi<1000 & sayi>99)
            {
                int birler = sayi % 10;
                int onlar = (sayi / 10) % 10;
                int yuzler = sayi / 100;
                int toplam = birler + onlar + yuzler;
                Console.WriteLine($"Girdiğiniz sayının basamakları toplamı: {toplam}");
            }
            else
                Console.WriteLine("Lütfen üç basamaklı bir sayı giriniz.");
        }
    }
}
