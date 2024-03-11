HelloWorld();
Prompt("James was here");
Console.WriteLine($"The area of 5 is {CalculateArea(5)}");
Console.ReadLine();
static void HelloWorld()
{
    Console.WriteLine("Hello, World!");
}

static string Prompt(string label)
{
    Console.WriteLine(label);
    return Console.ReadLine();

}

static double CalculateArea(double radius)
{
    return Math.PI * Math.Pow(radius, 2);
}
