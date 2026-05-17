namespace Soru9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Kullanıcıdan bir sınır(n) alarak 1'den n'e kadar olan tüm palindrom
            sayıları bulan bir algoritma yazın. (Palindrom, tersten okunuşu da
            aynı olan cümle, sözcük ve sayılara denilmektedir)
            Eğer kullanıcı negatif giriş yaparsa, hata fırlatın(throw)*/

            Console.Write("Sınır belirleyiniz: ");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n < 0)
            {
                throw new Exception("Negatif sayı sınır belirlenemez!");
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    int gecici = i;
                    int ters_i = 0;
                    while (gecici > 0)
                    {
                        int son_basamak = gecici % 10;
                        ters_i = (ters_i * 10) + son_basamak;
                        gecici = gecici / 10;
                    }
                    if (i == ters_i)
                        Console.WriteLine(i+ " palindron sayıdır.");
                }
            }

        }
    }
}
