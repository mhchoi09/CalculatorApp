using System.Text.RegularExpressions;
using SampleCalculator.Services;

namespace SampleCalculator.ConsolApp
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            var keepRunning = true;

            while (keepRunning)
            {
                Console.WriteLine("Welcome to the Sample Calculator App!");

                Input inputData = new Input();
                PerformOperation performOperation = new PerformOperation();

                inputData.InputData = new InputData();
                inputData.InputData.Numbers = new List<decimal>();

                Console.WriteLine("Enter a number or arithemtic operation (X to exit):");

                var inputValue = Console.ReadLine();
                Regex mathOperators = new Regex("[+\\-\\*\\/]");

                if (decimal.TryParse(inputValue, out decimal number))
                {
                    inputData.InputData.Numbers.Add(number);
                }
                else if (inputValue?.ToUpper() == "X")
                {
                    keepRunning = false;
                    Console.WriteLine("Exiting the calculator. Goodbye!");
                    continue;
                }
                else if (mathOperators.IsMatch(inputValue) && inputData.InputData.Numbers.Any())
                {
                    
                }
             
            }
        }
    }
}
