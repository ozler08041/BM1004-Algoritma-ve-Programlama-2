namespace Soru21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcıdan bir sayı alıp, 1'den bu sayıya kadar olan tüm sayıları ekrana yazdıran bir program yazınız.
            Console.Write("Bir sayı giriniz:");
            int sayi = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= sayi; i++)
            {
                if (i == sayi)
                {
                    Console.Write(i);
                }
                else
                    Console.Write(i + ", ");
            }
        }
    }
}
