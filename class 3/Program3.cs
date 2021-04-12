using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program3
{
    class Program3
    {
        static List<int> parseNumbers(string[] strings) {
            List<int> numbers = new List<int>();
            foreach(string str in strings)
            {
                try
                {
                    int number = Int32.Parse(str);
                    numbers.Add(number);
                }
                catch { }                    
            }
            
            return numbers;
        }

        static void printPrimeNumbers(List<int> numbers)
        {
            int max = numbers.Max();
            bool [] tab = new bool[max+1];
            for(int i = 1; i < tab.Length; i++) 
                tab[i] = true;

            double checkEnd = Math.Sqrt(tab.Length + 1);
            for (int i = 2; i <= checkEnd; i++)
            {
                if (tab[i] == true)
                    for (int j = 2; i * j <= max; j++)
                        tab[i * j] = false;
            }

            List<int> primeNumbers = new List<int>();

            foreach (int number in numbers)
                if (number >= 2 && tab[number] == true)
                    primeNumbers.Add(number);

            if (primeNumbers.Count == 0)
                Console.WriteLine("No prime numbers were entered.");
            else
            {
                Console.WriteLine("The following prime numbers were found: ");
                foreach (int number in primeNumbers)
                    Console.Write(number + " ");
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        static void printMinimum(List<int> tab)
        {
            int min = tab.Min();
            Console.WriteLine("The minimam value is " + min);
        }
        static void Main(string[] args)
        {
            char[] separators = { ',', '.', ';', '/', '\t', ' ' };

            Console.WriteLine("Write down numbers separated by , . ; / tab or space");
            String input = Console.ReadLine();
            String[] numbersString = input.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            List<int> numbers = parseNumbers(numbersString);

            if (numbers.Count == 0)
            {
                Console.WriteLine("No numbers were entered.");
                return;
            }

            printPrimeNumbers(numbers);
            printMinimum(numbers);
        }
    }
}
