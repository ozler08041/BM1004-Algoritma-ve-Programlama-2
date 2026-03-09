namespace Soru50
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Bir dosyadan sayı okuyup toplamını hesaplayan program yazın.
            "sayilar.txt" dosyasındaki sayıları okuyup toplayın.
            Sonucu "toplam.txt" adlı dosyaya yazdırın.*/
            string yol1 = "C:\\Klasör\\sayılar.txt";
            string yol2 = "C:\\Klasör\\toplam.txt";
            if (!Directory.Exists("C:\\Klasör"))
                Directory.CreateDirectory("C:\\Klasör");
            if(!File.Exists(yol1))
            {
                FileStream fs = File.Create(yol1);
                fs.Close();
            }
            if (!File.Exists(yol2))
            {
                FileStream fs= File.Create(yol2);
                fs.Close();
            }
            File.WriteAllText(yol1, "1 2 3 4 5 6 7 8 9 10");
            string sayilar = File.ReadAllText(yol1);
            int toplam = 0;
            int gecici_sayi = 0;
            for (int i = 0; i <sayilar.Length ; i++)
            {
                if (sayilar[i] != ' ')
                    gecici_sayi = gecici_sayi * 10 + (sayilar[i] - '0');
                else
                {
                    toplam += gecici_sayi;
                    gecici_sayi = 0;
                }
            }
            toplam += gecici_sayi;
            File.WriteAllText(yol2, toplam.ToString());
        }
    }
}
