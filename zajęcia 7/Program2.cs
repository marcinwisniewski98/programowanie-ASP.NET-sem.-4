using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program2
{
    class Program2
    {
        public static ArrayList countingSort(ArrayList numbers)
        {
            int[] counted = new int[51];

            foreach(int number in numbers)
                counted[number]++;

            //int j = 0;
            for(int i = 0, j=0; i<counted.Length; i++)
            {
                int count = counted[i];
                while (count > 0)
                {
                    numbers[j] = i;
                    j++;
                    count--;
                }
            }

            return numbers;
        }
        static void Main(string[] args)
        {
            Random rnd = new Random();

            ArrayList numbers = new ArrayList();
            for (int i = 0; i < 20; i++)
                numbers.Add(rnd.Next(1, 51));

            foreach (int number in numbers)
                Console.Write(number + " ");
            Console.Write("\n");

            ArrayList sortedNumbers = countingSort(numbers);
            foreach (int number in sortedNumbers)
                Console.Write(number + " ");
        }
    }
}
