//  Write a program that plays the scissor-rock-paper game.
//      - a scissor cuts a paper
//      - a rock can knock a scissor
//      - a paper can wrap a rock.
//  The program randomly generates a number 0, 1, or 2 representing scissor,
//      rock, and paper. The program prompts the user to enter a number 0, 1, or 2
//      and display a message indicating whether the user or the
//      computer wins, loses, or draws.

//  This scissor-rock-paper game code exemplifies a modern approach to programming by
//      integrating pattern matching with switch expressions for streamlined decision-making,
//      alongside utilizing random number generation and conditional logic to dynamically
//      determine game outcomes, showcasing an efficient use of C#'s language features.

// Initialize the user's choice with a default value
int userChoice = 0;
// Initialize a variable to hold the user's choice as a string for
//  display purposes
string userResult = string.Empty;

// Create a Random object to generate random numbers
Random rnd = new Random();
// Generate a random number between 0 and 2 (inclusive) to simulate the computer's choice
int computerChoice = rnd.Next(0, 3);
// Initialize a variable to hold the computer's choice as a
//  string for display purposes
string computerResult = computerChoice switch
{
    0 => "Scissor",
    1 => "Rock",
    _ => "Paper"
};

// Prompt the user for their choice
Console.Write("Please enter 0 for Scissor, 1 for Rock and 2 for Paper: ");

// Read the user's input and validate it as an integer. If not valid,
//  print an error message.
if (!int.TryParse(Console.ReadLine(), out userChoice))
{
    Console.WriteLine("Invalid Selection!");
}
else
{
    // Process the user's valid choice and determine the outcome of the game
    // NOTE:   The underscore (_) acts as a "discard" pattern,
    //          which effectively serves as a catch-all or default case.
    //          When used in a switch expression, it matches any value that
    //          hasn't been matched by the preceding cases.
    userResult = userChoice switch
    {
        0 => "Scissor",
        1 => "Rock",
        _ => "Paper"
    };

    string resultMessage = (userChoice, computerChoice) switch
    {
        // Cases where it's a draw
        (0, 0) => $"Draw: You pick \"{userResult}\" where I pick \"{computerResult}\"",
        (1, 1) => $"Draw: You pick \"{userResult}\" where I pick \"{computerResult}\"",
        (2, 2) => $"Draw: You pick \"{userResult}\" where I pick \"{computerResult}\"",

        // Cases where the user wins
        (0, 2) => $"You win: You pick \"{userResult}\" where I pick \"{computerResult}\"",
        (1, 0) => $"You win: You pick \"{userResult}\" where I pick \"{computerResult}\"",
        (2, 1) => $"You win: You pick \"{userResult}\" where I pick \"{computerResult}\"",

        // Cases where the computer wins
        (0, 1) => $"I win: You pick \"{userResult}\" where I pick \"{computerResult}\"",
        (1, 2) => $"I win: You pick \"{userResult}\" where I pick \"{computerResult}\"",
        (2, 0) => $"I win: You pick \"{userResult}\" where I pick \"{computerResult}\"",

        // Default case, should technically never be reached
        _ => "Unexpected outcome"
    };

    // Display the result of the game to the user
    Console.WriteLine(resultMessage);

    // Prompt the user to press any key to quit the program
    Console.WriteLine("Press any key to quit");
    Console.ReadKey();
}
