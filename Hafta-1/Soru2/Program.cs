namespace Soru2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Kullanıcıdan iki sayı alıp, bu sayıların toplamını ekrana yazdıran bir C# programı yazınız.
            Örnek giriş: 10, 20
            Beklenen çıktı: Toplam: 30*/
            Console.Write("2 sayı giriniz: ");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("İki sayının toplamı:" + (sayi1 + sayi2));

        }
    }
}
