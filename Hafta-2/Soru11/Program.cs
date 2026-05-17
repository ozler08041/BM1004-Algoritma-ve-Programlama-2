namespace Soru11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*4 elemanlı boş bir dizi tanımlayın.
            Kullanıcıdan - 1’e basana kadar diziye veri kaydedin.
            Dizinin boyutunu dinamik olarak artırarak daha fazla veri eklenmesini sağlayın.*/
            int[] dizi = new int[4];
            Console.Write("Eleman ekleyiniz: ");
            while (true)
            {
                int eleman = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < dizi.Length; i++)
                {
                    if (eleman == -1)
                    {
                        Console.WriteLine("Diziye eleman ekleme işlemi sonlandırıldı.");
                        return;
                    }
                    if (dizi[i] == 0)
                    {
                        dizi[i] = eleman;
                        break;
                    }
                    else if (i == dizi.Length - 1)
                    {
                        int[] gecici_dizi = new int[dizi.Length * 2];
                        for (int j = 0; j < dizi.Length; j++)
                        {
                            gecici_dizi[j] = dizi[j];
                        }
                        dizi = gecici_dizi;
                        dizi[i + 1] = eleman;
                        break;
                    }

                }
            }
        }
    }
}
