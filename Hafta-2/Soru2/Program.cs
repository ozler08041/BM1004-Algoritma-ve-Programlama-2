namespace Soru2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Kullanıcıdan yaşını girmesini isteyen bir program yazınız.Ancak,
            kullanıcının yalnızca geçerli bir tam sayı girdiğinden emin olun. Eğer
            kullanıcı bir harf, noktalı sayı veya başka geçersiz bir giriş yaparsa, 
            program hata vermeden "Geçersiz giriş! Lütfen bir tam sayı girin."
            mesajı göstererek tekrar giriş istemelidir.*/

            Console.Write("Yaşınızı giriniz: ");
            bool gecerli_giris = false;
            while (!gecerli_giris)
            {
                try
                {
                    int yas = Convert.ToInt32(Console.ReadLine());
                    if (yas < 0)
                    {
                        Console.WriteLine("Geçersiz giriş! Yaş negatif olamaz.");
                    }
                    else
                    {
                        gecerli_giris = true;
                        Console.WriteLine("Yaşınız: " + yas);
                    }      
                }
                catch (Exception)
                {
                    Console.WriteLine("Geçersiz giriş! Lütfen bir tam sayı girin.");
                    Console.Write("Yaşınızı tekrar giriniz: ");
                }   
            }
           
        }
    }
}
