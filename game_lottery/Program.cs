using System;

namespace game_lottery
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rdm =new Random();
            int compNum1 = rdm.Next(0,10);
            int compNum2 = rdm.Next(0,10);
            int compNum3 = rdm.Next(0,10);

            Console.WriteLine("======GAME ON======");
            Console.WriteLine("guess a three numbers.");

            Console.WriteLine("enter first numbers.");
            int userNum1 =int.Parse(Console.ReadLine());
            Console.WriteLine("enter second numbers.");
            int userNum2 =int.Parse(Console.ReadLine());
            Console.WriteLine("enter third numbers.");
            int userNum3 =int.Parse(Console.ReadLine());
            Console.WriteLine("============");
            Console.WriteLine("ist price award : $10,000 : entries match in the same order");
            Console.WriteLine("2nd price award : $3,000 :entries are correct but not same order ");
            Console.WriteLine("3rd price award : $1,000 : one  entry matches any of the three");
            Console.WriteLine("============");
            Console.WriteLine($" {compNum1} {compNum2} {compNum3} ");
            if (compNum1 == userNum1 && compNum2 == userNum2 && compNum3 == userNum3)
            {
                Console.WriteLine("YOU WON  FIRST PRICE AWARD: $10,000 ");
               
            }
            else if ((compNum1 == userNum1 || compNum1 == userNum2 || compNum1 == userNum3)&&(compNum2 == userNum1 || compNum2 == userNum2 || compNum2 == userNum3)&&(compNum3 == userNum1 || compNum3 == userNum2 || compNum3 == userNum3))
            {
                Console.WriteLine("YOU WON SECOND PRICE AWARD: $2,000 ");
            }
            else if ((compNum1 == userNum1 || compNum1 == userNum2 || compNum1 == userNum3)||(compNum2 == userNum1 || compNum2 == userNum2 || compNum2 == userNum3)||(compNum3 == userNum1 || compNum3 == userNum2 || compNum3 == userNum3))
            {
                 Console.WriteLine("YOU WON THIRD PRICE AWARD: $1,000 ");
            }
            else
            {
                Console.WriteLine("TRY AGAIN!!!");
            }

        }
    }
}
