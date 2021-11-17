using System;

namespace ques6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quadratic Equation: ax2 + bx + c = 0");
            Console.WriteLine("enetr the value of a");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("enetr the value of b");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("enetr the value of c");
            double c = double.Parse(Console.ReadLine());
            double x1;

            double x2 = QuadraticFormula(a, b, c, out x1);


            Console.WriteLine($" root are given as 0.0  when 4ac > bsquare  ");
            Console.WriteLine($"qudratic root are {x1} and {x2} ");
        }
        static double QuadraticFormula(double a, double b, double c, out double d)
        {
            double giveOut= 0.0 ;
            if (ComplexChecher(a,b,c) == true)
            {
                d = 0.0;
                giveOut =0.0;
            }
            else
            {
                double square_root = Math.Sqrt(b * b - (4 * a * c));
                d = ((-1 * b) - (square_root)) / (2 * a);
                giveOut = ((-1 * b) + (square_root)) / (2 * a);
            }
            return giveOut;
        }
        static bool ComplexChecher(double a, double b, double c)
        {
            double subtract = (b * b) - (4 * a * c);
            if (subtract < 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
