using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    class Outside
    {
        private double val;
        public class NewtonRaphson
        {
            private Outside parent;
            public NewtonRaphson(Outside obj, double val)
            {
                parent = obj;
                if (val < 0)
                    throw new ArgumentOutOfRangeException("value must be greater than 0");
                parent.val = val;
            }
            public void Set(int val)
            {
                if (val < 0)
                    throw new ArgumentOutOfRangeException("value must be greater than 0");
                parent.val = val;
            }
            public double Sqrt()
            {
                double eps = 0.001;
                double a = 1;
                double b = parent.val;

                while (Math.Abs(a - b) >= eps)
                {
                    a = (a + b) / 2;
                    b = parent.val / a;
                }

                return Math.Round(a,3);
            }
        }
    }
    class Program1
    {
        static void Main(string[] args)
        {
            Outside outside = new Outside();
            Outside.NewtonRaphson newtonRaphson = new Outside.NewtonRaphson(outside, 3);
            Console.WriteLine(newtonRaphson.Sqrt());

            newtonRaphson.Set(5);
            Console.WriteLine(newtonRaphson.Sqrt());

            newtonRaphson.Set(37);
            Console.WriteLine(newtonRaphson.Sqrt());

        }
    }
}
