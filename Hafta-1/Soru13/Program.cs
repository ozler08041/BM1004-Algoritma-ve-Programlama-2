namespace Soru13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcıdan bir sayı alıp, bu sayının pozitif mi negatif mi olduğunu bulan bir program yazınız.
            Console.Write("Bir sayı giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            string sonuc = (sayi > 0) ? "Pozitif" : (sayi < 0) ? "Negatif" : "Sıfır";
            Console.WriteLine(sonuc);
        }
    }
}
