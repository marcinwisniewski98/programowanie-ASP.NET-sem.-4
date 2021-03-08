using System;

namespace _1_2
{
    class Program2
    {
        static void Main(string[] args)
        {
            int[][] tab = new int[4][];
            for (int i = 1; i <= 4; i++)
                tab[i - 1] = new int[i];

            int value = 10;
            for (int i = 0; i < tab.Length; i++)
                for (int j = 0; j < tab[i].Length; j++)
                    tab[i][j] = value--;

            for (int i = 0; i < tab.Length; i++)
            {
                for (int j = 0; j < tab[i].Length; j++)
                    Console.Write(tab[i][j] + "\t");
                Console.Write("\n");
            }
        }
    }
}
