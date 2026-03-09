namespace Soru23
{
    internal class Program
    {
        static int Fibonacci(int n)
        {
            if (n <= 1)
                return n;
            else
                return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
        static void Main(string[] args)
        {
            //Kullanıcıdan bir sayı alıp, o kadar elemanlı Fibonacci dizisini ekrana yazdıran bir program yazınız.
            Console.Write("Bir sayı giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < sayi; i++)
            {
                Console.Write(Fibonacci(i) + " ");
            }
        }
    }
}
