using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Book
    {
        public Book(string name)
        {
            grades = new List<double>();
            Name = name;
        }
        public void AddGrade(double grade)
        {
            if(grade <= 100 && grade >=0)
            {
                grades.Add(grade);
            }
            else
            {
                Console.WriteLine("invalid Value");
            }
            
        }

        public Statistics GetStatistics()
        {
            var result = new Statistics();
            result.Average = 0.0;
            result.High = double.MinValue;
            result.Low = double.MaxValue;

            var index = 0;
            while(index < grades.Count)
            {
                result.Low = Math.Min(grades[index], result.Low);
                result.High = Math.Max(grades[index], result.High);
                result.Average += grades[index];
                index += 1;
                // index ++; // same as above index += 1;
            };
            result.Average /= grades.Count;

            return result;
        }
        private List<double> grades;
        public string Name;
    }
}