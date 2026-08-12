namespace CalculatorInnlevering;

public class Calculator
{
    //  OverLoad 1 - 2 tall
    public double Calculate(
        double firstNumber,
        double secoundNumber,
        string operatorInput)
    {
        double result = 0;
        switch (operatorInput)
        {
            case "+":
                result = firstNumber + secoundNumber;
                break;

            case "-":
                result = firstNumber - secoundNumber;
                break;

            case "*":
                result = firstNumber * secoundNumber;
                break;

            case "/":
                result = firstNumber / secoundNumber;
                break;

            case "%":
                result = firstNumber % secoundNumber;
                break;

            default:
                Console.WriteLine("Invalid operator!");
                break;

        }
        return result;

    }

    // Overload 2 - flere tall
    public double Calculate(
        List<double> numbers,
        string operatorInput)
    {
        double result = numbers[0];

        for (int i = 1; i < numbers.Count; i++)
        {
            switch (operatorInput)
            {
                case "+":
                    result += numbers[i];
                    break;

                case "-":
                    result -= numbers[i];
                    break;

                case "*":
                    result *= numbers[i];
                    break;

                case "/":
                    result /= numbers[i];
                    break;

                case "%":
                    result %= numbers[i];
                    break;
            }

        }
        return result;
    }
}
