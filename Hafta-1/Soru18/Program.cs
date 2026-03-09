namespace Soru18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcıdan 1 ile 12 arasında bir ay alıp, o ayın hangi mevsimde olduğunu bulan bir program yazınız.
            Console.Write("Girmek istediğiniz ayın sayısını giriniz: ");
            int ay = Convert.ToInt32(Console.ReadLine());
            switch (ay)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("Kış");
                    break;
                case 3:
                    case 4:
                    case 5:
                    Console.WriteLine("İlkbahar");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("Yaz");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("Sonbahar");
                    break;
            }
        }
    }
}
