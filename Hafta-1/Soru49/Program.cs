using System.Runtime.ConstrainedExecution;

namespace Soru49
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Bir metin dosyası oluşturun ve içine bir dizi sayı yazın.
            Kullanıcıdan 5 tane sayı alıp "sayilar. txt" dosyasına yazdırın.
            Her sayıyı yeni satıra yazın.
            Dosyanın içeriğini okuyup ekrana yazdırın.*/
            string yol = "C:\\Klasör\\sayilar.txt";
            Directory.CreateDirectory("C:\\Klasör");
            FileStream fs = File.Create(yol);
            fs.Close();
            File.WriteAllText(yol, "1 2 3 4 5 6 7 8 9 10\n");
            Console.Write("5 adet sayı giriniz: ");
            for (int i = 0; i <5;i++)
            {
                File.AppendAllText(yol , Console.ReadLine() + "\n");
            }
            string içerik = File.ReadAllText(yol);
            Console.WriteLine("------------------------------------");
            Console.WriteLine(içerik);
        }
    }
}
