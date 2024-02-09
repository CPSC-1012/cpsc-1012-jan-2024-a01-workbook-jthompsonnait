string name ="James";
string stringAge;
int intAge;
DateTime birthdate;
int ageInDay;
bool isValid;

Console.Write("What is your name? ");
// name  = Console.ReadLine();

Console.Write("What is your age: ");
 stringAge = Console.ReadLine();
isValid =int.TryParse(stringAge, out intAge);

intAge = int.Parse(stringAge);




Console.Write("What is your birthday (yyyy-mm-dd)? ");
birthdate = DateTime.Parse(Console.ReadLine());
ageInDay = (DateTime.Now - birthdate).Days;

Console.WriteLine(name + " your birthday of " + birthdate.ToShortDateString() + " is " + ageInDay + " days old");
Console.WriteLine($"{name} your birthday of {birthdate} is {ageInDay} days old");
//  showing that without the "$" sign, the output is just a text
Console.WriteLine("{name} your birthday of {birthdate} is {ageInDay} days old");
Console.ReadKey();
