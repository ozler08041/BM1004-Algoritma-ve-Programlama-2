namespace Soru_4
{
    internal class Program
    {
        static void degistir(ref int a, ref int b, ref int c)
        {
            int tempA = a;
            int tempB = b;
            int tempC = c;
            a = tempB; 
            b = tempC; 
            c = tempA; 
        }
        static void Main(string[] args)
        {
            /*Bir C# metodu yazınız. Bu metot:
            Üç tam sayıyı parametre olarak almalı.
            İlk sayı ikinciye, ikinci sayı üçüncüye, üçüncü sayı ilkine
            atanarak değerler döngüsel olarak değişmelidir.
            ref kullanarak değerlerin doğrudan değiştirilmesini sağlamalıdır.*/

            int sayi1 =1;
            int sayi2 =2;
            int sayi3 =3;

            degistir(ref sayi1, ref sayi2, ref sayi3);
            Console.WriteLine("Sayılar: " + sayi1 + ", " + sayi2 + ", " + sayi3);
        }
    }
}
