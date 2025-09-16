using System;

namespace SampleCalculator.Services
{
    public class Input
    {
        public InputData InputData;
    }

    public class InputData
    {
        public List<decimal> Numbers { get; set; }

        public Operations Operation { get; set; }
    }
}
