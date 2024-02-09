/*
In this section we will add the variables we will use
throughout the program code. These are variables that are
going to be of a specific data type. Once we declare a
variable and have said what its data type is, we cannot
change the variable's data type.
The data type is immutable, it cannot be changed over time.
First we will add a variable called vehicleManufacturer of
data type string.
*/

string vehicleManufacturer;
string vehicleModel;
string vehicleColour;
int vehicleAgeInYears;
decimal vehicleEstimatedCurrentPrice;
int vehicleCurrentMileage;
DateTime dateOfBirthOfMainDriver;

// max value of int is 2,147,483,647
int maximumAmountForRepairCosts = 32767;

// max value of short is 32,767
short maximumAmountForCarHire = 0;

bool fullyComprehensiveRequirement = true;

/*
This will cause a warning as all reference types are
non-nullable by default. The warning will be similar to:
Converting null literal or possible null value to
non-nullable reference type.
*/
string? policyId = null;

Console.WriteLine();
Console.WriteLine("---- Car Quotation Application ----");
Console.WriteLine("\tCar\tInsurance\tApplication\n");
Console.WriteLine();
Console.WriteLine("Type the vehicle manufacturer");
Console.WriteLine("and press the Enter key");
Console.WriteLine();
vehicleManufacturer = Console.ReadLine();
Console.WriteLine();

/*
The next line of code tells the program to display the text
between the double quotes "" and to add on to this text
(indicated by the +) the value of the variable called
vehicleManufacturer which has been assigned the value
typed in by the user at the console (Ford). The + means to
concatenate the text and the variable, in other words
join them
*/

Console.WriteLine("Your car manufacturer is recorded as "
                  + vehicleManufacturer);
/*
In the next three lines we display a question for the user,
read whatever data the user inputs at the console, assign
this data to the variable called vehicleModel and write
out the concatenated text
*/
Console.WriteLine("What is the model of the vehicle?\n");
vehicleModel = Console.ReadLine();
Console.WriteLine("You have told us that the vehicle " +
                  "model is " + vehicleModel);

Console.WriteLine("What is the colour of the vehicle?\n");
vehicleColour = Console.ReadLine();

Console.WriteLine("You have told us that the vehicle " +
                  "colour is " + vehicleColour);

Console.WriteLine("What is the age, in full years, of " +
                  "the vehicle? \n");
vehicleAgeInYears = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("You have told us that the vehicle " +
                  "age is " + vehicleAgeInYears);

Console.WriteLine("What is the estimated current value " +
                  "of the vehicle?\n");
vehicleEstimatedCurrentPrice =
    Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("You have told us that the estimated " +
                  "vehicle price is $" + vehicleEstimatedCurrentPrice);

Console.WriteLine("What is the current mileage (in km) " +
                  "of the vehicle?\n");
vehicleCurrentMileage = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("You have told us that the vehicle " +
                  "mileage is " + vehicleCurrentMileage + " km");

Console.WriteLine("What is the date of birth " +
                  "(yyyy-MM-dd) of the main driver of the vehicle?\n");
//dateOfBirthOfMainDriver =
//    DateTime.Parse(Console.ReadLine());

//Console.WriteLine("You have told us that the main " +
//                  "driver was born on " + dateOfBirthOfMainDriver.ToShortDateString());

Console.WriteLine("Do we require fully comprehensive" +
                  " insurance (enter the word True or False)?\n");

//  comment out to use the convert.ToBoolean
//  fullyComprehensiveRequirement = Boolean.Parse(Console.ReadLine());

fullyComprehensiveRequirement = Convert.ToBoolean(Console.ReadLine());

Console.WriteLine("It is " + fullyComprehensiveRequirement
                           + " that we require fully comprehensive insurance");

/*
Now we are trying to put the int variable
maximumAmountForRepairCosts into the short variable
maximumAmountForCarHire but this is not possible without
something being changed.
This is where the cast comes into play.
*/
maximumAmountForCarHire = (short)maximumAmountForRepairCosts;

Console.WriteLine("The int variable " +
                  "maximumAmountForRepairCosts has a value of "
                  + maximumAmountForRepairCosts);
Console.WriteLine();
Console.WriteLine("The short variable " +
                  "maximumAmountForCarHire has a value of "
                  + maximumAmountForCarHire);
Console.WriteLine("Press any letter on the keyboard");
// This code waits for the user to input form the keyboard
Console.ReadKey();
Console.WriteLine("Goodbye");
Console.ReadLine();
