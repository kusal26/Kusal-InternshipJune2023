namespace ConsoleApp;

public class DayOne
{
    /// <summary>
    /// Create a function that takes two numbers as arguments and returns their sum.
    /// </summary>
    /// <example>
    /// Sum(3, 2) ➞ 5
    /// Sum(-3, -6) ➞ -9
    /// Sum(7, 3) ➞ 10
    /// </example>
    public void Sum(int firstNumber, int secondNumber)
    {
        var result = firstNumber + secondNumber;

        Console.WriteLine($"The sum of {firstNumber} and {secondNumber} is {result}");
    }
}
