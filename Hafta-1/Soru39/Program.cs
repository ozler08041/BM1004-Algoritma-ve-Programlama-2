namespace Soru39
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Kullanıcıdan 5 adet tam sayı alarak bir diziye ekleyin ve ardından bu dizinin elemanlarını ekrana yazdıran
            bir C# programı yazın.*/
            Console.Write("5 adet sayı giriniz: ");
            int[] sayilar = new int[5];
            for (int i = 0; i < 5; i++)
            {
                sayilar[i] = Convert.ToInt32(Console.ReadLine()); 
            }
            Console.Write("Dizinin elemanları: ");
            for (int i = 0;i < 5; i++)
            {
                Console.Write(sayilar[i] + " ");
            }
        }
    }
}
