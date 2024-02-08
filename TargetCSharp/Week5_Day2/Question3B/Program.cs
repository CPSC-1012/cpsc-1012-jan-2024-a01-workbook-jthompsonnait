//  Write a program that plays the scissor-rock-paper game.
//      - a scissor cuts a paper
//      - a rock can knock a scissor
//      - a paper can wrap a rock.
//  The program randomly generates a number 0, 1, or 2 representing scissor,
//      rock, and paper. The program prompts the user to enter a number 0, 1, or 2
//      and display a message indicating whether the user or the
//      computer wins, loses, or draws.

// In this scissor-rock-paper game code, a combination of random number generation,
//  ternary operators for succinct value assignment, and switch statements for
//  complex decision-making is utilized, demonstrating a multifaceted approach to
//  programming within a procedural paradigm.

// Initialize a new Random object to generate random numbers
Random rnd = new Random();
// Generate a random number between 0 and 2 (inclusive) to represent the computer's choice
int computerChoice = rnd.Next(0, 3);
// Use ternary operators to assign a string representation based on the computer's choice
string computerResult = computerChoice == 0 ? "Scissor" : computerChoice == 1 ? "Rock" : "Paper";

// Initialize the user's choice; will be set based on user input
int userChoice = 0;
// Initialize a variable to hold the user's choice as a string for display purposes
string userResult = string.Empty;
// Initialize a variable to hold the result of the game (Draw, I win, You win)
string action = string.Empty;

// Prompt the user for their choice
Console.Write("Please enter 0 for Scissor, 1 for Rock and 2 for Paper: ");

// Read the user's input and try to convert it to an integer. If conversion fails,
//  print an error message.
if (!int.TryParse(Console.ReadLine(), out userChoice))
{
    Console.WriteLine("Invalid Selection!");
}
else
{
    // Use ternary operators to assign a string representation based on the user's choice
    userResult = userChoice == 0 ? "Scissor" : userChoice == 1 ? "Rock" : "Paper";

    // Use a switch statement to determine the game's outcome based on the user's and
    //  computer's choices
    switch (userChoice)
    {
        case 0: // User chooses Scissor
            switch (computerChoice)
            {
                case 0: action = "Draw"; break;
                case 1: action = "I win"; break;
                case 2: action = "You win"; break;
            }
            break;
        case 1: // User chooses Rock
            switch (computerChoice)
            {
                case 0: action = "You win"; break;
                case 1: action = "Draw"; break;
                case 2: action = "I win"; break;
            }
            break;
        case 2: // User chooses Paper
            switch (computerChoice)
            {
                case 0: action = "I win"; break;
                case 1: action = "You win"; break;
                case 2: action = "Draw"; break;
            }
            break;
    }

    // Display the result of the game to the user
    Console.WriteLine($"{action}: You pick \"{userResult}\" where I pick \"{computerResult}\"");
    // Prompt the user to press any key to quit the program
    Console.WriteLine("Press any key to quit");
    Console.ReadKey();
}
