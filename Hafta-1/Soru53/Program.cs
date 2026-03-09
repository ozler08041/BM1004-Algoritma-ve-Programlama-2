namespace Soru53
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Önceden bir dosya(kelimeler.txt) içinde kelimeler saklanmıştır.
            Program, bu dosyadan kelimeleri okuyarak bir diziye aktarır.
            Seçilen kelimenin harfleri rastgele karıştırılır.Karıştırma işlemini ayrı bir metot olarak yazınız.
            Kullanıcıdan doğru tahmini yapmasını ister.
            Doğru tahmin edilirse "Tebrikler!" mesajı verilir, yanlışsa doğru cevap gösterilir.*/
            string yol = "C:\\Klasör\\kelimeler.txt";
            if (!Directory.Exists("C:\\Klasör"))
                Directory.CreateDirectory("C:\\Klasör");
            if (!File.Exists(yol))
            {
                FileStream fs = File.Create(yol);
                fs.Close();
            }
            File.WriteAllText(yol, "ankara elma kalem kedi lama plazma tutku limon ahmet apartman çay istanbul soda kedi fil tepsi leopar");
            string metin = File.ReadAllText(yol);
            string[] kelimeler = metin.Split(' ');
            Random rnd = new Random();
            int index = rnd.Next(kelimeler.Length);
            string secilen_kelime = kelimeler[index];
            string karisik_kelime = karistir(secilen_kelime);
            Console.WriteLine("Karışık kelime: " + karisik_kelime);
            while (true)
            {
                Console.WriteLine("Tahmininiz: ");
                string tahmin = Console.ReadLine();
                if (tahmin == secilen_kelime)
                {
                    Console.WriteLine("Tebrikler!");
                    break;
                }
                else
                {
                    Console.WriteLine("Yanlış tahmin! Doğru cevap: " + secilen_kelime);
                    break;
                }
            }
        }
        static string karistir(string kelime)
        {
            char[] harfler = new char[kelime.Length];
            for (int i = 0; i < kelime.Length; i++)
            {
                harfler[i] = kelime[i];
            }
            Random rnd = new Random();
            int index = rnd.Next(harfler.Length);
            for (int i = 0; i < harfler.Length; i++)
            {
                char temp = harfler[i];
                harfler[i] = harfler[index];
                harfler[index] = temp;
            }
            return new string(harfler);
        }
    }
}
