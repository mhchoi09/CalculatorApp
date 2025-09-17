using SampleCalculator.Services;
using Xunit;

namespace SampleCalculatorApp;

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
}
