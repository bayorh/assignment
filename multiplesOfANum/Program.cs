using System;

namespace multiplesOfANum
{
    class Program
    {
        static void Main(string[] args)
        {
            // number to get the factor ;
            Console.WriteLine(" enter the number to get it multiple ");
            int number = int.Parse(Console.ReadLine());
            // repeat time
            Console.WriteLine(" enter the number of time to repeat");
            int repeatTime = int.Parse(Console.ReadLine());
            long multiple = number;
           Console.WriteLine($"multiples of {number} up to {repeatTime} count(s) are "); 
           Console.Write($" {multiple}, ");
            for (int i = 0; i<repeatTime;i++)
            {
            long result = multiple * number;
            multiple = result;
            Console.Write($" {multiple}, ");
            }
            Console.WriteLine($"  ");
        }
    }
}
