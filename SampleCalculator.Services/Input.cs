using System.Diagnostics.CodeAnalysis;

namespace SampleCalculator.Services
{
    [ExcludeFromCodeCoverage]
    public class Input
    {
        public required InputData InputData { get; set; }
    }

    [ExcludeFromCodeCoverage]
    public class InputData
    {
        public required List<decimal> Numbers { get; set; }

        public Operations Operation { get; set; }
    }
}
