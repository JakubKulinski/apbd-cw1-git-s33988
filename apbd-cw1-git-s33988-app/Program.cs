Console.WriteLine("Enter first number:");
string firstInput = Console.ReadLine();

Console.WriteLine("Enter second number:");
string secondInput = Console.ReadLine();

bool firstParsed = int.TryParse(firstInput, out int firstNumber);
bool secondParsed = int.TryParse(secondInput, out int secondNumber);

if (!firstParsed || !secondParsed)
{
    Console.WriteLine("Invalid input. Please enter valid integers.");
    return;
}

int sum = StatisticsHelper.Sum(firstNumber, secondNumber);
double average = StatisticsHelper.Average(firstNumber, secondNumber);

Console.WriteLine($"Sum: {sum}");
Console.WriteLine($"Average: {average}");