namespace Soru5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Kullanıcıdan sırasıyla adını, yaşını ve memleketini alıp, bunları aşağıdaki formatta ekrana yazdıran bir C# 
            programı yazınız:
            Adınız: Ayşe 
            Yaşınız: 30 
            Memleketiniz: İstanbul*/
            Console.Write("İlk sayıyı giriniz: ");
            int s1 =Convert.ToInt32(Console.ReadLine());
            Console.Write("İkinci sayıyı giriniz: ");
            int s2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Toplam: " + (s1+s2));
            Console.WriteLine("Fark: " + (s1-s2));
            Console.WriteLine("Çarpım: " + (s1*s2));
            Console.WriteLine("Bölüm: " + (s1/s2));
        }
    }
}
