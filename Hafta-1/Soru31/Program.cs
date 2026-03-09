namespace Soru31
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcıdan sürekli olarak sayı alıp ekrana yazdıran bir program yazınız. Ancak kullanıcı 0 girerse döngüden çıkınız.
            int sayi;
            while (true)
            {
                Console.Write("Sayı: ");
                sayi =Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(sayi);
                if (sayi == 0)
                    break;
            }
        }
    }
}
