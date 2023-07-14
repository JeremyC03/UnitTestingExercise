using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)] //Add test data <-------
        [InlineData(-5, 10, 2, 7)]
        [InlineData(1, -3, -3, -5)]
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            // create a Calculator object
            Calculator addNumbers = new Calculator(); 

            //Act
                // call the Add method that is located in the Calculator class
                // and store its result in a variable named actual
            int actual = addNumbers.Add(num1, num2, num3);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(6, 2, 4)]//Add test data <-------
        [InlineData(3, -6, 9)]
        [InlineData(1, 6, -5)]
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Start Step 5 here:

            //Arrange
            Calculator subtractNumbers = new Calculator();
            //Act
            int actual = subtractNumbers.Subtract(minuend, subtrhend);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(5, 4, 20)]//Add test data <-------
        [InlineData(-2, -5, 10)]
        [InlineData(-1, 3, -3)]
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:
            Calculator multiplyNumbers = new Calculator();
            //Arrange
            int actual = multiplyNumbers.Multiply(num1, num2);
            //Act
            Assert.Equal(expected, actual);
            //Assert

        }

        [Theory]
        [InlineData(10, 5, 2)]//Add test data <-------
        [InlineData(-6, -3, 2)]
        [InlineData(-4, 1, -4)]
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            Calculator divideNumbers = new Calculator();
            //Act
            int actual = divideNumbers.Divide(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

    }
}
