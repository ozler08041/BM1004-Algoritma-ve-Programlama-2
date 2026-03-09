namespace Hafta1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Kullanıcıdan adını alıp, ekrana "Merhaba, [isim]!" şeklinde yazdıran bir C# programı yazınız.
            Örnek giriş: Ahmet
            Beklenen çıktı: Merhaba, Ahmet!*/
            Console.Write("İsminizi giriniz: ");
            string ad = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Merhaba " + ad + "!");

        }
    }
}
