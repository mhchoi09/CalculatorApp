using System.Data.Common;
using System.Net;

namespace SampleCalculator.Services;

public static class PerformOperation
{
    public static decimal Add(List<decimal> inputs)
    {
        var sum = (decimal)0;

        foreach (var input in inputs)
        {
            sum += input;
        }

        return sum;
    }

    public static decimal Subtract(List<decimal> inputs)
    {
        var difference = inputs[0];

        for (var i = 1; i < inputs.Count; i++)
        {
            difference -= inputs[i];
        }

        return difference;
    }
}
