namespace Soru33
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1'den 10'a kadar olan sayıları ekrana yazdıran bir program yazınız. Ancak 5 sayısını atlayınız.
            for (int i = 1; i < 11; i++)
            {
                if (i == 5)
                    continue;
                Console.Write(i + " ");
            }
        }
    }
}
