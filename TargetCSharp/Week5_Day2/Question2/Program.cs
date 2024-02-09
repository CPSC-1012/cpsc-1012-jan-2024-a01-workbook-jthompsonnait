//  Write a program to determine if a user input year is a leap year.
// A year is a leap year if it is
//  - divisible by 4
//  - not divisible by 100, or
//  - if it is divisible by 400.

int year = 0;
Console.Write("Enter a year: ");
if (!int.TryParse(Console.ReadLine(), out year))
{
    Console.WriteLine("Invalid year");
}
else
{
    if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
    {
        Console.WriteLine($"{year} is a leap year");
    }
    else
    {
        Console.WriteLine($"{year} is not a leap year");
    }
}


