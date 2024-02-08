//  Write a program that plays the scissor-rock-paper game.
//      - a scissor cuts a paper
//      - a rock can knock a scissor
//      - a paper can wrap a rock.
//  The program randomly generates a number 0, 1, or 2 representing scissor,
//      rock, and paper. The program prompts the user to enter a number 0, 1, or 2
//      and display a message indicating whether the user or the
//      computer wins, loses, or draws.

// The programming style in this scissor-rock-paper game leverages both
//  ternary operators for concise assignment decisions and if/else statements
//  for control flow to determine the game's outcome, showcasing a blend of
//  decision-making constructs within procedural programming.

// Initialize a new Random object to generate random numbers
Random rnd = new Random();
// Generate a random number between 0 and 2 (inclusive) to represent the
//  computer's choice
int computerChoice = rnd.Next(0, 3);
// Use ternary operators to assign a string representation based on the
//  computer's choice
string computerResult = computerChoice == 0 ? "Scissor" : computerChoice == 1 ? "Rock" : "Paper";

// Initialize the user's choice; will be set based on user input
int userChoice = 0;
// Initialize a variable to hold the user's choice as a string for
//  display purposes
string userResult = string.Empty;
// Initialize a variable to hold the result of the game (Draw, I win, You win)
string action = string.Empty;

// Prompt the user for their choice
Console.Write("Please enter 0 for Scissor, 1 for Rock and 2 for Paper: ");

// Read the user's input and try to convert it to an integer. If conversion
//  fails, print an error message.
if (!int.TryParse(Console.ReadLine(), out userChoice))
{
    Console.WriteLine("Invalid Selection!");
}
else
{
    // Use ternary operators to assign a string representation based on the
    //  user's choice
    userResult = userChoice == 0 ? "Scissor" : userChoice == 1 ? "Rock" : "Paper";

    // Determine the game's outcome using nested ternary operators based on the
    //  user's and computer's choices
    if (userChoice == 0)
    {
        action = computerChoice == 0 ? "Draw" : computerChoice == 1 ? "I win" : "You win";
    }
    else if (userChoice == 1)
    {
        action = computerChoice == 0 ? "You win" : computerChoice == 1 ? "Draw" : "I win";
    }
    else // userChoice == 2
    {
        action = computerChoice == 0 ? "I win" : computerChoice == 1 ? "You win" : "Draw";
    }

    // Display the result of the game to the user
    Console.WriteLine($"{action}: You pick \"{userResult}\" where I pick \"{computerResult}\"");
    // Prompt the user to press any key to quit the program
    Console.WriteLine("Press any key to quit");
    Console.ReadKey();
}
