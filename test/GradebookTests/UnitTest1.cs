using System;
using GradeBookProject;
using Xunit;

namespace GradebookTests
{
    public class UnitTest1
    {
        [Fact]
        public void testStatistics()
        {
            //Arrange
            var bok = new Book("meu primeiro livro");
            bok.addGrade(89.1);
            bok.addGrade(90.5);
            bok.addGrade(77.3);
            //Act
            var result = bok.getStatistics();
            //Assert
            Assert.Equal(85.6,result.average,1);
            Assert.Equal(90.5,result.highGrade,1);
            Assert.Equal(77.3,result.lowGrade,1);
        }
    }
}
