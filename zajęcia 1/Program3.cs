using System;

namespace _1_3
{
    class Program3
    {
        static void Main(string[] args)
        {
            int[][] tab = new int[10][];
            tab[0] = new int[1];
            tab[1] = new int[1];
            tab[0][0] = 1;
            tab[1][0] = 1;
            for (int i = 2; i<10; i++)
            {
                int fibonacciValue = tab[i - 1][0] + tab[i - 2][0];
                tab[i] = new int[fibonacciValue];

                for (int j = 0; j < fibonacciValue; j++)
                    tab[i][j] = fibonacciValue - j;
            }


            for (int i = 0; i < 10; i++)
            {
                Console.Write("tab[{0}] = ", i);
                for (int j = 0; j < tab[i].Length; j++)
                    Console.Write(tab[i][j] + " ");
                Console.Write("\n");
            }

        }
    }
}
