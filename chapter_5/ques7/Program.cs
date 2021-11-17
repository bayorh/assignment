using System;
using System.Linq;
using System.Collections.Generic;

namespace ques7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("how many numbers will you like to compare ");
            int count = int.Parse(Console.ReadLine());
            double[] my_list = new double[count];
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("enter number : ");
                my_list[i] = double.Parse(Console.ReadLine());
            }

            double max = 0;
            foreach (var item in my_list)
            {
                Console.Write(item + " ");
                if (item > max)
                {
                    max = item;
                }
            }
            Console.WriteLine("maximum number is " + max);
        }
    }
}
