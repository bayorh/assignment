using System;

namespace eversingDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ENTER  YOUR DIGIT");
            int input = int.Parse(Console.ReadLine());
            string output = ReverseDigit(input); 
            Console.WriteLine($"reverse of{input} is {output} ");


        }
        static string ReverseDigit(int digit)
        {
            string saveDigit;
            saveDigit =digit.ToString();
           string digitreversal= string.Empty;
            
            int digitlength = saveDigit.Length;
            Console.WriteLine(digitlength);
            char[] textDigit = new char[digitlength];


            for (int i =0;i< digitlength ; i++)
            {
                textDigit[i]=saveDigit[i];
            }
            for (int i = digitlength-1; i >=0 ; i--)
            {
                digitreversal+=textDigit[i];
            }
            return digitreversal;
        }
    }
}
