using System.IO.Pipelines;

namespace CalculatorInnlevering;

class Program
{
    static void Main(string[] args)
    {
        bool calculatorRunning = true;
        Console.WriteLine("Calculator");
        while (calculatorRunning)
        {
            Console.WriteLine("Week3 calculator menu");
            Console.WriteLine("1. New calculations");
            Console.WriteLine("2. Exit");
            Console.WriteLine("Velg enten 1 eler 2:");

            if (int.TryParse(Console.ReadLine(), out int menuInput))
            {
                if (menuInput == 1)
                {
                    Console.WriteLine("Please enter you first number:");
                    int firstNumbersInput = int.Parse(Console.ReadLine() ?? "");

                    Console.WriteLine("Please enter operator you want to use:");
                    string operatorInput = Console.ReadLine() ?? "";

                    Console.WriteLine("Please enter your second number:");
                    int secoundNumberInput = int.Parse(Console.ReadLine() ?? "");

                    double result = 0;

                    if (operatorInput == "+")
                    {
                        result = firstNumbersInput + secoundNumberInput;
                    }
                    else if (operatorInput == "-")
                    {
                        result = firstNumbersInput - secoundNumberInput;
                    }
                    else if (operatorInput == "*")
                    {
                        result = firstNumbersInput * secoundNumberInput;
                    }
                    else if (operatorInput == "/")
                    {
                        result = firstNumbersInput / secoundNumberInput;
                    }
                    else if (operatorInput == "%")
                    {
                        result = firstNumbersInput % secoundNumberInput;
                    }
                    else
                    {
                        Console.WriteLine("Must enter a valid operator...");
                    }
                    Console.WriteLine($"Result: {firstNumbersInput} {operatorInput} {secoundNumberInput} = {result}");
                    Console.WriteLine("Press a button...");
                    Console.ReadKey();
                }
                else if (menuInput == 2)
                {
                    calculatorRunning = false;
                    break;
                }
                else
                {
                    Console.WriteLine("Must enter 1 or 2....");
                }
            }
            else
            {
                Console.WriteLine("Must enter a number...");
            }
        }
    }
}
