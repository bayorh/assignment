﻿using System;
using System.Collections.Generic;

namespace top2studentSelector
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
            double max2 = 0;
            string name = string.Empty;
            double score = 0.0;
            string name2 = string.Empty;
            double score2 = 0.0;

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
            foreach (KeyValuePair<string,double> student2 in studentGrade)
            {
                
                    if (student2.Value > max2 && student2.Key != name)
                    {
                        max2 =student2.Value;
                        name2 = student2.Key;
                        score2 = student2.Value;
                    }
            }
          
            Console.WriteLine("seciond best student");
            Console.WriteLine($" {name2}  {score2}  ");
            
        }
    }
}
