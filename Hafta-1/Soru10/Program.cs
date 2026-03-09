namespace Soru10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcıdan bir tam sayı alıp, bu sayıyı tersine çevirerek ekrana yazdıran bir program yazınız.
            Console.Write("Bir tamsayı giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int tersSayi = 0;
            while (sayi != 0)
            {
                int basamak = sayi % 10;
                tersSayi = tersSayi * 10 + basamak;
                sayi /= 10;
            }
            Console.WriteLine("Girdiğiniz sayının tersi: " + tersSayi);
        }
       
    }
}
