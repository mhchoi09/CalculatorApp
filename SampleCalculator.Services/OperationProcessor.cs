using System;
using SampleCalculator.Services;

namespace SampleCalculator.Services;

public class OperationProcessor
{
    public void ProcessInput(Input input)
    {
        if (input == null || input.InputData == null || input.InputData.Numbers == null || !input.InputData.Numbers.Any())
        {
            throw new ArgumentException("Input data is invalid.");
        }

        var data = new Data
        {
            InputNumber = input.InputData.Numbers.Select(n => (decimal)n).ToList(),
            Operations = input.InputData.Operation
        };

        PerformOperation operation = new PerformOperation();
        
        switch (data.Operations)
        {
            case Operations.Add:
                data.Result = data.InputNumber.Sum();
                break;
            case Operations.Subtract:
                data.Result = data.InputNumber.Aggregate((a, b) => a - b);
                break;
            case Operations.Multiply:
                data.Result = data.InputNumber.Aggregate((a, b) => a * b);
                break;
            case Operations.Divide:
                if (data.InputNumber.Contains(0))
                {
                    throw new DivideByZeroException("Cannot divide by zero.");
                }
                data.Result = data.InputNumber.Aggregate((a, b) => a / b);
                break;
            default:
                throw new InvalidOperationException("Unsupported operation.");
        }
    }
}
