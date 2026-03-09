namespace Soru14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcıdan iki sayı alıp, bunları büyükten küçüğe sıralayan bir program yazınız.
            Console.WriteLine("1. sayıyı giriniz:");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2. sayıyı giriniz:");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            string sırala = (sayi1 < sayi2) ? $"{sayi1} < {sayi2}" : (sayi1 > sayi2) ? $"{sayi2} < {sayi1}": $"{sayi1} = {sayi2} ";
            Console.WriteLine(sırala);
        }
    }
}
