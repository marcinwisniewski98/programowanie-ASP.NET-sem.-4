using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zajecia6
{
    public interface IMyInterface
    {
        int a { get; set; }
        int b { get; set; }
        int nww();
    }

    public class MyClass : IMyInterface
    {
        private int c, d;
        public int a
        {
            get
            {
                return c;
            }
            set
            {
                c = value;
            }
        }
        public int b
        {
            get
            {
                return d;
            }
            set
            {
                d = value;
            }
        }
        public int nww()
        {
            int i = c * d;
            while (c != d)
            {
                if (c > d)
                    c -= d;
                else
                    d -= a;

            }
            return i / d;
        }
    }

    class Program1
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            myClass.a = 36;
            myClass.b = 24;
            Console.WriteLine("NWW({0}, {1}) = {2}", myClass.a, myClass.b, myClass.nww());
        }
    }
}
