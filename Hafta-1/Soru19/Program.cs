namespace Soru19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcıdan 1 ile 7 arasında bir sayı alıp, karşılık gelen günü bulan bir program yazınız.
            Console.Write("Haftanın gününün sayısını giriniz: ");
            int gun = Convert.ToInt32(Console.ReadLine());
            switch (gun)
            {
                case 1:
                    Console.WriteLine("Pazartesi");
                    break;
                case 2:
                    Console.WriteLine("Salı");
                    break;
                case 3:
                    Console.WriteLine("Çarşamba");
                    break ;
                case 4:
                    Console.WriteLine("Perşembe");
                    break;
                case 5:
                    Console.WriteLine("Cuma");
                    break;
                case 6:
                    Console.WriteLine("Cumartesi");
                    break;
                case 7:
                    Console.WriteLine("Pazar");
                    break;
            }
        }
    }
}
