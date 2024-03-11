List<string> numbers = new List<string>();
for (int i = 1; i <= 10; i++)
{
    numbers.Add(i.ToString());
}

File.WriteAllLines("numbers.txt", numbers);