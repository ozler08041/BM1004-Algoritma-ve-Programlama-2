using System.Diagnostics.Metrics;

namespace Soru3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Kullanıcıdan iki sayı ve bir işlem operatörü(+, -, *, /) alan ve sonucu
            ekrana yazdıran bir hesap makinesi programı yazın. 
            Ancak, kullanıcının geçersiz bir işlem girmesi veya sayı yerine
            karakter veya metin girmesi durumunda programın hata vermesini engelleyin.*/
            double sayi1 = 0, sayi2 = 0;
            char islem;
            bool dogru_mu = false;

            while (!dogru_mu)
            {
                try
                {
                    Console.Write("Birinci sayıyı girin: ");
                    sayi1 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("İkinci sayıyı girin: ");
                    sayi2 = Convert.ToDouble(Console.ReadLine());

                    dogru_mu = true;
                }
                catch
                {
                    Console.WriteLine("Hatalı giriş! Lütfen sayı girin.\n");
                }
            }

            while (true)
            {
                Console.Write("İşlem seçin (+, -, *, /): ");
                islem = Convert.ToChar(Console.ReadLine());

                if (islem == '+' || islem == '-' || islem == '*' || islem == '/')
                    break;

                Console.WriteLine("Geçersiz işlem! Tekrar girin.\n");
            }

            switch (islem)
            {
                case '+':
                    Console.WriteLine("Sonuç: " + (sayi1 + sayi2));
                    break;

                case '-':
                    Console.WriteLine("Sonuç: " + (sayi1 - sayi2));
                    break;

                case '*':
                    Console.WriteLine("Sonuç: " + (sayi1 * sayi2));
                    break;

                case '/':
                    if (sayi2 == 0)
                        Console.WriteLine("Sıfıra bölme hatası!");
                    else
                        Console.WriteLine("Sonuç: " + (sayi1 / sayi2));
                    break;
            }
        }
    }
}
