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
        var difference = (decimal)0;

        foreach (var input in inputs)
        {
            difference -= difference;
        }

        return difference;
    }
}
