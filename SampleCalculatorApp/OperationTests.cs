using SampleCalculator.Services;
using Xunit;

namespace SampleCalculatorApp;

public class UnitTest1
{

    private const string DivideByZeroMessage = "Cannot divide by zero.";

    [Fact]
    public void Addition_AddsTwoPositiveNumber_ReturnsResult()
    {
        // Arrange
        int a = 5;
        int b = 3;
        int expected = 8;

        // Act
        int result = Operations.Add(a, b);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Subtraction_SubtractsTwoPositiveNumbers_ReturnsResult()
    {
        // Arrange
        int a = 10;
        int b = 4;
        int expected = 6;

        // Act
        int result = Operations.Subtract(a, b);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Multiplication_MultipliesTwoPositiveNumbers_ReturnsResult()
    {
        // Arrange
        int a = 7;
        int b = 6;
        int expected = 42;

        // Act
        int result = Operations.Multiply(a, b);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Division_DividesTwoPositiveNumbers_ReturnsResult()
    {
        // Arrange
        int a = 20;
        int b = 4;
        int expected = 5;

        // Act
        int result = Operations.Divide(a, b);

        // Assert
        Assert.Equal(expected, result);
    }
    
    [Fact]
    public void Division_DividesByZero_ThrowsDivideByZeroException()
    {
        // Arrange
        int a = 10;
        int b = 0;

        // Act & Assert
        var exception = Assert.Throws<DivideByZeroException>(() => Operations.Divide(a, b));

        Assert.Equal(DivideByZeroMessage, exception.Message);
    }
}
