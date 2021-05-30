using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program2
{
    abstract class First
    {
        public abstract void f(int number);
        public virtual void r(string fullText) {}
    }
    class Second : First
    {
        public override void f(int number)
        {
            List<int> result = new List<int>();
            int divider = 2;
            int sqrt = (int)Math.Sqrt(number);

            while (number > 1 && divider < sqrt)
            {
                while (number % divider == 0)
                {
                    result.Add(divider);
                    number /= divider;
                }
                ++divider;
            }

            if (number > 1)
                result.Add(number);

            foreach (int d in result)
                Console.Write(d + " ");
            Console.WriteLine();
        }
        public override void r(string fullText)
        {
            string result = "";
            for(int i=0; i<fullText.Length; i++)
            {
                int count = 1;
                while (i < fullText.Length - 1 && fullText[i] == fullText[i + 1])
                {
                    ++count;
                    ++i;
                }
                if (count > 1)
                    result += count.ToString() + fullText[i];
                else
                    result += fullText[i].ToString();
            }
            Console.WriteLine(result);
        }
    }
    class Program2
    {
        static void Main(string[] args)
        {
            Second second = new Second();
            second.f(24);
            second.r("ccccommmpressss thhhatt");
        }
    }
}
