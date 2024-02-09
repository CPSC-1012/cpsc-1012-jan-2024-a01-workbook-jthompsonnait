Console.WriteLine("Traffic Light Simulation Started. Press Ctrl+C to exit.");

int lightValue = 0; // 0 for Green, 1 for Yellow, 2 for Red

while (true) // Infinite loop to keep the program running
{
    Console.Clear(); // Clear the console for a clean display

    // Update the lightValue and display the corresponding light
    if (lightValue == 0) // Green
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("[---]");
        Console.WriteLine("[***]");
        Console.WriteLine("[***]");
        Console.WriteLine("[***]");
        Console.WriteLine("[---]");
        Console.WriteLine("[***]");
        Console.WriteLine("[***]");
        Console.WriteLine("[***]");
        Console.WriteLine("[---]");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("[***]");
        Console.WriteLine("[***]");
        Console.WriteLine("[***]");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("[---]");
    }
    else if (lightValue == 1) // Yellow
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("[---]");
        Console.WriteLine("[***]");
        Console.WriteLine("[***]");
        Console.WriteLine("[***]");
        Console.WriteLine("[---]"); ;
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("[***]");
        Console.WriteLine("[***]");
        Console.WriteLine("[***]");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("[---]");
        Console.WriteLine("[***]");
        Console.WriteLine("[***]");
        Console.WriteLine("[***]");
        Console.WriteLine("[---]");
    }
    else if (lightValue == 2) // Red
    {
        Console.WriteLine("[---]");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("[***]");
        Console.WriteLine("[***]");
        Console.WriteLine("[***]"); ;
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("[---]");
        Console.WriteLine("[***]");
        Console.WriteLine("[***]");
        Console.WriteLine("[***]");
        Console.WriteLine("[---]");
        Console.WriteLine("[***]");
        Console.WriteLine("[***]");
        Console.WriteLine("[***]");
        Console.WriteLine("[---]");
    }

    // Reset Console Color
    Console.ResetColor();

    // Change the light every 2 seconds
  //  Thread.Sleep(2000);

    // Update lightValue for the next cycle
    lightValue = (lightValue + 1) % 3; // This ensures the cycle loops between 0, 1, and 2
}