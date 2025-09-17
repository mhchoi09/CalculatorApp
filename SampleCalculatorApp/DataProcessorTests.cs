using System;
using SampleCalculator.Services;

namespace SampleCalculatorApp.Tests;

public class DataProcessorTests
{
    [Fact]
    public void InputData_WithAddition_ReturnsCorrectData()
    {
        // Arrange
        var numbers = new List<decimal>
        {
            1, 2, 3
        };
        var expectedResult = 6;

        var inputData = new Input
        {
            InputData = new InputData
            {
                Numbers = numbers,
                Operation = Operations.Add
            }
        };

        DataProcessor processInput = new DataProcessor();

        // Act
        var data = processInput.ProcessInput(inputData);

        // Then
        Assert.Equal(data.InputNumber, inputData.InputData.Numbers);
        Assert.Equal(data.Operations, inputData.InputData.Operation);
        Assert.Equal(data.Result, expectedResult);
    }
}
