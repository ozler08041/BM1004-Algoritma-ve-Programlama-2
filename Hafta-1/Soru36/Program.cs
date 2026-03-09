namespace Soru36
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcıdan bir üst sınır alarak 1 ile bu sınır arasında raastgele bir sayı üreten ve sayıyı kullanıcıya gösteren bir C# kodu yazınız.
            Console.Write("Üst sınır olacak sayıyı giriniz:");
            int sayi = Convert.ToInt32(Console.ReadLine());
            Random rsgl = new Random();
            sayi = rsgl.Next(1,sayi+1);
            Console.WriteLine(sayi);
        }
    }
}
