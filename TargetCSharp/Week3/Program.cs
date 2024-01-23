string name;
DateTime birthdate;
int ageInDay;

Console.Write("What is your name? ");
name  = Console.ReadLine();

Console.Write("What is your birthday (yyyy-mm-dd)? ");
birthdate = DateTime.Parse(Console.ReadLine());
ageInDay = (DateTime.Now - birthdate).Days;

Console.WriteLine(name + " your birthday of " + birthdate.ToShortDateString() + " is " + ageInDay + " days old");
Console.WriteLine($"{name} your birthday of {birthdate} is {ageInDay} days old");
//  showing that without the "$" sign, the output is just a text
Console.WriteLine("{name} your birthday of {birthdate} is {ageInDay} days old");
Console.ReadKey();
