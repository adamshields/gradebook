using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Book
    {
        public Book(string name)
        {
            category = "";
            grades = new List<double>();
            Name = name;
        }

        public void AddGrade(char letter) // Overloading Methods - AddGrade(char letter)
        {
            switch (letter)
            {
                case 'A':
                    AddGrade(90);
                    break;
                
                case 'B':
                    AddGrade(80);
                    break;

                case 'C':
                    AddGrade(70);
                    break;

                case 'D':
                    AddGrade(60);
                    break;

                default:
                    AddGrade(0);
                        break;
            }
        }

        /* 
        # Overloading Methods allows me to use the same method name because each method is actually different with it's type and parameter
        # C# Compiler Actually looks at the method and what is contained within the method example a double, a char + paramaters
        */ 
        public void AddGrade(double grade) // Overloading Methods - AddGrade(double letter)
        {
            if(grade <= 100 && grade >=0)
            {
                grades.Add(grade);
            }
            else
            {
                throw new ArgumentException($"Invalid {nameof(grade)}");
            }
        }

        public Statistics GetStatistics()
        {
            var result = new Statistics();
            result.Average = 0.0;
            result.High = double.MinValue;
            result.Low = double.MaxValue;

            for(var index = 0; index < grades.Count; index += 1)
            {
                result.Low = Math.Min(grades[index], result.Low);
                result.High = Math.Max(grades[index], result.High);
                result.Average += grades[index];
            }
            result.Average /= grades.Count;
            
            switch(result.Average)
            {
                case var d when d >= 90.0:
                    result.Letter = 'A';
                    break;

                case var d when d >= 80.0:
                    result.Letter = 'B';
                    break;

                case var d when d >= 70.0:
                    result.Letter = 'C';
                    break;
                    
                case var d when d >= 60.0:
                    result.Letter = 'D';
                    break;

                default:
                    result.Letter ='F';
                    break;
                    
            }
            
            return result;
        }
        private List<double> grades;

        /*
        DEFINING PROPERTIES
        - Similar to Field
        - can encapsulate state 
        - can store data for an object
        */

        // controling access to get and set on property
        public string Name
        {
            get; 
            set;
        }

        public const string CATEGORY = "Science";
        // const fields are static members
    }
}