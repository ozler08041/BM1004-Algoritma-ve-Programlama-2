namespace Soru20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcıdan iki sayı ve bir işlem türü(+,-,*,/) alıp, sonucu hesaplayan bir program yazınız.
            Console.Write("Birinci sayıyı giriniz: ");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("İkinci sayıyı giriniz:");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Yapmak istediğiniz işlemi seçiniz (+, -, *, /): ");
            char islem = Convert.ToChar(Console.ReadLine());

            switch(islem)
            {
                case '+':
                    Console.WriteLine("Sonuç: " + (sayi1 + sayi2));
                    break;
                case '-':
                    Console.WriteLine("Sonuç: " + (sayi1 - sayi2));
                    break;
                case '*':
                    Console.WriteLine("Sonuç: " + (sayi1 * sayi2));
                    break;
                case '/':
                    Console.WriteLine("Sonuç: " + (sayi1 / sayi2));
                    break;
                
            }
        }
    }
}
