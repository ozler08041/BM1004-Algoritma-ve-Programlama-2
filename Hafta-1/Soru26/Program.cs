namespace Soru26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcıdan Bir aralık alıp, bu aralıktaki ikiz asal sayılar bulan bir program yazınız.
            Console.Write("Başlangıç değerini girin: ");
            int baslangic = Convert.ToInt32(Console.ReadLine());

            Console.Write("Bitiş değerini girin: ");
            int bitis = Convert.ToInt32(Console.ReadLine());

                for (int i = baslangic; i <= bitis - 2; i++)
                {
                    if (AsalMi(i) && AsalMi(i + 2))
                    {
                        Console.WriteLine(i + " ve " + (i + 2) + " ikiz asaldır.");
                    }
                }
            }

            static bool AsalMi(int sayi)
            {
                if (sayi < 2)
                    return false;

                for (int i = 2; i < sayi; i++)
                {
                    if (sayi % i == 0)
                        return false;
                }

                return true;
            }
        }

    
    }

