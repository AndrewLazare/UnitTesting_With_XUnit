using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoLibrary;
using Xunit;

namespace Library.Tests
{
    public class CalculatorTests
    {
        /// <summary>
        /// ADD TESTING FOR CALC
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="expected"></param>
        [Theory]
        [InlineData(4,3,7)]
        [InlineData(21, 5.25, 26.25)]
        [InlineData(double.MaxValue, 5.25, double.MaxValue)]

        public void Add_SimpleValuesShouldCalculate(double x, double y, double expected)
        {
            //Arramge


            //Act
            double actual = Calculator.Add(x, y);


            //Assert
            Assert.Equal(expected, actual);
        }

        /// <summary>
        /// Subtraction TESTING FOR CALC
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="expected"></param>

        [Fact]
        public void Subtract_SimpleValuesShouldCalculate()
        {
            //Arramge
            double expected = 7;


            //Act
            double actual = Calculator.Subtract(14, 7);


            //Assert
            Assert.Equal(expected, actual);
        }

        /// <summary>
        /// Multiplication TESTING FOR CALC
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="expected"></param>
        [Fact]
        public void Multiply_SimpleValuesShouldCalculate()
        {
            //Arramge
            double expected = 10;


            //Act
            double actual = Calculator.Multiply(2, 5);


            //Assert
            Assert.Equal(expected, actual);
        }

        /// <summary>
        /// Division TESTING FOR CALC
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="expected"></param>

        [Theory]
        [InlineData(8, 4, 2)]
        public void Divide_SimpleValuesShouldCalculate(double x, double y, double expected)
        {
            // Arrange

            // Act
            double actual = Calculator.Divide(x, y);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Divide_DivideByZero()
        {
            // Arrange
            double expected = 0;

            // Act
            double actual = Calculator.Divide(15, 0);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
