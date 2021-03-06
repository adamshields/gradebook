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
            book.GradeAdded += OnGradeAdded;
            while (true)
            {
                Console.WriteLine("Enter a grade or 'q' to quit the program");
                var input = Console.ReadLine();

                if(input == "q")
                {
                    break;
                }

            try
            {
                var grade = double.Parse(input);
                book.AddGrade(grade);
            }
            catch(ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("**"); // this will always run example ** shows up under the input
            }


            }
            
            
            var stats = book.GetStatistics();
            Console.WriteLine(Book.CATEGORY);
            Console.WriteLine($"For the book named {book.Name}"); // get .Name property
            Console.WriteLine($"The lowest grade is {stats.Low}");
            Console.WriteLine($"The highest grade is {stats.High}");
            Console.WriteLine($"The average grade is {stats.Average:N1}");
            Console.WriteLine($"The letter grade is {stats.Letter}");

        }

        static void OnGradeAdded(object sender, EventArgs e)
        {
            Console.WriteLine("A Grade was Added!");
        }
    }
}
