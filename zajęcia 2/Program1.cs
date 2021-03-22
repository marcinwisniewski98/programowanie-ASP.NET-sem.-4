using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    class MyClass
    {
        double number;
        char sign;

        public MyClass(double number)
        {
            this.number = number;
            Console.WriteLine(this.number);
        }

        public MyClass(char sign)
        {
            this.sign = sign;
            Console.WriteLine(this.sign);
        }

        public MyClass(double number, char sign)
        {
            this.number = number;
            this.sign = sign;
            Console.WriteLine("{0} {1}", this.number, this.sign);
        }

        public MyClass(double x, double y)
        {
            int a = Convert.ToInt32(x);
            int b = Convert.ToInt32(y);

            while (b != 0)
            {
                int c = a % b;
                a = b;
                b = c;
            }

            Console.WriteLine(a);
        }

        public MyClass(int [] tab)
        {
            double checkEnd = Math.Sqrt(tab.Length + 1);
            int end = tab[tab.Length - 1];
            for(int i=2; i<=checkEnd; i++)
            {
                if (tab[i] > 0)
                    for (int j = 2; i * j <= end; j++)
                        tab[i * j] = 0;
            }

            for (int i = 2; i < tab.Length; i++)
                if (tab[i] > 0)
                    Console.Write(i + " ");
            Console.Write("\n");
        }
    }
    class Program1
    {
        static void Main(string[] args)
        {
            MyClass entity1 = new MyClass(23.1);
            MyClass entity2 = new MyClass('a');
            MyClass entity3 = new MyClass(23.1, 'a');
            MyClass entity4 = new MyClass(12, 18);
            
            int[] tab = new int[30];
            for (int i = 0; i < 30; i++)
                tab[i] = i;
            MyClass entity5 = new MyClass(tab);
        }
    }
}
