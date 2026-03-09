namespace Soru27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcıdan bir sayı alıp, bu sayının tam bölenlerini listeleyen bir program yazınız.
            Console.Write("Bir sayı giriniz:");
            int sayi = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= sayi; i++)
            {
                if (sayi%i ==0)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
