using System;
using System.Diagnostics.CodeAnalysis;

namespace SampleCalculator.Services
{
    [ExcludeFromCodeCoverage]
    public class Input
    {
        public required InputData InputData;
    }

    [ExcludeFromCodeCoverage]
    public class InputData
    {
        public List<decimal> Numbers { get; set; }

        public Operations Operation { get; set; }
    }
}
