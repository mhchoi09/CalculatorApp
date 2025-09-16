using System;

namespace SampleCalculator.Services;

public class Data
{
    public required List<decimal> InputNumber { get; set; }

    public required Operations Operations { get; set; }

    public decimal Result { get; set; }

}
