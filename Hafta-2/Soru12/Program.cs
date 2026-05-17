using static System.Net.WebRequestMethods;

namespace Soru12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Bir hesap makinesi programı yazmanız istenmektedir. Kullanıcı, ESC tuşuna basana kadar işlem yapmaya
            devam edebilmelidir. Ancak, kullanıcı hatalı giriş yaptığında program çökmemeli, try-catch ile hata
            yönetimi sağlanmalıdır.*/

            do
            {
                try
                {
                    Console.Write("Birinci sayıyı giriniz: ");
                    double sayi1 = Convert.ToInt32(Console.ReadLine());

                    Console.Write("İşlemi giriniz (+, -, *, /): ");
                    string islem = Console.ReadLine();

                    if (islem != "+" && islem != "-" && islem != "*" && islem != "/")
                    {
                        throw new Exception("Geçersiz işlem!");
                    }

                    Console.Write("İkinci sayıyı giriniz: ");
                    double sayi2 = Convert.ToInt32(Console.ReadLine());

                    double sonuc = 0;
                    switch (islem)
                    {
                        case "+": sonuc = sayi1 + sayi2; break;
                        case "-": sonuc = sayi1 - sayi2; break;
                        case "*": sonuc = sayi1 * sayi2; break;
                        case "/":
                            if (sayi2 == 0) throw new DivideByZeroException();
                            sonuc = sayi1 / sayi2;
                            break;
                    }

                    Console.WriteLine($"Sonuç: {sonuc}");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Geçersiz giriş! Lütfen bir sayı girin.");
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Matematiksel hata! Bir sayı sıfıra bölünemez.");
                }
                catch (Exception ex) when (ex.Message == "Geçersiz işlem!")
                {
                    Console.WriteLine("Geçersiz işlem! Lütfen +, -, * veya / kullanın.");
                }

                Console.WriteLine("\nDevam etmek için Enter'a, çıkmak için ESC tuşuna basın.");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
