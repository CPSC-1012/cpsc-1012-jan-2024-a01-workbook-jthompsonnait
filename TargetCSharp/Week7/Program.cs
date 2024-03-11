using System.Xml.Linq;

int[] numbers = new int[5];

numbers[0] = 10;
numbers[1] = 20;
numbers[2] = 30;
numbers[3] = 40;
numbers[4] = 50;

Console.WriteLine("For Loop");

for (int i = 0; i < numbers.Length; i++)
{
    Console.WriteLine(numbers[i]);
}
Console.WriteLine();

Console.WriteLine("Foreach");
foreach (int number in numbers)
{
    Console.WriteLine(number);
}
Console.WriteLine();
string[] names = {"James", "Bob", "Sue"};
double[] myDoubles = { 12, 47.23, 99.1, 102832.2 };
foreach (string name in names)
{
    Console.WriteLine(name);
}

foreach (double mydoubles in myDoubles)
{
    Console.WriteLine(mydoubles);
}
Console.WriteLine(names.Length);
Console.WriteLine(names[1]);
//Console.WriteLine(names[4]);






