namespace Soru41
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*3x3 boyutunda iki matris oluşturun. Kullanıcıdan her iki matrisin elemanlarını alın. Ardından, bu iki
            matrisi toplayarak yeni bir matris oluşturun ve sonucu ekrana yazdırın.*/
            int[,] matris1 = new int[3, 3];
            int[,] matris2 = new int[3, 3];
            Console.Write($"1. matrisin elemanlarını giriniz: ");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matris1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.Write($"2. matrisin elemanlarını giriniz: ");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matris2[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("1. matris: ");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(matris1[i, j]+" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("2. matris: ");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(matris2[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
