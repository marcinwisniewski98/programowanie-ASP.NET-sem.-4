using System;

namespace _1
{
    class Program1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Projekt 1 - ćwiczenie 1");

            Console.WriteLine("for loop");
            for (int i = 100; i >= 1; i--)
                if (i % 3 == 0 && i % 2 != 0)
                    Console.Write(i + " ");

            Console.WriteLine("\n\n" + "while loop");
            int j = 100;
            while (j >= 1)
            {
                if (j % 3 == 0 && j % 2 != 0)
                    Console.Write(j + " ");
                j--;
            }

            Console.WriteLine("\n\n" + "do..while loop");
            int k = 100;
            do
            {
                if (k % 3 == 0 && k % 2 != 0)
                    Console.Write(k + " ");
                k--;
            } while (k >= 1);
        }
    }
}
