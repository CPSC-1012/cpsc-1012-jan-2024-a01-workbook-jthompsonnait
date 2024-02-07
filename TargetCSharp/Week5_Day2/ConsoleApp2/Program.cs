// instantiate Random class
Random random = new Random();

// generate a random number
int n = random.Next(0, 2);
int userValue = 0;
Console.Write("Please enter either Heads or Tails: ");


if (Console.ReadLine() == "Tails")
{
    userValue = 1;
}

if (userValue == n)
{
    Console.WriteLine("You were correct");
}
else
{
    Console.WriteLine("You were incorrect");
}

Console.ReadKey();
//userValue = (Console.ReadLine() == "Head") ? 0 : 1;