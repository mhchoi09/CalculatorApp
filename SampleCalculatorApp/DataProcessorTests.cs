using SampleCalculator.Services;

namespace SampleCalculatorApp.Tests
{
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

            // Act
            var data = DataProcessor.ProcessInput(inputData);

            // Then
            Assert.Equal(data.InputNumber, inputData.InputData.Numbers);
            Assert.Equal(data.Operations, inputData.InputData.Operation);
            Assert.Equal(data.Result, expectedResult);
        }

        [Fact]
        public void InputData_WithNullNumbers_ReturnsException()
        {
            var inputData = new Input
            {
                InputData = new InputData
                {
                    Numbers = new List<decimal>(),
                    Operation = Operations.Add
                }
            };

            // Act
            Assert.Throws<ArgumentException>(() => DataProcessor.ProcessInput(inputData));
        }
    }
}