namespace Soru7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Kullanıcıdan 10 elemanlı bir sayı dizisi alarak tekrar eden sayıları
            tespit eden bir program yazın.
            Eğer kullanıcı yanlışlıkla harf veya geçersiz karakter girerse, hatayı
            yakalayın ve programın düzgün çalışmasını sağlayın.*/

            int[] sayilar = new int[10];
            int sayac = 0;

            Console.WriteLine("Lütfen 10 adet sayı giriniz:");

            while (sayac < 10)
            {
                Console.Write($"{sayac + 1}. Sayı: ");
                string giris = Console.ReadLine();
                try
                {
                    int sayi = Convert.ToInt32(giris);
                    sayilar[sayac] = sayi;
                    sayac++;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Hata: Geçersiz karakter! Lütfen sadece tam sayı giriniz.");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Hata: Çok büyük veya çok küçük bir sayı girdiniz.");
                }
            }
            bool[] bakildi = new bool[10];
            for (int i = 0; i < 10; i++)
            {
                if (bakildi[i] == true) continue;

                int adet = 1;
                for (int j = i + 1; j < 10; j++)
                {
                    if (sayilar[i] == sayilar[j])
                    {
                        adet++;
                        bakildi[j] = true;
                    }
                }

                if (adet > 1)
                {
                    Console.WriteLine($"Girdiğiniz {sayilar[i]} sayısı {adet} kez tekrar ediyor.");
                }
            }
        }
    }
}
