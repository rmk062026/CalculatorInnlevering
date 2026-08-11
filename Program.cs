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
                    // Calculator.Calculator();
                    Console.WriteLine("Calculator will be here.. TODO");
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
