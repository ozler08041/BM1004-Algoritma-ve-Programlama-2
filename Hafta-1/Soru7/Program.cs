namespace Soru7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcıdan bir karakter girmesini isteyip, ASCII kodunu hesaplayan bir program yazınız.
            Console.Write("Bir karakter giriniz: ");
            char krt = Convert.ToChar(Console.ReadLine());
            int asciikrt = krt;
            Console.WriteLine($"{krt} in ASCII kodu: {asciikrt}");
        }
    }
}
