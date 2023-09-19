using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)]
        [InlineData(5, 5, 10, 20)]
        [InlineData(10,5, 10, 25)]
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            var calculatorInstance = new Calculator();

            //Act
            var actual = calculatorInstance.Add(num1, num2, num3);

            //Assert
                Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(5,5,0)]
        [InlineData(10,5,5)]
        [InlineData(20,10,10)]
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Start Step 5 here:

            //Arrange
            var calculatorInstance = new Calculator();
            //Act
            var actual = calculatorInstance.Subtract(minuend, subtrhend);
            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(5,5,25)]
        [InlineData(10,10,100)]
        [InlineData(1,3,3)]
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange
            var calculatorInstace = new Calculator();
            //Act
            var actual = calculatorInstace.Multiply(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(10, 2, 5)]
        [InlineData(24, 6, 4)]
        [InlineData(100, 10, 10)]
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            var calculatorInstance = new Calculator();
            //Act
            var actual = calculatorInstance.Divide(num1, num2);
            //Assert
            Assert.Equal(expected , actual);
        }

    }
}
