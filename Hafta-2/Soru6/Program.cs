namespace Soru6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Kullanıcının şifre oluşturmasını isteyen bir program yazın.
            Şifre en az 6 karakter uzunluğunda olmalı.
            Eğer kullanıcı 6 karakterden kısa bir şifre girerse, hata fırlatın(throw).*/

            Console.WriteLine("Şifre oluşturunuz: ");
            string sifre = Console.ReadLine();
            int minLength = 6;
            int uzunluk = sifre.Length;
            if (minLength > uzunluk)
            {
                throw new Exception("Şifre en az 6 karakter uzunluğunda olmalıdır.");
            }
        }
    }
}
