namespace Soru8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Kullanıcıdan bir tam sayı alarak bunun asal olup olmadığını kontrol
            eden bir algoritma yazın.
            Eğer kullanıcı geçersiz giriş(harf veya negatif sayı) yaparsa, hata
            yakalayarak "Geçersiz giriş! Pozitif tam sayı girin." mesajı gösterin.*/
            Console.Write("Pozitif bir tam sayı girin: ");
            string input = Console.ReadLine();
            try
            {
                int sayi = Convert.ToInt32(input);
                if (sayi <= 0)
                {
                    Console.WriteLine("Geçersiz giriş! Pozitif tam sayı girin.");
                    return;
                }

                if (sayi == 1)
                {
                    Console.WriteLine("1 asal sayı değildir.");
                    return;
                }

                bool asalMi = true;
                for (int i = 2; i < sayi; i++)
                {
                    if (sayi % i == 0)
                    {
                        asalMi = false;
                        break;
                    }
                }
                if (asalMi)
                    Console.WriteLine(sayi + " bir asal sayıdır.");
                else
                    Console.WriteLine(sayi + " bir asal sayı değildir.");
            }
            catch
            {
                Console.WriteLine("Geçersiz giriş! Pozitif tam sayı girin.");
            }
            
        }
        
    }
}
