int newScore = 88;

switch (newScore)
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