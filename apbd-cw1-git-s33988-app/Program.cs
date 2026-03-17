Console.WriteLine("Enter first number:");
string firstInput = Console.ReadLine();

Console.WriteLine("Enter second number:");
string secondInput = Console.ReadLine();

bool firstParsed = int.TryParse(firstInput, out int firstNumber);
bool secondParsed = int.TryParse(secondInput, out int secondNumber);

if (!firstParsed || !secondParsed)
{
    Console.WriteLine("Invalid input. Please enter two integer values.");
    return;
}

int sum = StatisticsHelper.Sum(firstNumber, secondNumber);
double average = StatisticsHelper.Average(firstNumber, secondNumber);
double calculatedAverage = StatisticsHelper.CalculateAverage(new int[] { firstNumber, secondNumber });
int min = StatisticsHelper.CalculateMin(new int[] { firstNumber, secondNumber });

Console.WriteLine($"Sum: {sum}");
Console.WriteLine($"Average: {average}");
Console.WriteLine($"Calculated average from array: {calculatedAverage}");
Console.WriteLine($"Min: {min}");