namespace Soru40
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Kullanıcıdan 10 adet tam sayı alarak bir diziye kaydedin. Daha sonra dizideki en büyük ve en küçük
            elemanı bularak ekrana yazdırın.*/
            Console.Write("10 adet sayı giriniz: ");
            int[] sayilar=new int[10];
            for (int i = 0; i < 10; i++)
            {
                sayilar[i] = Convert.ToInt32(Console.ReadLine()); 
            }
            int enk = sayilar[0];
            int enb = sayilar[0];
            for (int i = 0; i < sayilar.Length; i++)
            {
                if (sayilar[i] < enk)
                    enk = sayilar[i];
                if (sayilar[i] > enb)
                    enb = sayilar[i];
            }
            Console.WriteLine("En büyük: " + enb);
            Console.WriteLine("En küçük: " + enk);
        }
    }
}
