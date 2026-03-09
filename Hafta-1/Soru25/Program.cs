namespace Soru25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcıdan bir sayı alıp, bu sayının Armstrong sayı olup olmadığını bulan bir program yazınız.
                Console.Write("Bir sayı girin: ");
                int sayi = Convert.ToInt32(Console.ReadLine());

                int gecici = sayi;
                int basamakSayisi = 0;
                int toplam = 0;

                while (gecici > 0)
                {
                    basamakSayisi++;
                    gecici = gecici / 10;
                }

                gecici = sayi;

                while (gecici > 0)
                {
                    int basamak = gecici % 10;
                    int kuvvet = 1;

                    for (int i = 0; i < basamakSayisi; i++)
                    {
                        kuvvet = kuvvet * basamak;
                    }

                    toplam = toplam + kuvvet;
                    gecici = gecici / 10;
                }

                if (toplam == sayi)
                {
                    Console.WriteLine(sayi + " bir Armstrong sayısıdır.");
                }
                else
                {
                    Console.WriteLine(sayi + " bir Armstrong sayısı değildir.");
                }
            }
        }
    }
    

