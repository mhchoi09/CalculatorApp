namespace SampleCalculator.Services;

public static class DataProcessor
{
    public static Data ProcessInput(Input input)
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
                data.Result = PerformOperation.Subtract(data.InputNumber);
                break;
            case Operations.Multiply:
                data.Result = PerformOperation.Multiplication(data.InputNumber);
                break;
            case Operations.Divide:
                data.Result = PerformOperation.Division(data.InputNumber);
                break;
            default:
                throw new InvalidOperationException("Unsupported operation.");
        }

        return data;
    }
}
