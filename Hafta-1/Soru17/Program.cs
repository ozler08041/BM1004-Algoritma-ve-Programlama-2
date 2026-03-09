namespace Soru17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Kullanıcıdan dört basamaklı bir sayı alıp, bu sayının büyükten küçüğe 
            sıralayarak yeni bir sayı oluşturan bir program yazınız.*/
            Console.Write("Dört basamaklı bir sayı giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());

            if (sayi < 1000 || sayi > 9999)
            {
                Console.WriteLine("Lütfen dört basamaklı bir sayı giriniz!");
                return;
            }

            int bir = sayi % 10;
            int on = (sayi / 10) % 10;
            int yuz = (sayi / 100) % 10;
            int bin = sayi / 1000;

            int max1, max2, max3, max4;

            // 1. En büyük
            max1 = bin;
            if (yuz > max1) max1 = yuz;
            if (on > max1) max1 = on;
            if (bir > max1) max1 = bir;

            // 2. En büyük
            max2 = -1;
            if (bin != max1 && bin > max2) max2 = bin;
            if (yuz != max1 && yuz > max2) max2 = yuz;
            if (on != max1 && on > max2) max2 = on;
            if (bir != max1 && bir > max2) max2 = bir;

            // 3. En büyük
            max3 = -1;
            if (bin != max1 && bin != max2 && bin > max3) max3 = bin;
            if (yuz != max1 && yuz != max2 && yuz > max3) max3 = yuz;
            if (on != max1 && on != max2 && on > max3) max3 = on;
            if (bir != max1 && bir != max2 && bir > max3) max3 = bir;

            // Son kalan
            max4 = bin;
            if (max4 == max1 || max4 == max2 || max4 == max3) max4 = yuz;
            if (max4 == max1 || max4 == max2 || max4 == max3) max4 = on;
            if (max4 == max1 || max4 == max2 || max4 == max3) max4 = bir;

            int yeniSayi = max1 * 1000 + max2 * 100 + max3 * 10 + max4;

            Console.WriteLine("Büyükten küçüğe sıralanmış hali: " + yeniSayi);
        }
    }
}
