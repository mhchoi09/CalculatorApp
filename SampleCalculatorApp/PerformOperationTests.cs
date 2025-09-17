using SampleCalculator.Services;

namespace SampleCalculatorApp
{
    public class PerformOperationTests
    {
        [Fact]
        public void Addition_AddsTwoPositiveNumber_ReturnsResult()
        {
            // Arrange
            var inputNumbers = new List<decimal>
            {
                1, 2, 3, 4
            };
            var expectedResult = 10;

            // Act
            var result = PerformOperation.Add(inputNumbers);

            // Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void Subtraction_SubtractTwoPositiveNumbers_ReturnsResult()
        {
            // Arrange
            var inputNumbers = new List<decimal>
            {
                10, 7
            };
            var expectedResult = 3;

            // Act
            var result = PerformOperation.Subtract(inputNumbers);

            // Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void Subtraction_SubtractLargerNumberToLowerNumber_ReturnsNgeativeResult()
        {
            // Arrange
            var inputNumbers = new List<decimal>
            {
                1, 2
            };
            var expectedResult = -1;

            // Act
            var result = PerformOperation.Subtract(inputNumbers);

            // Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void Subtraction_SubtractMultipleNumberFromLowestToHighest_ReturnsNgeativeResult()
        {
            // Arrange
            var inputNumbers = new List<decimal>
            {
                1, 2, 3
            };
            var expectedResult = -4;

            // Act
            var result = PerformOperation.Subtract(inputNumbers);

            // Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void Multiplication_MultiplyTwoNumbers_ReturnsResult()
        {
            // Arrange
            var inputNumbers = new List<decimal>
            {
                3, 2
            };
            var expectedResult = 6;

            //Act
            var result = PerformOperation.Multiplication(inputNumbers);

            //Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void Division_DivideTwoNumber_ReturnsResults()
        {
            // Arrange
            var inputNumbers = new List<decimal>
            {
                6, 2
            };
            var expectedResult = 3;

            //Act
            var result = PerformOperation.Division(inputNumbers);

            //Assert
            Assert.Equal(expectedResult, result);
        }

            [Fact]
        public void Division_DivideByZero_ReturnsDivideByZeroException()
        {
            // Arrange
            var inputNumbers = new List<decimal>
            {
                6, 0
            };

            //Act
            Assert.Throws<DivideByZeroException>(() => PerformOperation.Division(inputNumbers));
        }
    }
}
