int totalNumberToEnter  = 25;
int[] numbers = new int[totalNumberToEnter];
for (int i = 0; i < totalNumberToEnter; i++)
{
    Console.Write($"Please enter a number for position {i+1}: ");
    numbers[i] = int.Parse( Console.ReadLine() );
   // Console.Clear();
}

int runningTotal = 0;
foreach (var number in numbers)
{
    runningTotal = runningTotal + number;
}

Console.WriteLine($"The total number is {runningTotal} and the mean average is {runningTotal / 25}");
