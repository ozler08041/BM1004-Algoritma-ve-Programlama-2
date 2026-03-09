namespace Soru51
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Kullanıcıdan isim, yaş ve şehir bilgilerini alıp
            Programı çalıştırınca dosyada kayıtlı kullanıcıları ekrana listeleyin.
            "kullanicilar.txt"dosyasına kaydedin.*/
            Console.Write("İsminizi giriniz: ");
            string isim = Console.ReadLine();
            Console.Write("Yaşınızı giriniz: ");
            int yas = Convert.ToInt32(Console.ReadLine());
            Console.Write("Şehir giriniz: ");
            string şehir = Console.ReadLine();
            string yol1 = "C:\\Klasör\\Kullanıcılar.txt";
            if (!Directory.Exists("C:\\Klasör"))
                Directory.CreateDirectory("C:\\Klasör");
            if (!File.Exists(yol1))
            {
                FileStream fs = File.Create(yol1);
                fs.Close();
            }
            File.AppendAllText(yol1, isim + " " + yas + " " + şehir+ "\n");
            string içerik = File.ReadAllText(yol1);
            Console.WriteLine(içerik);
        }
    }
}
