namespace Soru54
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Önceden bir dosya(sozluk.txt) oluşturulmuştur ve içinde kelimeler ile anlamları yer almaktadır.
            Program, bu dosyayı okuyarak bir diziye aktarır.
            Kullanıcıdan bir kelime girmesi istenir.
            Girilen kelimenin anlamı dosyadan bulunur ve ekrana yazdırılır.
            Eğer kelime bulunamazsa "Bu kelime sözlükte yok!" mesajı verilir.
            Tüm işlemler metotlarla yapılmalıdır.*/
            string yol = "C:\\Klasör\\sozluk.txt";
            if (!Directory.Exists("C:\\Klasör"))
                Directory.CreateDirectory("C:\\Klasör");
            if (!File.Exists(yol))
            {
                FileStream fs = File.Create(yol);
                fs.Close();
            }
            File.WriteAllText(yol, "elma, Bir tür meyve.\r\nmasa, Üzerine bir şeyler konulan mobilya.\r\nkalem, Yazı yazmak için kullanılan araç.\r\nbulut, Gökyüzünde su buharından oluşan yapı.\r\nkitap, İçinde bilgi barındıran sayfalar bütünü.");
            string[] kelimeler = File.ReadAllLines(yol);
            Console.Write("Bir kelime giriniz: ");
            string aranacak_kelime = Console.ReadLine();
            for (int i = 0; i < kelimeler.Length;i++)
            {
                if(aranacak_kelime == kelimeler[i].Split(',')[0])
                {
                    Console.WriteLine("Anlamı: " + kelimeler[i].Split(',')[1]);
                    break;
                }
            }
        }
    }
}
