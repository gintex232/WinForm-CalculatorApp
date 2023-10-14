using Xunit;
using CalculatorProject;
using Calculator1;

namespace Calculator1.Tests
{
    public class CalculatorTests
    {
        [Fact]
        public void Test_Addition()
        {
            // Arrange
            Calculator calculator = new Calculator();

            // Act
            double result = calculator.Addition(3, 5);

            // Assert
            Assert.Equal(8, result);
        }

        [Fact]
        public void Test_Subtraction()
        {
            // Arrange
            Calculator calculator = new Calculator();

            // Act
            double result = calculator.Subtraction(10, 4);

            // Assert
            Assert.Equal(6, result);
        }

        [Fact]
        public void Test_Multiplication()
        {
            // Arrange
            Calculator calculator = new Calculator();

            // Act
            double result = calculator.Multiplication(3, 5);

            // Assert
            Assert.Equal(15, result);
        }

        [Fact]
        public void Test_DivisionEquality()
        {
            // Arrange
            Calculator calculator = new Calculator();

            // Act
            double result = calculator.DivisionEquality(12, 3);

            // Assert
            Assert.Equal(4, result);
        }

        [Fact]
        public void Test_DivisionByZero()
        {
            // Arrange
            Calculator calculator = new Calculator();

            // Act & Assert
            Assert.Throws<DivideByZeroException>(() => calculator.DivisionEquality(5, 0));
        }
    }
}
