namespace Soru9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcıdan bir tam sayı alıp, bu sayının rakamlarının çarpımını hesaplayan bir program yazınız.
            Console.Write("Bir tam sayı giriniz:");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int birler = sayi % 10;
            int onlar = (sayi / 10) % 10;
            int yuzler = (sayi / 100) % 10;
            if (sayi <10 & sayi> -10)
            {
                Console.WriteLine("Lütfen en az iki basamaklı bir sayı giriniz.");
            }
            else if (sayi <100 & sayi > -100)
            {
                int carpim = birler * onlar;
                Console.WriteLine($"Girdiğiniz sayının rakamlarının çarpımı: {carpim}");
            }
            else if (sayi <1000 & birler > -1000)
            {
                int carpim = birler * onlar * yuzler;
                Console.WriteLine($"Girdiğiniz sayının rakamlarının çarpımı: {carpim}");
            }
            
        }
    }
}
