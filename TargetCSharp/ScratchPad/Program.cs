int score = 88;


if (score >= 90)
{
    Console.WriteLine("Grade: A");
}
else if (score >= 80)
{
    Console.WriteLine("Grade: B");
}
else if (score >= 70)
{
    Console.WriteLine("Grade: C");
}
else if (score >= 60)
{
    Console.WriteLine("Grade: D");
}
else
{
    Console.WriteLine("Grade: F");
}

switch (score)
{
    case int currentScore when currentScore >= 90:
        Console.WriteLine("Grade: A");
        break;
    case int currentScore when currentScore >= 80:
        Console.WriteLine("Grade: B");
        break;
    case int currentScore when currentScore >= 70:
        Console.WriteLine("Grade: C");
        break;
    case int currentScore when currentScore >= 60:
        Console.WriteLine("Grade: D");
        break;
    default:
        Console.WriteLine("Grade: F");
        break;
}