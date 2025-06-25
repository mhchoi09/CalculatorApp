using SampleCalculator.Services;


Console.WriteLine("Welcome to the Sample Calculator App!");
Console.WriteLine("Please enter the first number:");
var firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please enter the second number:");
var secondNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please choose an operation: +, -, *, /");
string operation = Console.ReadLine();
switch (operation)
{
    case "+":
        Console.WriteLine($"Result: {Operations.Add(firstNumber, secondNumber)}");
        break;
    case "-":
        Console.WriteLine($"Result: {Operations.Subtract(firstNumber, secondNumber)}");
        break;
    case "*":
        Console.WriteLine($"Result: {Operations.Multiply(firstNumber, secondNumber)}");
        break;
    case "/":
        try
        {
            Console.WriteLine($"Result: {Operations.Divide(firstNumber, secondNumber)}");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine(ex.Message);
        }
        break;
    default:
        Console.WriteLine("Invalid operation selected.");
        break;
}   