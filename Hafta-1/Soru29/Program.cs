namespace Soru29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcıdan sürekli sayı alıp, negatif bir sayı girilene kadar girilen tüm pozitif sayıları toplayan bir program yazınız.
            int toplam = 0;
            while (true)
            {
                int sayi = Convert.ToInt32(Console.ReadLine());
                
                if (sayi < 0)
                {
                    break;
                }
                toplam += sayi;
            }
            Console.WriteLine(toplam);
        }
    }
}
