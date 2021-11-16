using System;

namespace coinSimulationWithCount
{
    class Program
    {
          static int CoinSideGen(int tossGen)
        {
            int compGen;
            if (tossGen % 2 == 0)
            {
                compGen = 0;
            }
            else
            {
                compGen = 1;
            }

            return compGen;
        }
        static void Main(string[] args)
        {

        Random rdmToss = new Random();
        int tossGen = rdmToss.Next(0, 6);
        Console.WriteLine("enter the number of time to repeat");
        long repeatTime =  long.Parse(Console.ReadLine());
        int countTail=0;
        int countHead=0;
        int[] coinGen =new int[repeatTime];
        for (int i = 0; i < repeatTime; i++)
        {
            coinGen[i] = CoinSideGen(tossGen);
            Console.Write(coinGen[i]+", ");
        }
        foreach (var item in coinGen)
        {
             if(item==0)
            {
            countHead++;
            }
            else if (item==1)
            {
             countTail++;   
            }
        }

          
        Console.WriteLine(" ");
        Console.WriteLine("repeat time of tail is "+ countTail);
        Console.WriteLine("repeat time of head is "+ countHead);
                            
        }
       
    }
}
