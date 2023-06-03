using System;
using System.Net.Http.Headers;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)]
        [InlineData(14, 20, 3, 37)]
        [InlineData(4, 1, 38, 43)]//Add test data <-------
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:
            //Arrange
            // create a Calculator object
            Calculator calculator = new Calculator();
            int actual = calculator.Add(num1, num2, num3);
            Assert.Equal(expected, actual);
            //Act
                // call the Add method that is located in the Calculator class
                // and store its result in a variable named actual

            //Assert
                //Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(5, 2, 3)]
        [InlineData(7, 1, 6)]
        [InlineData(-12, -14, 2)]//Add test data <-------
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Start Step 5 here:

            //Arrange
            Calculator calculator = new Calculator();
            //Act
            int actual = calculator.Subtract(minuend, subtrhend);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(5, 6, 30)]
        [InlineData(8, 9, 72)]
        [InlineData(11, 12, 132)]//Add test data <-------
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange
            Calculator calculator = new Calculator();
            //Act
            int actual = calculator.Multiply(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(20, 2, 10)]
        [InlineData(30, 6, 5)]
        [InlineData(40, 10, 4)]//Add test data <-------
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            Calculator calculator = new Calculator();
            //Act
            int actual = calculator.Divide(num1, num2);
            //Assert
            Assert.Equal(expected, actual); 
        }

    }
}
