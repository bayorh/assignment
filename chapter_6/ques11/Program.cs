using System;

namespace ques11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the value of k to get K!");
            int k = int.Parse(Console.ReadLine());
            long k_factorial = GetFactorial(k);
            int count = 0;
            while (k_factorial % 10 == 0)
            {
                count++;
                k_factorial/=10;
            }
            Console.WriteLine("amount of zero of the factorial is " + count);
        }
        static long GetFactorial(int a)
        {
            long factorial = 1;
            for (int i = a; i >= 1; i--)
            {

                factorial *= i;
            }
            return factorial;
        }
    }
}
