using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program2
{
    class Program2
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 0;
            int c;
            try
            {
                try
                {
                    c = a / b;
                }
                catch(ArithmeticException e)
                {
                    throw new ArithmeticException("You divided by 0!", e);
                }
            }
            catch (Exception e)
            {
                throw new Exception("Error", e);
            }
        }
    }
}
