namespace Soru3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Kullanıcıdan adını ve soyadını alıp, bu bilgileri birleştirerek ekrana yazdıran bir program yazınız.
            Örnek giriş: Ad: Ahmet, Soyad: Yılmaz
            Beklenen çıktı: Ad Soyad: Ahmet Yılmaz*/
            Console.Write("Adınız: ");
            string ad = Console.ReadLine();
            Console.Write("Soyadınız: ");
            string soyad = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Ad Soyad: " + ad + " " + soyad);
        }
    }
}
