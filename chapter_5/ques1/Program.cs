using System;

namespace ques1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter num1");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter num2");
            int num2 = int.Parse(Console.ReadLine());

            int new_num1 ;
            int new_num2 ;
            
            if (num1>num2)
            {
                
                new_num1 = num2;
                new_num2 = num1;

            }
            else
            {   
               
                new_num1 = num1;
                new_num2 = num2;

            }
            Console.WriteLine($" result: num1 is now {new_num1} and num2 is now  {new_num2} ");
        }
    }
}
