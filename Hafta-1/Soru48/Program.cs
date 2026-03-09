using static System.Net.WebRequestMethods;

namespace Soru48
{
    internal class Program
    {
        static bool palindron_mu(string metin)
        {
            for (int i = 0; i < metin.Length; i++)
            {
                if (metin[i] != metin[metin.Length -i-1])
                {
                    return false;
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            /*Palindrom kelime olup olmadığını kontrol eden bir metot yazın.
            string parametre alsın ve bool dondürsün.
            Kelimenin tersten yazılmış hali ile aynı olup olmadığını kontrol etsin.
            Main içinde kullanıcıdan kelime alıp sonucu ekrana yazdırın.*/
            Console.Write("Bir kelime giriniz:");
            string kelime= Console.ReadLine();
            bool kelime_palindron_mu = palindron_mu(kelime);
            if (kelime_palindron_mu == true)
                Console.WriteLine("Bu kelime palindrondur.");
            else
                Console.WriteLine("Bu kelime palindron değildir.");
        }
    }
}
