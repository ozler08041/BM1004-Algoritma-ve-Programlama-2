namespace Soru_6
{
    internal class Program
    {
        static int[] sırala(int[] dizi)
        {
            for (int i=0; i<dizi.Length-1; i++)
            {
                for (int j=0; j<dizi.Length-1-i; j++)
                {
                    if (dizi[j] < dizi[j + 1])
                    {

                        int temp = dizi[j];
                        dizi[j] = dizi[j + 1];
                        dizi[j + 1] = temp;
                        
                    }
                }
            }
            return dizi;
        }
        static void Main(string[] args)
        {
            //Bir dizinin elemanlarını sıralayan metot yazınız…(büyükten küçüğe)
            int[] dizi = { 5, 2, 9, 1, 5, 6 };
            sırala(dizi);
            Console.Write("Sıralanmış dizi: ");
            Console.WriteLine( "Sıralanmış dizi: ");
                for (int i = 0; i < dizi.Length; i++)
                {
                    Console.Write(dizi[i] + " ");
            }
        }
    }
}
