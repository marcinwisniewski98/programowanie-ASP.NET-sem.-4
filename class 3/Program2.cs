using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program2
{
    class Program2
    {
        static double getCoefficient(string name)
        {
            if(name=="a")
                Console.Write("Enter the non-zero coefficient a: ");
            else
                Console.Write("Enter the coefficient {0}: ", name);
            double coefficient = 1;
            try
            {
                try
                {
                    coefficient = Double.Parse(Console.ReadLine());
                    if (coefficient == 0 && name == "a")
                        throw new ArgumentException();
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("The coefficient must be non - zero value.");
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                Console.Write("Incorrect data. Would you like to try again? [y/n]: ");
                String response = Console.ReadLine();
                if (response == "y")
                    return getCoefficient(name);
                else 
                    System.Environment.Exit(0);
            }

            return coefficient;
        }

        static void Main(string[] args)
        {
            double a, b, c;
            a = getCoefficient("a");
            b = getCoefficient("b");
            c = getCoefficient("c");

            double delta = b * b - 4 * a * c;

            if (delta < 0)
                Console.WriteLine("There is no roots");
            else if(delta == 0)
            {
                double root0 = -b / (2 * a);
                Console.WriteLine("There is one root.");
                Console.WriteLine(" x = " + root0);
            }
            else
            {
                double root1 = (-b - Math.Sqrt(delta)) / (2 * a);
                double root2 = (-b + Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine("There are two roots.");
                Console.WriteLine("x1 = " + Math.Round(root1, 2));
                Console.WriteLine("x2 = " + Math.Round(root2, 2));
            }
        }
    }
}
