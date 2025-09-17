namespace SampleCalculator.Services
{
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

        public static decimal Multiplication(List<decimal> inputs)
        {
            var product = inputs[0];

            for (var i = 1; i < inputs.Count; i++)
            {
                product *= inputs[i];
            }

            return product;
        }

        public static decimal Division(List<decimal> inputs)
        {
            var quotient = inputs[0];

            for (var i = 1; i < inputs.Count; i++)
            {
                try
                {
                    quotient /= inputs[i];
                }
                catch (DivideByZeroException e)
                {
                    throw new DivideByZeroException("Attempted to divide by zero.", e);
                }
            }

            return quotient;
        }
    }
}