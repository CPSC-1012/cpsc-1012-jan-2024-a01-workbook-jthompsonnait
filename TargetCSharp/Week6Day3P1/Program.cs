//Write a C# program that prompts the user to input their age. The program should ensure that the input is a valid integer.
//If the input cannot be converted to an integer, display an error message and exit the program. Otherwise, use a switch statement to perform the following actions:

//If the age is less than 0, display a message saying "Age cannot be negative." and exit the program.
//    If the age is less than 18, display a message saying "You are underage." and exit the program.
//    If the age is 18 or older, display a message saying "You are of legal age." and exit the program.
//    Ensure that the program gracefully handles invalid data and exits after displaying the appropriate message.
// Use a switch statement to implement the age validation and message display logic.

try
{
    Console.Write("Enter your age: ");
    int age = Convert.ToInt32(Console.ReadLine());
    switch (age)
    {
        case int s when s < 0:
            Console.WriteLine("Age cannot be negative.");
            break;
        case int s when s < 18:
            Console.WriteLine("You are underage");
            break;
        default:
            Console.WriteLine("You are of legal age.");
            break;
    }
}
catch (FormatException ex)
{
    Console.WriteLine();
    Console.WriteLine("Error: Please enter a valid number for your age.");
    Console.WriteLine(ex.Message);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
Console.WriteLine("Continue with code");