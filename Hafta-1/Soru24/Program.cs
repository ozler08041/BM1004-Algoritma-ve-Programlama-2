namespace Soru24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcıdan bir sayı alıp, bu sayının asal olup olmadığını bulan bir program yazınız.
            Console.Write("Bir sayı giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());

            for (int i = 2; i < sayi; i++)
            {
                if (sayi < 2)
                {
                    Console.WriteLine("Asal sayı değildir.");
                    return;
                }
                else if (sayi == 2)
                {
                    Console.WriteLine("Asal sayıdır.");
                    return;
                }
                else if (sayi % i == 0)
                {
                    Console.WriteLine("Asal sayı değildir.");
                    return;
                }
                else
                {
                    Console.WriteLine("Asal sayıdır.");
                    return;
                }
            }
        }
    }
}
