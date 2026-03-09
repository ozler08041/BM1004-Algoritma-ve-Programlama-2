namespace Soru37
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Kullanıcıdan kaç tane rastgele sayı üretmek istediğini ve alt - üst sınırları girmesini isteyin.Ardından bu
            aralıkta belirtilen sayıda rastgele sayı üretip bir diziye ekleyin ve diziyi ekrana yazdırın.*/
            Console.Write("Kaç adet rastgele sayı üretmek istersiniz? ");
            int kac_adet=Convert.ToInt32(Console.ReadLine());
            Console.Write("Alt sınırı giriniz: ");
            int alt_sinir=Convert.ToInt32(Console.ReadLine());
            Console.Write("Üst sınırı giriniz: ");
            int üst_sinir= Convert.ToInt32(Console.ReadLine());
            Random rsgl = new Random();
            int[] rastgele_sayilar = new int[kac_adet];
            for(int i = 0; i < kac_adet; i++)
            {
                rastgele_sayilar[i] = rsgl.Next(alt_sinir, üst_sinir + 1);
            }
            Console.Write("Üretilen rastgele sayılar: ");
            for(int i = 0;i < kac_adet;i++)
            {
                Console.Write(rastgele_sayilar[i] + " ");
            }
        }
    }
}
