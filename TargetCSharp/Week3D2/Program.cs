////  string firstName    input
////  decimal amount      input
////  decimal tax         const
////  decimal finalAmount output

//int num1;
//int num2;
//int num3;
//int total;
//double average;

//Console.Write("Number 1: ");
//num1 = int.Parse(Console.ReadLine());
//Console.Write("Number 2: ");
//num2 = int.Parse(Console.ReadLine());
//Console.Write("Number 3: ");
//num3 = int.Parse(Console.ReadLine());

//total = num1 + num2 + num3;
//average = total / 3.0;
//Console.WriteLine($"The average of the 3 numbers is: {average}");

//Console.WriteLine($"Formatted String: {average:0.00}");
//Console.WriteLine();
//Console.WriteLine();

//double a;
//double b;
//double c;
//Console.Write("The length of side a: ");
//a = double.Parse(Console.ReadLine());
//Console.Write("The length of side a: ");
//b = double.Parse(Console.ReadLine());
//c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
//Console.WriteLine($"The length of side c is: {c}");
//Console.WriteLine();
//Console.WriteLine();

//Console.Write("Number 1: ");
//num1 = int.Parse(Console.ReadLine());
//Console.Write("Number 2: ");
//num2 = int.Parse(Console.ReadLine());
//Console.Write("Number 3: ");
//num3 = int.Parse(Console.ReadLine());

//total = num1 + num2 + num3;
//Console.WriteLine($"{num1}{num2}{num3} -> sum = {total}");

Console.WriteLine("Input 3 digit number: ");
string inputNumber = Console.ReadLine();

char charNum1 = inputNumber[0];
char charNum2 = inputNumber[1];
char charNum3 = inputNumber[2];

int intNum1 = int.Parse(charNum1.ToString());
int intNum2 = int.Parse(charNum2.ToString());
int intNum3 = int.Parse(charNum3.ToString());

int sumOfNumber = intNum1 + intNum2 + intNum3;
Console.WriteLine($"{inputNumber} -> sum = {sumOfNumber}");
