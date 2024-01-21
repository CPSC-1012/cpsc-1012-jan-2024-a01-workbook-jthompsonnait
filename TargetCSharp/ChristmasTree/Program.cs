ConsoleKeyInfo keyPress = new ConsoleKeyInfo();
while (keyPress.Key != ConsoleKey.Q )
{
    Console.Clear();
    Console.ResetColor();
    Console.Write("Please press 1 - 3 to see a christmas tree.  Please press 'Q' to quit");
    keyPress = Console.ReadKey();
    if (keyPress.ToString() != "Q")
    {
        Console.WriteLine();
        Console.WriteLine();
        if (keyPress.Key == ConsoleKey.D1)
        {
            Console.ForegroundColor = ConsoleColor.Green;
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
            Console.WriteLine();
            Console.WriteLine();
            Console.ResetColor();
            Console.Write("Press any key to continue");
            Console.ReadKey();
        }
        else
        {
            if (keyPress.Key == ConsoleKey.D2)
            {
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
                    for (int i = 0; i < 10; i++)
                    {
                        Console.Clear();
                        Console.ResetColor();
                        Console.ForegroundColor = (ConsoleColor)(new Random().Next(Enum.GetNames(typeof(ConsoleColor)).Length));
                        Console.WriteLine("       *");
                        Console.ForegroundColor = (ConsoleColor)(new Random().Next(Enum.GetNames(typeof(ConsoleColor)).Length));
                        Console.WriteLine("      ***");
                        Console.ForegroundColor = (ConsoleColor)(new Random().Next(Enum.GetNames(typeof(ConsoleColor)).Length));
                        Console.WriteLine("     *****");
                        Console.ForegroundColor = (ConsoleColor)(new Random().Next(Enum.GetNames(typeof(ConsoleColor)).Length));
                        Console.WriteLine("    *******");
                        Console.ForegroundColor = (ConsoleColor)(new Random().Next(Enum.GetNames(typeof(ConsoleColor)).Length));
                        Console.WriteLine("   *********");
                        Console.ForegroundColor = (ConsoleColor)(new Random().Next(Enum.GetNames(typeof(ConsoleColor)).Length));
                        Console.WriteLine("  ***********");
                        Console.ForegroundColor = (ConsoleColor)(new Random().Next(Enum.GetNames(typeof(ConsoleColor)).Length));
                        Console.WriteLine(" *************");
                        Console.ForegroundColor = (ConsoleColor)(new Random().Next(Enum.GetNames(typeof(ConsoleColor)).Length));
                        Console.WriteLine("***************");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("       *");
                        Console.WriteLine("       *");
                        Console.WriteLine();
                        Console.WriteLine();
                        System.Threading.Thread.Sleep(1000);
                    }
                }
            }
        }
    }
    else
    {
        break;
    }
}

