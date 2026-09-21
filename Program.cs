using static System.Console;

try
{
    Write("Enter a number between 0 and 255: ");
    int number1 = int.Parse(ReadLine()!);

    Write("Enter another number between 0 and 255: ");
    int number2 = int.Parse(ReadLine()!);

    WriteLine($"{number1} divided by {number2} is {number1 / number2}");
}
catch (FormatException)
{
    WriteLine("Please enter valid numbers.");
}
catch (DivideByZeroException)
{
    WriteLine("You cannot divide by zero.");
}
