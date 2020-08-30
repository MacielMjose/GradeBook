using System;
using GradeBookProject;
using Xunit;

namespace GradebookTests
{
    public class TypeTests
    {  

        [Fact]
        public void passByValue()
        {
            //Arrange
            var x = GetInteger();
            setInteger(x);
            //Act

            //Assert
            Assert.Equal(39,x);
        }

        private int setInteger(int x)
        {
            x = 39;
            return x;
        }

        private int GetInteger() => 3;

        [Fact]
        public void CSharpCanBePassedbyReference()
        {
            //Arrange
            var book = getBook("book1");
            getBookSetNameRef(ref book,"new name");
            //Act

            //Assert
            Assert.Equal("new name",book.Name);
        }

        private void getBookSetNameRef(ref Book book, string name)
        {
            book = new Book(name);
        }

        [Fact]
        public void CSharpIsPassedbyValue()
        {
            //Arrange
            var book = getBook("book1");
            getBookSetName(book,"new name");
            //Act

            //Assert
            Assert.Equal("new name",book.Name);
        }

        private void getBookSetName(Book book, string name)
        {
            book = new Book(name);
        }

        [Fact]
        public void CanSetNameByReference()
        {
            //Arrange
            var book = getBook("book1");
            setName(book,"new name");
            //Act

            //Assert
            Assert.Equal("new name",book.Name);
        }

        private Book setName(Book book, string newName)
        {
            book.Name = newName;
            return book;
        }

        [Fact]
        public void GetBookReturnsDifferentObjects()
        {
            //Arrange
            var book1 = getBook("book1");
            var book2 = getBook("book2");
           
            //Act

            //Assert
            Assert.Equal("book1",book1.Name);
            Assert.Equal("book2",book2.Name);
        }
        [Fact]
        public void TwoVariablesCanReferenceSameObjects()
        {
            //Arrange
            var book1 = getBook("book1");
            var book2 = book1;
            //Act

            //Assert
            Assert.Equal("book1",book1.Name);
            Assert.Same(book1,book2);
        }

        Book getBook(string name)
        {
            return new Book(name);
        }
    }
}