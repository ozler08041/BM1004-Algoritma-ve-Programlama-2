namespace Soru5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Kullanıcının dosya adını girdiği ve bu dosyayı açan bir program yazınız.Eğer
            dosya mevcut değilse, program hata vermeden "Dosya bulunamadı! Lütfen 
            geçerli bir dosya adı girin." mesajını göstermelidir.*/

                Console.Write("Dosya adını giriniz: ");
                string dosyaAdi = Console.ReadLine();
            try
            {
                string icerik = File.ReadAllText(dosyaAdi);
                Console.WriteLine("Dosya içeriği:\n" + icerik);
               
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Dosya bulunamadı! Lütfen geçerli bir dosya adı girin.");
            }
            }
    }
}
