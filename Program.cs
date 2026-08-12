namespace CalculatorInnlevering;

class Program
{
    static void Main(string[] args)
    {
        Calculator calculator = new Calculator();
        bool calculatorRunning = true;

        Console.WriteLine("Calculator");

        while (calculatorRunning)
        {
            Console.WriteLine("Week3 calculator menu");
            Console.WriteLine("1. New calculation");
            Console.WriteLine("2. Exit");
            Console.WriteLine("Velg enten 1 eller 2:");

            if (int.TryParse(Console.ReadLine(), out int menuInput))
            {
                if (menuInput == 1)
                {
                    Console.WriteLine("Enter calculation:");
                    Console.WriteLine("Example: '10 + 15 + 30'");

                    string input = Console.ReadLine() ?? "";

                    input = input
                    .Replace("+", " + ")
                    .Replace("-", " - ")
                    .Replace("*", " * ")
                    .Replace("/", " / ")
                    .Replace("%", " % ");

                    string[] parts = input.Split(
                        ' ',
                        StringSplitOptions.RemoveEmptyEntries
                    );
                    bool validInput = true;

                    List<double> numbers = new List<double>();
                    string operatorInput = "";

                    foreach (string part in parts)
                    {
                        if (double.TryParse(part, out double number))
                        {
                            numbers.Add(number);
                        }
                        else if (
                            part == "+" ||
                            part == "-" ||
                            part == "*" ||
                            part == "/" ||
                            part == "%"
                        )
                        {
                            if (operatorInput == "")
                            {
                                operatorInput = part;
                            }
                            else if (operatorInput != part)
                            {
                                Console.WriteLine("You must use the same operator for the entire calculation.");

                                validInput = false;
                            }
                        }
                        else
                        {
                            Console.WriteLine($"Invalid input: {part}");
                            validInput = false;
                        }
                    }

                    if (numbers.Count < 2)
                    {
                        Console.WriteLine("You must enter at least two numbers.");
                        validInput = false;
                    }

                    if (operatorInput == "")
                    {
                        Console.WriteLine("You must enter an operator.");
                        validInput = false;
                    }

                    if (validInput)
                    {
                        double result;

                        if (numbers.Count == 2)
                        {
                            result = calculator.Calculate(
                                numbers[0],
                                numbers[1],
                                operatorInput
                            );
                        }
                        else
                        {
                            result = calculator.Calculate(
                                numbers,
                                operatorInput
                            );
                        }

                        Console.WriteLine($"Result: {result}");
                        Console.WriteLine("Press a button...");
                        Console.ReadKey();
                    }
                }
                else if (menuInput == 2)
                {
                    calculatorRunning = false;
                }
                else
                {
                    Console.WriteLine("You must choose 1 or 2.");
                }
            }
            else
            {
                Console.WriteLine("You must enter a number.");
            }

        }
    }
}