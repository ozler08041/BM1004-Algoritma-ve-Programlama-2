using System.Diagnostics.Metrics;

namespace Soru10
{
    internal class Program
    {
        static void matris_topla(int[,] x , int[,] y)
        {
            if (x.Length != y.Length)
                throw new ArgumentException("Boyutları eşit değil toplanamıyor!");
            else
            {
                int[,] toplam = new int[x.Length, y.Length];
                for (int i = 0; i < x.Length; i++)
                {
                    for(int j = 0; j < y.Length; j++)
                    {
                        toplam[i, j] = x[i, j] + y[i,j];
                    }
                }
                for (int i = 0;i < toplam.Length; i++)
                { for(int j = 0;j < toplam.Length; j++)
                    {
                        Console.Write(toplam[i,j]);
                    }
                }
            }
        }
        static void Main(string[] args)
        { 
            /*İki matrisi toplayan bir metot yazın.
            Eğer matris boyutları eşleşmiyorsa hata fırlatın(throw).*/

            int[,] matris1 = { { 1, 2, 3 }, { 1, 2, 3 }, { 1, 2, 3 } };
            int[,] matris2 = { { 1, 2 }, { 1, 2 } };
            matris_topla(matris1, matris2);
        } 
    }
}
