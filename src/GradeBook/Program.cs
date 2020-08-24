using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> grades = new List<double>() { 12.3845, 85.8654, 76.23215, 32.458, 1.25, 89.648 };
            Book book = new Book("Toto's Grade Book");

            foreach (double grade in grades)
            {
                book.addGrade(grade);
            }
            book.showStatistics();
        }
    }
}
