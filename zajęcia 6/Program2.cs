using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program2
{
    class Program2
    {
        public class IntTable
        {
            private int[] tab;
            public IntTable(int size)
            {
                if (size < 0)
                    throw new ArgumentException("size < 0");
                tab = new int[size];
            }
            public int Get(int index)
            {
                if (index >= tab.Length || index < 0)
                    throw new ArgumentOutOfRangeException("max index is {0}", (tab.Length - 1).ToString());
                return tab[index];
            }
            public void Set(int index, int value)
            {
                if (index < 0)
                    throw new IndexOutOfRangeException("minimal index is 0");
                if (index >= tab.Length)
                    Resize(index + 1);
                tab[index] = value;
            }
            void Resize(int size)
            {
                int[] newTab = new int[size];

                for (int i = 0; i < tab.Length; i++)
                    newTab[i] = tab[i];
                tab = newTab;
            }
            public int Length
            {
                get { return tab.Length; }
            }
            public void Sort()
            {
                for(int i = 1; i < tab.Length; i++)
                {
                    int temp = tab[i];
                    int j = i - 1;

                    while(j>=0 && tab[j] > temp)
                    {
                        tab[j + 1] = tab[j];
                        --j;
                    }
                    tab[j + 1] = temp;
                }
            }
        }
        static void Main(string[] args)
        {
            IntTable intTable = new IntTable(9);
            int[] numbers = new int[] { 3, -32, 10, 32, 0, 5, 2, 6, 9, 3 };

            for (int i = 0; i < numbers.Length; i++)
                intTable.Set(i, numbers[i]);

            intTable.Sort();

            for (int i = 0; i < intTable.Length; i++)
                Console.WriteLine(intTable.Get(i));
        }
    }
}
