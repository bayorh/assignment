using System;

namespace ques10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that applies bonus points to given scores in the range [1…9] 
            // by the following rules:
            // - If the score is between 1 and 3, the program multiplies it by 10.
            // - If the score is between 4 and 6, the program multiplies it by 100.
            // - If the score is between 7 and 9, the program multiplies it by 1000.
            // - If the score is 0 or more than 9, the program prints an error message.
            Console.WriteLine("how many score will you like to insert ");
            int count = int.Parse(Console.ReadLine());
            double[] score_list = new double[count];
            double result;
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("enter number : ");
                score_list[i] = double.Parse(Console.ReadLine());
            }
            foreach (var item in score_list)
            {
                if (item >=7 && item <= 9)
                {
                  Console.WriteLine("bonus point " +(item * 1000));
                }
                else if (item>=4 && item <= 6)
                {
                    Console.WriteLine("bonus point " +(item * 100));
                }
                else if (item>=1 && item <= 3)
                {
                    Console.WriteLine("bonus point " +(item * 10));
                }
                else
                {
                    Console.WriteLine("Eroor!!!: give a valid input");
                }
            }
        }
    }
}
