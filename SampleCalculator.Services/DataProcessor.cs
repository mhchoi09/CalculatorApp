using System;
using SampleCalculator.Services;

namespace SampleCalculator.Services;

public class DataProcessor
{
    public Data ProcessInput(Input input)
    {
        if (input == null || input.InputData == null || input.InputData.Numbers == null || !input.InputData.Numbers.Any())
        {
            throw new ArgumentException("Input data is invalid.");
        }

        var data = new Data
        {
            InputNumber = input.InputData.Numbers.Select(n => n).ToList(),
            Operations = input.InputData.Operation
        };

        switch (data.Operations)
        {
            case Operations.Add:
                data.Result = PerformOperation.Add(data.InputNumber);
                break;
            case Operations.Subtract:
                data.Result = data.InputNumber.Aggregate((a, b) => a - b);
                break;
            default:
                throw new InvalidOperationException("Unsupported operation.");
        }

        return data;
    }
}
