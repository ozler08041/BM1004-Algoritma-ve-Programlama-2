namespace Soru12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcıdan bir yıl değeri alıp, yılın artık yıl olup olmadığını bulan bir program yazınız.
            Console.Write("Bir yıl giriniz: ");
            int yıl = Convert.ToInt32(Console.ReadLine());
            string artik_mi =(yıl % 4 == 0) ? "Artık yıl" : "Artık yıl değil";
            Console.WriteLine(artik_mi);
        }
    }
}
