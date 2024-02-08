//  Write a program that plays the scissor-rock-paper game.
//      - a scissor cuts a paper
//      - a rock can knock a scissor
//      - a paper can wrap a rock.
//  The program randomly generates a number 0, 1, or 2 representing scissor,
//  rock, and paper. The program prompts the user to enter a number 0, 1, or 2 and display a message 
//  indicating whether the user or the computer wins, loses, or draws.

//  The programming style emphasized in this scissor-rock-paper game relies on
//      using if/else statements to sequentially evaluate conditions and
//      determine the game's outcome, illustrating a fundamental approach in procedural programming.


// Initialize the user's choice with a default value
int userChoice = 0;
// Initialize a variable to hold the user's choice as a string for display purposes
string userResult = string.Empty;

// Create a Random object to generate random numbers
Random rnd = new Random();
// Generate a random number between 0 and 2 (inclusive) to simulate the computer's choice
int computerChoice = rnd.Next(0, 3);
// Initialize a variable to hold the computer's choice as a string for display purposes
string computerResult = string.Empty;

// Assign a string representation based on the computer's numeric choice
if (computerChoice == 0)
{
    computerResult = "Scissor";
}
else if (computerChoice == 1)
{
    computerResult = "Rock";
}
else // computerChoice == 2
{
    computerResult = "Paper";
}

// Prompt the user for their choice
Console.Write("Please enter 0 for Scissor, 1 for Rock and 2 for Paper: ");

// Read the user's input and validate it as an integer. If not valid, print an error message.
if (!int.TryParse(Console.ReadLine(), out userChoice))
{
    Console.WriteLine("Invalid Selection!");
}
else
{
    // Process the user's valid choice and determine the outcome of the game
    if (userChoice == 0)
    {
        userResult = "Scissor";
        // Determine the game outcome when the user chooses Scissor
        if (computerChoice == 0)
        {
            Console.WriteLine($"Draw: You pick \"{userResult}\" where I pick \"{computerResult}\"");
        }
        else if (computerChoice == 1)
        {
            Console.WriteLine($"I win: You pick \"{userResult}\" where I pick \"{computerResult}\"");
        }
        else // computerChoice == 2
        {
            Console.WriteLine($"You win: You pick \"{userResult}\" where I pick \"{computerResult}\"");
        }
    }
    else if (userChoice == 1)
    {
        userResult = "Rock";
        // Determine the game outcome when the user chooses Rock
        if (computerChoice == 0)
        {
            Console.WriteLine($"You win: You pick \"{userResult}\" where I pick \"{computerResult}\"");
        }
        else if (computerChoice == 1)
        {
            Console.WriteLine($"Draw: You pick \"{userResult}\" where I pick \"{computerResult}\"");
        }
        else // computerChoice == 2
        {
            Console.WriteLine($"I win: You pick \"{userResult}\" where I pick \"{computerResult}\"");
        }
    }
    else // userChoice == 2
    {
        userResult = "Paper";
        // Determine the game outcome when the user chooses Paper
        if (computerChoice == 0)
        {
            Console.WriteLine($"I win: You pick \"{userResult}\" where I pick \"{computerResult}\"");
        }
        else if (computerChoice == 1)
        {
            Console.WriteLine($"You win: You pick \"{userResult}\" where I pick \"{computerResult}\"");
        }
        else // computerChoice == 2
        {
            Console.WriteLine($"Draw: You pick \"{userResult}\" where I pick \"{computerResult}\"");
        }
    }

    // Prompt the user to press any key to quit the program
    Console.WriteLine("Press any key to quit");
    Console.ReadKey();
}
