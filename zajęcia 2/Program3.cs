using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program3
{
    
    class Tab
    {
        public int[] tab;
        public Tab(int[] tab)
        {
            this.tab = Sort(tab);
        }

        public int[] Sort(int[] tab)
        {
            for (int i = 0; i < 10; i++)
                for (int j = 1; j < 10-i; j++)
                    if (tab[j-1] > tab[j])
                    {
                        int temp = tab[j-1];
                        tab[j-1] = tab[j];
                        tab[j] = temp;
                    }
            return tab;
        }
    }
    class Program3
    {
        static void Main(string[] args)
        {
            int [] tab = new int[10];
 
            try
            {
                for (int i = 1; i <= 10; i++)
                {
                    Console.Write("Write {0}. number: ", i);
                    tab[i-1] = Convert.ToInt32(Console.ReadLine());
                }
            }
            catch(FormatException e)
            {
                Console.WriteLine("You didn't write a number " + e.Message);
                throw new FormatException();
            }
            catch(ArgumentOutOfRangeException)
            {
                throw new ArgumentOutOfRangeException();
            }

            Tab sortedTab = new Tab(tab);

            for (int i = 0; i < 10; i++)
                Console.Write(sortedTab.tab[i] + " ");
        }
    }
}
