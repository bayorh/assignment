using System;

namespace ques1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a integer value");
            int number = int.Parse(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                Console.Write(i +" ");
            }
        }
    }
}
