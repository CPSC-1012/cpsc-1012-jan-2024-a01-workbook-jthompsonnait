Random random = new Random();
int[] rndList = new int[100];
bool isValid = false;
int answer = 0;
string inputValue = string.Empty;
for (int i = 0; i < rndList.Length; i++)
{
    rndList[i] = random.Next(1, 101);
}

while (!isValid)
{
    Console.Clear();
    Console.Write("Please enter in a value between 1 - 100 : ");
    inputValue = Console.ReadLine();

    isValid = int.TryParse(inputValue, out answer);
    if (answer < 1 || answer > 100)
    {
        Console.WriteLine($"Your input of '{inputValue}' was not correct, please try again");
        Console.Write("Please press any key to continue");
        Console.ReadKey();
        isValid = false;
    }
}

CountOfItemsLessThanGuess(rndList, answer);
CountOfItemsGreaterThanGuess(rndList, answer);


static void CountOfItemsLessThanGuess(int[] listOfRandomValue, int guess)
{
    int totalCount = 0;
    for (int i = 0; i < listOfRandomValue.Length; i++)
    {
        if (listOfRandomValue[i] < guess)
        {
            totalCount ++;
        }
    }

    Console.WriteLine($"Total count of items that were less than the guess is {totalCount}");
}

static void CountOfItemsGreaterThanGuess(int[] rndList, int guess)
{
    int totalCount = 0;
    for (int i = 0; i < rndList.Length; i++)
    {
        if (rndList[i] > guess)
        {
            totalCount++;
        }
    }

    Console.WriteLine($"Total count of items that were greater than the guess is {totalCount}");
}

