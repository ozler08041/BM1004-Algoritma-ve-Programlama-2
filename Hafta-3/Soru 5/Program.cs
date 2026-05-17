namespace Soru_5
{
    internal class Program
    {
        static int[] tersine_cevir(int[] dizi)
        {
            int temp;
            for (int i = 0; i < dizi.Length / 2; i++)
            {
                temp = dizi[i];
                dizi[i] = dizi[dizi.Length - 1 - i];
                dizi[dizi.Length - 1 - i] = temp;
            }
            return dizi;
        }
        static void Main(string[] args)
        {
            // Dizinin elemanlarını tersine çeviren bir metot yazınız…
            int[] dizi = { 1, 2, 3, 4, 5 };
            tersine_cevir (dizi);
            Console.Write("Dizinin tersi: ");
            for (int i = 0; i < dizi.Length; i++)
            {
                Console.Write(dizi[i] + " ");
            }
        }
    }
}
