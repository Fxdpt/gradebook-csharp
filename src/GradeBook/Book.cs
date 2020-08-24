using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Book
    {
        private string bookName { get; set; }
        private List<double> grades { get; set; }

        public Book(string bookName)
        {
            this.grades = new List<double>() { };
            this.bookName = bookName;
        }
        public void showStatistics()
        {
            Statistics stats = this.getStatistics();

            Console.WriteLine($"{this.bookName}");
            Console.WriteLine("==============================");
            Console.WriteLine($"The average grade is {stats.average:N1}");
            Console.WriteLine($"The highest grade is {stats.high:N1}");
            Console.WriteLine($"The lowest grade is {stats.low:N1}");
        }

        public Statistics getStatistics()
        {
            return new Statistics(this.grades);
        }

        public void addGrade(double grade)
        {
            this.grades.Add(grade);
        }
    }
}
