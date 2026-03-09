namespace Soru30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcıdan bir şifre alıp, doğru şifre girilene kadar tekrar isteyen bir program yazınız.
            
            string dogru_sifre = "12345";
            string girilen_sifre;
            do
            {
                Console.Write("Şifre: ");
                girilen_sifre = Console.ReadLine();
                if(girilen_sifre != dogru_sifre)
                {
                    Console.WriteLine("Hatalı! tekrar deneyin.");
                }
            } while (girilen_sifre != dogru_sifre);
            Console.WriteLine("Giriş başarılı.");
        }
    }
}
