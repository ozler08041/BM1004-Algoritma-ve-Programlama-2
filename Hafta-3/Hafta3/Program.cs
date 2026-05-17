namespace Hafta3
{
    internal class Program
    {
        static void en_yakin_cift_tek(int sayi, out int enYakinCift, out int enYakinTek)
        {
            if (sayi % 2 == 0)
            {
                enYakinCift = sayi;
                enYakinTek = sayi + 1;
            }
            else
            {
                enYakinCift = sayi - 1;
                enYakinTek = sayi;
            }
        }
        static void Main(string[] args)
        {
            /*Bir tamsayıyı parametre olarak alan, daha sonra out kullanarak bu
            sayıya en yakın çift ve tek sayıyı bulan bir metot yazın.*/

            Console.WriteLine("Bir sayı giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            en_yakin_cift_tek(sayi, out int enYakinCift, out int enYakinTek);
            Console.WriteLine("En yakın çift sayı: " + enYakinCift);
            Console.WriteLine("En yakın tek sayı: " + enYakinTek);
        }
    }
}
