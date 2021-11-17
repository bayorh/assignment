using System;

namespace ques13
{
    class Program
    {
        static void Main(string[] args)
        {
            // binary to decimal.
            Console.WriteLine(" enter the value of base two to be converted to decimal");
            string Base2 = Console.ReadLine();
            char[] myChar = Base2.ToCharArray();
            double number = 0;
            int item;
            while (item!=0)
            {
                  foreach ( var item in myChar)
            {
                Console.WriteLine("nuber to base 10 is : "+ item);
                
            }
                 number += Math.Pow(2, myChar.Length - (i + 1));
            }
            Console.WriteLine("nuber to base 10 is : "+ number);
        }
    }
}
