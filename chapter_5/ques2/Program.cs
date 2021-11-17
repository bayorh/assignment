using System;

namespace ques2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter num1");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter num2");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter num3");
            int num3 = int.Parse(Console.ReadLine());
            int biggest;
            if (num1 > num2 && num1 > num3)
            {
                biggest = num1;
            }
            else if (num2 > num1 && num2 > num3)
            {
                biggest = num2;
            }
            else if (num3 > num1 && num3 > num1)
            {
                biggest=num3;
            }
            Console.WriteLine(biggest);
        }
    }
}
