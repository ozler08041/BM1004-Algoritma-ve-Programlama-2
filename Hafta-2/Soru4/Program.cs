namespace Soru4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Bir dizi oluşturun ve kullanıcıdan dizideki elemanlardan birini seçmesini
            isteyin.Kullanıcının geçersiz bir indeks girmesi durumunda, program hata
            vermeden "Geçersiz indeks! Lütfen 0 ile dizinin uzunluğu arasında bir değer 
            girin." mesajını göstermelidir.*/

            int[] dizi = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            Console.Write("İndex değeri giriniz(0-19): ");
            try
            {
                int index = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(dizi[index]);
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Hata! Belirlenen aralıkta giriniz!");
            }
        }
    }
}
