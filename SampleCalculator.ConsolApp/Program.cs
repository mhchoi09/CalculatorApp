using System.Text.RegularExpressions;
using SampleCalculator.Services;

namespace SampleCalculator.ConsoleApp
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            var keepRunning = true;

            Console.WriteLine("Welcome to the Sample Calculator App!");

            Input inputData = new Input
            {
                InputData = new InputData
                {
                    Numbers = new List<decimal>()
                }
            };

            DataProcessor performOperation = new DataProcessor();

            while (keepRunning)
            {
                Console.WriteLine("Enter a number or arithemtic operation (X to exit):");

                var inputValueRaw = Console.ReadLine();
                var inputValue = inputValueRaw?.Trim();
                Regex mathOperators = new Regex("[+\\-\\*\\/]");

                if (decimal.TryParse(inputValue, out decimal number))
                {
                    inputData.InputData.Numbers.AddRange(Convert.ToDecimal(number));
                }
                else if (inputValue?.ToUpper() == "X")
                {
                    keepRunning = false;
                    Console.WriteLine("Exiting the calculator. Goodbye!");
                }
                else if (!String.IsNullOrEmpty(inputValue) &&
                mathOperators.IsMatch(inputValue) &&
                inputData.InputData.Numbers.Count != 0)
                {
                    switch (inputValue)
                    {
                        case "+":
                            inputData.InputData.Operation = Operations.Add;
                            break;
                        case "-":
                            inputData.InputData.Operation = Operations.Subtract;
                            break;
                        default:
                            throw new InvalidOperationException("Unsupported Operation. Try again.");
                    }

                    var calculatorData = performOperation.ProcessInput(inputData);
                    Console.WriteLine($"Result: {calculatorData.Result}");
                }

            }
        }
    }
}
