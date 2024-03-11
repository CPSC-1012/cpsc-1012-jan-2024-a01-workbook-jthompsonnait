//Modify an	earlier	program	that	will	determine	the	cost	of	admission	for	a	theatre.		The	price	of	
//admission	is	based	on	the	age	of	the	customer.		Your	program	should	prompt	the	user	for	their	
//    age	and	then	display	the	correct	admission	amount.	
//    • Children	6	and	under	=	FREE ($0.00)
//    • Students	7	to	17	=	$9.80
//    • Adults	18	to	54	=	$11.35
//    • Seniors	55+	=	$10.00

int age = 0;
double ticketCost = 0;
Console.Write("Please enter your age: ");
age = int.Parse(Console.ReadLine());
ticketCost = GetTicketCost(age);
Console.WriteLine($"The cost for your age of {age} is {ticketCost}");

static double GetTicketCost(int age)
{
    double cost = 0;
    if (age <= 6)
    {
        cost = 0;
    }
    else
    if (age <= 17)
    {
        cost = 9.80;
    }
    if (age <= 54)
    {
        cost = 11.35;
    }
    else
    {
        cost = 10;
    }

    return cost;
}