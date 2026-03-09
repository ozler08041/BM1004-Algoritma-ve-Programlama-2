using System.Reflection;
using System.Security.Cryptography;

namespace Soru52
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Bir kelime tahmin oyunu yazın!
            "kelimeler.txt" dosyasından rastgele bir kelime seçin.
            Kullanıcıdan harf tahmini yapmasını isteyin.
            Yanlış tahmin hakkı 3 olsun.
            Doğru tahmin edilen harfler ekranda gösterilsin, yanlışlar listelensin.*/
            string yol = "C:\\Klasör\\kelimeler.txt";
            if (!Directory.Exists("C:\\Klasör"))
                Directory.CreateDirectory("C:\\Klasör");
            if (!File.Exists(yol))
            {
                FileStream fs = File.Create(yol);
                fs.Close();
            }
            File.WriteAllText(yol, "ankara elma kalem kedi lama plazma tutku limon ahmet apartman çay istanbul soda kedi fil tepsi leopar şeker ağaç yağmur");
            string metin = File.ReadAllText(yol);
            string[] kelimeler = metin.Split(' ');
            Random rnd = new Random();
            int index = rnd.Next(kelimeler.Length);
            string secilen_kelime = kelimeler[index];
            char[] gizli = new char[secilen_kelime.Length];
            for (int i = 0; i<gizli.Length; i++)
            {
                gizli[i] = '_';
            }
            int hak = 3;
            while (hak > 0)
            {
                Console.WriteLine("\ngizli kelime:");
                for (int i = 0; i < gizli.Length; i++)
                {
                    Console.Write(gizli[i] + " ");
                }
                Console.WriteLine("\nHarf tahmini: ");
                string giris = Console.ReadLine();
                if (giris.Length == 0)
                    continue;
                char harf = giris[0];
                bool var_mi = false;
                for (int i = 0; i < secilen_kelime.Length; i++)
                {
                    if (harf == secilen_kelime[i])
                    {
                        gizli[i] = harf;
                        var_mi = true;
                    }
                }
                if (!var_mi)
                {
                    hak--;
                    Console.WriteLine("Yanlış tahmin kalan hak:" + hak);
                }
                bool bitti_mi = true;
                for (int i = 0; i < gizli.Length; i++)
                {
                    if (gizli[i] == '_')
                        bitti_mi = false;
                }
                if (bitti_mi)
                {
                    Console.WriteLine("\nTebrikler! Kelime: " + secilen_kelime);
                    return;
                }
            }
            Console.WriteLine("\n Oyun bitti! Kelime: " + secilen_kelime);
        }
    }
}
