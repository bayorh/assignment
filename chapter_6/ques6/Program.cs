using System;

namespace ques6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the value of N where N is greater than K");
            int n= int.Parse(Console.ReadLine());
            Console.WriteLine("enter the value of k where N is greater than K");
            int k= int.Parse(Console.ReadLine());
            long n_factorial = GetFactorial(n);
            long k_factorial = GetFactorial(k);
            double result;
            if (n > k && k > 1)
            {
                result = (double)n_factorial/k_factorial;
                Console.WriteLine("result "+ result);
            }
            else
            {
                Console.WriteLine("enter valid inputs ");
            }

        }
        static long GetFactorial(int a)
        {
            long factorial =1;
            for (int i = a; i >= 1; i--)
            {
                
                factorial*=i;
            } 
            return factorial;
        }
    }
}
