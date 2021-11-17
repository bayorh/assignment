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
            for (int i = 0; i < myChar.Length; i++)
            {
                if (myChar[i] == 1)
                {
                    number += Math.Pow(2, myChar.Length - (i + 1));
                }
                else
                {
                    continue;
                }

            }
            Console.WriteLine("nuber to base 10 is : "+ number);
        }
    }
}
