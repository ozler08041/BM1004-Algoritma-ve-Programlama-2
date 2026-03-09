namespace Soru35
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dikdörtgen çizme.
            for (int i = 0; i < 20; i++)
            {
                Console.SetCursorPosition(i+5,5);
                Console.WriteLine("#");
                Thread.Sleep(100);
            }
            for (int i = 0; i < 20; i++)
            {
                Console.SetCursorPosition(25, i + 5);
                Console.WriteLine("#");
                Thread.Sleep(100);
            }
            for (int i = 0; i < 20; i++)
            {
                Console.SetCursorPosition(25-i, 25);
                Console.WriteLine("#");
                Thread.Sleep(100);
            }
            for (int i = 0; i < 20; i++)
            {
                Console.SetCursorPosition(5, 25-i);
                Console.WriteLine("#");
                Thread.Sleep(100);
            }
        }
    }
}
