using System;
using Xunit;

namespace GradeBook.Tests
{
    public class BookTests
    {
        [Fact]
        public void Test1()
        {
            Book book = new Book("");
            book.addGrade(89.1);
            book.addGrade(54.3);
            book.addGrade(77.7);

            Statistics result = book.getStatistics();

            Assert.Equal(89.1, result.high);
            Assert.Equal(54.3, result.low);
            Assert.Equal(73.7, result.average, 1);
        }
    }
}
