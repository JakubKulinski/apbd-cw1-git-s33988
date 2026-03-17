Console.WriteLine("Enter first number:");
string firstInput = Console.ReadLine();

Console.WriteLine("Enter second number:");
string secondInput = Console.ReadLine();

int firstNumber = int.Parse(firstInput);
int secondNumber = int.Parse(secondInput);

int sum = StatisticsHelper.Sum(firstNumber, secondNumber);
double average = StatisticsHelper.Average(firstNumber, secondNumber);

Console.WriteLine($"Sum: {sum}");
Console.WriteLine($"Average: {average}");