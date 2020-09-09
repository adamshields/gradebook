﻿using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {

            var book = new Book("Adam's Grade Book");
            // Add Grades by prompting for Input



            while (true)
            {
                Console.WriteLine("Enter a grade or 'q' to quit the program");
                var input = Console.ReadLine();

                if(input == "q")
                {
                    break;
                }

                var grade = double.Parse(input);
                book.AddGrade(grade);
            }
            
            
            var stats = book.GetStatistics();
            Console.WriteLine($"The lowest grade is {stats.Low}");
            Console.WriteLine($"The highest grade is {stats.High}");
            Console.WriteLine($"The average grade is {stats.Average:N1}");
            Console.WriteLine($"The letter grade is {stats.Letter}");

        }
    }
}
