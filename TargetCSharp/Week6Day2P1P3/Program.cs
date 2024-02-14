//string number;
//Console.Write("Please enter a number: ");
//number = Console.ReadLine();
//for (int i = number.Length-1; i >= 0; i--)
//{
//    Console.WriteLine(number[i]);
//}
//Console.WriteLine("Press any key to continue!!!");
//Console.ReadKey();

string sentence;
string noVowels = string.Empty;
string voVowels = "aeiou";
Console.Write("Enter a sentence: ");
sentence = Console.ReadLine();
for (int i = 0; sentence.Length - 1 >= i; i++)
{
    if (!voVowels.Contains(sentence[i]))
    {
        noVowels = noVowels + sentence[i];
    }
}
Console.WriteLine(noVowels);
Console.WriteLine("Press any key to continue!!!");
Console.ReadKey();
noVowels = string.Empty;

noVowels = sentence.Replace("a", "").Replace("e", "")
    .Replace("i", "").Replace("o", "").Replace("u", "");
Console.WriteLine(noVowels);




//Console.Write("Enter a sentence to remove all vowel letters: ");
//string inputWords = Console.ReadLine();

//string outputWords = "";

//for (int i = 0; i < inputWords.Length; i++)
//{
//    string letter = inputWords[i].ToString().ToUpper();
//    if (!(letter == "A" || letter == "E" || letter == "I" || letter == "O" || letter == "U"))
//    {
//        outputWords += letter;
//    }
//}

//Console.WriteLine($"Your sentence '{inputWords}' without the vowel letters is:");
//Console.WriteLine(outputWords);
//Console.WriteLine("");
//Console.WriteLine("Press any key to quit.");
//Console.ReadKey();
