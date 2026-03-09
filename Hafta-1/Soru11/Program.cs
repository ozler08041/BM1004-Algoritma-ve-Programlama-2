namespace Soru11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcıdan bir sıcaklık değeri alıp, sıcaklığın durumu hakkında yorum yapan bir program yazınız.
            Console.Write("Bir sıcaklık giriniz: ");
            int sıcaklık = Convert.ToInt32(Console.ReadLine());
            string yorum =(sıcaklık < 0) ? "Çok soğuk" :
                          (sıcaklık >= 0 && sıcaklık < 10) ? "Soğuk" :
                          (sıcaklık >= 10 && sıcaklık < 20) ? "Ilık" :
                          (sıcaklık >= 20 && sıcaklık < 35) ? "Sıcak" :
                          "Çok sıcak";
            Console.Write(yorum);
        }
    }
}
