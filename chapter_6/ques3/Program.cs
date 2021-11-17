using System;

namespace ques3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number of score entries");
            int number = int.Parse(Console.ReadLine());
            int[] numbers=new int[number];

            for (int i = 0; i < number; i++)
            {
                Console.WriteLine("enter number");
                numbers[i] = int.Parse(Console.ReadLine());
            
            }
            int max = numbers[0];
            int min =numbers[0];
            foreach (var item in numbers)
            {
                if (item > max )
                {
                    max = item; 
                }
                if (item < min )
                {
                   min = item; 
                }
            }
            Console.WriteLine("max "+ max);
            Console.WriteLine("min "+ min);
        }
    }
}
