//1. Find the sum of the squares of the integers from 1 to MySquare, where MySquare is input by the 
//user. E.g. user enters 4 then return 1x1 + 2x2 + 3x3 + 4x4 = 30
int num = 0;
int num2 = 0;
int squareValue = 0;
Console.Write("Please enter in a number: ");
num = int.Parse(Console.ReadLine());
num2 = num;
string runningValues = "$User enters {num} then return ";
while (num > 0)
{
    squareValue = squareValue + num * num;
    runningValues = runningValues + $"{num} * {num}";
    num = num - 1;
    if (num != 0)
    {
        runningValues = runningValues + " + ";
    }
}
Console.WriteLine($"Square Total = {squareValue}");
Console.WriteLine($"{runningValues} = {squareValue}");
Console.WriteLine();
Console.WriteLine();
squareValue = 0;
do
{
    squareValue = squareValue + num2 * num2;
    num2 = num2 - 1;
} while (num2 > 0);
Console.Write($"Square Total 2 = {squareValue}");
