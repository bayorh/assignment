using System;
using System.Collections.Generic;

namespace bestStudent
{
    class Program
    {
        static void Main(string[] args)
        {
              Console.WriteLine("nos of entries");
            int amountOfEntries = int.Parse(Console.ReadLine());
            var studentGrade = new Dictionary<string,double>();
            for (int i = 0; i < amountOfEntries; i++)
            {
                Console.WriteLine("student name \'press enter\' then  score" );
                string studentName = Console.ReadLine();
                double studentscore=double.Parse(Console.ReadLine());
                studentGrade[studentName] = studentscore;
            }
            double max=0;
            string name = string.Empty;
            double score = 0.0;

            foreach (KeyValuePair<string,double> student in studentGrade)
            {
                if (student.Value > max)
                {
                max = student.Value;
            
                name = student.Key;
                score = student.Value;
                } 
            }
            Console.WriteLine(" best student");
            Console.WriteLine($" {name}  {score}  ");
        }
    }
}
