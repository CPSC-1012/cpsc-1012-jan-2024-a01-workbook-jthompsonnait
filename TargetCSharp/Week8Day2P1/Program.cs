

try
{
Console.WriteLine("---  Total Change From Your Pockets  ---");
bool isInteger = false;
int pennies = 0;
int nickels = 0;
int dimes = 0;
int quarters = 0;
int loonies = 0;
int twoonies = 0;
do
{
    Console.Write("Please enter in total pennies: ");
    isInteger = int.TryParse(Console.ReadLine(), out pennies);
    if (!isInteger)
    {
        Console.WriteLine("Please enter a valid number");
    }
} while (!isInteger);
do
{
    Console.Write("Please enter in total nickels: ");
    isInteger = int.TryParse(Console.ReadLine(), out nickels);
    if (!isInteger)
    {
        Console.WriteLine("Please enter a valid number");
    }
} while (!isInteger);
do
{
    Console.Write("Please enter in total dimes: ");
    isInteger = int.TryParse(Console.ReadLine(), out dimes);
    if (!isInteger)
    {
        Console.WriteLine("Please enter a valid number");
    }
} while (!isInteger);
do
{
    Console.Write("Please enter in total quarters: ");
    isInteger = int.TryParse(Console.ReadLine(), out quarters);
    if (!isInteger)
    {
        Console.WriteLine("Please enter a valid number");
    }
} while (!isInteger);
do
{
    Console.Write("Please enter in total loonies: ");
    isInteger = int.TryParse(Console.ReadLine(), out loonies);
    if (!isInteger)
    {
        Console.WriteLine("Please enter a valid number");
    }
} while (!isInteger);
do
{
    Console.Write("Please enter in total twoonies: ");
    isInteger = int.TryParse(Console.ReadLine(), out twoonies);
    if (!isInteger)
    {
        Console.WriteLine("Please enter a valid number");
    }
} while (!isInteger);

double total = GetTotal(pennies, nickels, dimes, quarters, loonies, twoonies);

Console.WriteLine($"The total of your pocket changes is {total}");
}
catch (ArgumentException e)
{
    Console.WriteLine($"Calculation failed: {e.Message}");
}

Console.ReadLine();
static double GetTotal(int pennies, int nickels, int dimes, int quarters, int loonies, int twoonies)
{
    if (pennies < 0 || nickels < 0 ||
        dimes < 0 || quarters < 0 ||
        loonies < 0 || twoonies < 0)
    {
        throw new AggregateException("At least 1 coin value was less than 0");
    }
    double runningTotal = pennies * .1 + nickels * .05 + dimes * .10 + quarters * .25 + loonies + twoonies * 2;
    return runningTotal;
}