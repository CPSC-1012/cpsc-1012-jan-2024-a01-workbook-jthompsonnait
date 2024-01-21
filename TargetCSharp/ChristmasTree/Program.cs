// Initialize a variable to capture key presses
ConsoleKeyInfo keyPress = new ConsoleKeyInfo();

// Define an array of ConsoleColor values for later use
ConsoleColor[] colors = new ConsoleColor[]
{
    ConsoleColor.Blue, ConsoleColor.Yellow, ConsoleColor.Red, ConsoleColor.Green, ConsoleColor.Magenta, ConsoleColor.White
};

// Continue looping until the 'Q' key is pressed
while (keyPress.Key != ConsoleKey.Q)
{
    // Clear the console screen
    Console.Clear();

    // Reset the console color to default
    Console.ResetColor();

    // Display instructions to the user
    Console.Write("Please press 1 - 4 to see a christmas tree.  Please press 'Q' to quit");

    // Read the next key press from the user
    keyPress = Console.ReadKey();

    // Check if the pressed key is not 'Q'
    if (keyPress.ToString() != "Q")
    {
        // Add some space for clarity
        Console.WriteLine();
        Console.WriteLine();

        // Check if the '1' key was pressed
        if (keyPress.Key == ConsoleKey.D1)
        {
            // Set the console color to green
            Console.ForegroundColor = ConsoleColor.Green;

            // Draw a simple Christmas tree using ASCII art
            Console.WriteLine("       *");
            Console.WriteLine("      ***");
            Console.WriteLine("     *****");
            Console.WriteLine("    *******");
            Console.WriteLine("   *********");
            Console.WriteLine("  ***********");
            Console.WriteLine(" *************");
            Console.WriteLine("***************");
            Console.WriteLine("       *");
            Console.WriteLine("       *");

            // Reset the console color and wait for another key press
            Console.ResetColor();
            Console.Write("Press any key to continue");
            Console.ReadKey();
        }
        else
        {
            if (keyPress.Key == ConsoleKey.D2)
            {
                // Similar to the first block, but with different colors for each line of the tree
                // ...
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("       *");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("      ***");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("     *****");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("    *******");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("   *********");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("  ***********");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(" *************");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("***************");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("       *");
                Console.WriteLine("       *");
                Console.WriteLine();
                Console.WriteLine();
                Console.ResetColor();
                Console.Write("Press any key to continue");
                Console.ReadKey();
            }
            else
            {
                if (keyPress.Key == ConsoleKey.D3)
                {
                    // Loop to create a blinking effect
                    for (int i = 0; i < 10; i++)
                    {
                        Console.Clear();
                        Console.ResetColor();
                        // Randomly set the color for each line of the tree
                        Console.ForegroundColor =
                            (ConsoleColor)(new Random().Next(Enum.GetNames(typeof(ConsoleColor)).Length));
                        Console.WriteLine("       *");
                        Console.ForegroundColor =
                            (ConsoleColor)(new Random().Next(Enum.GetNames(typeof(ConsoleColor)).Length));
                        Console.WriteLine("      ***");
                        Console.ForegroundColor =
                            (ConsoleColor)(new Random().Next(Enum.GetNames(typeof(ConsoleColor)).Length));
                        Console.WriteLine("     *****");
                        Console.ForegroundColor =
                            (ConsoleColor)(new Random().Next(Enum.GetNames(typeof(ConsoleColor)).Length));
                        Console.WriteLine("    *******");
                        Console.ForegroundColor =
                            (ConsoleColor)(new Random().Next(Enum.GetNames(typeof(ConsoleColor)).Length));
                        Console.WriteLine("   *********");
                        Console.ForegroundColor =
                            (ConsoleColor)(new Random().Next(Enum.GetNames(typeof(ConsoleColor)).Length));
                        Console.WriteLine("  ***********");
                        Console.ForegroundColor =
                            (ConsoleColor)(new Random().Next(Enum.GetNames(typeof(ConsoleColor)).Length));
                        Console.WriteLine(" *************");
                        Console.ForegroundColor =
                            (ConsoleColor)(new Random().Next(Enum.GetNames(typeof(ConsoleColor)).Length));
                        Console.WriteLine("***************");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("       *");
                        Console.WriteLine("       *");
                        Console.WriteLine();
                        Console.WriteLine();
                        // Pause for a second
                        System.Threading.Thread.Sleep(1000);
                    }
                }

                else
                {
                    if (keyPress.Key == ConsoleKey.D4)
                    {
                        for (int i = 0; i < 10; i++)
                        {
                            Console.Clear();
                            Console.ResetColor();
                            // Similar to the previous block, but using a predefined array of colors
                            Console.ForegroundColor =
                                colors[(new Random().Next(colors.Length))];
                            Console.WriteLine("       *");
                            Console.ForegroundColor =
                                colors[(new Random().Next(colors.Length))];
                            Console.WriteLine("      ***");
                            Console.ForegroundColor =
                                colors[(new Random().Next(colors.Length))];
                            Console.WriteLine("     *****");
                            Console.ForegroundColor =
                                colors[(new Random().Next(colors.Length))];
                            Console.WriteLine("    *******");
                            Console.ForegroundColor =
                                colors[(new Random().Next(colors.Length))];
                            Console.WriteLine("   *********");
                            Console.ForegroundColor =
                                colors[(new Random().Next(colors.Length))];
                            Console.WriteLine("  ***********");
                            Console.ForegroundColor =
                                colors[(new Random().Next(colors.Length))];
                            Console.WriteLine(" *************");
                            Console.ForegroundColor =
                                colors[(new Random().Next(colors.Length))];
                            Console.WriteLine("***************");
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine("       *");
                            Console.WriteLine("       *");
                            Console.WriteLine();
                            Console.WriteLine();
                            // Pause for a second
                            System.Threading.Thread.Sleep(1000);
                        }
                    }
                }
            }
        }
    }
    else
    {
        // Exit the loop if 'Q' is pressed
        break;
    }
}
