namespace Soru22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcıdan bir sayı alıp, bu saynın faktöriyelini hesaplayan bir program yazınız.
            Console.Write("Bir sayı giriniz:");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int faktoriyel = 1;
            for (int i = 1; i <= sayi; i++)
            {
                faktoriyel *= i;
            }
            Console.WriteLine($"{sayi}! = {faktoriyel}");
        }
    }
}
