namespace Hafta2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Kullanıcıdan iki sayı alarak bölme işlemi yapan bir program yazın.
            Ancak sıfıra bölme hatasını yakalayan bir hata yönetimi ekleyin.*/
            Console.Write("1. sayıyı giriniz: ");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2. sayıyı girin: ");
            int sayi2 = Convert.ToInt32(Console.ReadLine());    
            try
            {
                int bölüm = sayi1 / sayi2;
                Console.WriteLine("Bölme işlemi sonucu: " + bölüm);
            }
            catch (Exception e)
            {
                Console.WriteLine("Hata: " + e.Message);
            }
        }
    }
}
