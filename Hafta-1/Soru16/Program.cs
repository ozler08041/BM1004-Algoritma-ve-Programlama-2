namespace Soru16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcıda üç basamaklı bir sayı alıp , bu sayının palindrom olup olmadığını bulan bir program yazınız.
            Console.Write("Üç basamaklı bir sayı giriniz: ");
            int sayi= Convert.ToInt32(Console.ReadLine());
            int b = sayi % 10;
            int o = (sayi % 10) / 10;
            int y = sayi / 100;
            if (sayi < 100 || sayi > 999)
            {
                Console.WriteLine("Lütfen üç basamaklı bir sayı giriniz!");
                return;
            }
            string palindrom_mu = (y == b) ? "Bu sayı palindromdur." : "Bu sayı palindrom değildir.";
            Console.WriteLine(palindrom_mu);
        }
    }
}
