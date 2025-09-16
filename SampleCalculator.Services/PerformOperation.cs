using System.Net;

namespace SampleCalculator.Services;

public class PerformOperation
{
    public static int Add(int a, int b)
    {
        return a + b;
    }
    public static int Subtract(int a, int b)
    {
        return a - b;
    }

    public static int Multiply(int a, int b)
    {
        return a * b;
    }

    public static int Divide(int a, int b)
    {
        try
        {
            var result = a / b;

            return result;
        }
        catch (DivideByZeroException)
        {
            throw new DivideByZeroException("Cannot divide by zero.");
        }
    }
}
