using System;

namespace ques12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a value to be converted to base 2 ");
            int number = int.Parse(Console.ReadLine());
            int remainder;
            string result = string.Empty;

            while (number != 0)
            {
                remainder = number % 2;
                number /= 2;
                result += remainder;
            }
            char[] myArray = result.ToCharArray();
            Array.Reverse(myArray);
            foreach (var item in myArray)
            {
                Console.Write(item);
            }

        }
    }
}
