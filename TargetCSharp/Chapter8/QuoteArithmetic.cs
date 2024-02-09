/*
We will setup our variables that will be used in the
mathematical calculation used to produce an insurance
quotation for a vehicle.
First we will setup the variables that will hold the user
input and that will be used in calculating the quote
*/
int vehicleAgeInYears;
int vehicleCurrentMileage;
/*
For the quotation we will use 10000 kilometres as a base
line for calculating a mileage factor. If the average
kilometres travelled per year is above the base mileage of
10000 the mileage factor will be above 1, if the average
kilometres travelled per year is the lower than the base
mileage of 10000 the mileage factor will be below 1
*/
double quoteAverageExpectedKilometres = 10000;
/*
For the quotation we will use $100 as a base figure
(this is just an example) and this figure will be
multiplied by the mileage and age factors
*/
double quoteBaseRate = 100.00;
/*
For the quotation we will use 10 as a base figure for the
age of the vehicle (this is just an example).
If the vehicle is older than 10 years, the age factor
will be above 1.
If the vehicle is younger than 10 years the age factor
will be below 1
*/
int quoteBaseAge = 10;
/*
This variable will be used to hold the value of the
age factor
*/
double quoteAgeFactor;
/*
This variable holds the quote amount based on the age
factor and the base rate
*/
double quoteAgeFactorPremium;
/*
This variable holds the quote mileage factor based on the
number of kilometres travelled each year and how the
kilometres per year is a ratio of the average expected
10000 kilometres as decided by the insurance company
*/
double quoteMileageFactor;
/*
This variable holds the amount for the quote based only
on the mileage factor. The quote also has to take into
account the age of the vehicle
*/
double quoteMileageFactorPremium;

/*
This variable will hold the discount amount.
A discount will be applied to the quote based on the age
of the vehicle. The age of the vehicle is divided into 1
to get the discount. The decimal value is a representation
of the discount and will then be multiplied by the quote
value to get the actual discount in terms of $s
*/
double quoteDiscount;
/*
This variable holds the total of the age factor premium
and the mileage factor premium and will be used by the
discount calculation to get the discount amount
*/
double quoteAmountForPremium;
/*
This variable holds the final quotation value, the premium.
*/
double quoteFinalAmountForPremium;

Console.WriteLine();

Console.WriteLine("---- Car Quotation Application ----");
Console.WriteLine();
Console.WriteLine("What is the age, in full years, of " +
                  "the vehicle?\n");

/*
Perform the conversion, Parse, from string to int as we
will use the age of the vehicle in our calculation and
it needs to be numeric
*/
vehicleAgeInYears = Convert.ToInt32(Console.ReadLine());
/*
Perform the conversion from string to int as we will use
the age of the vehicle in our calculation and it needs
to be numeric
Example: For a 5 year old car the factor is 10/5 = 2
*/
quoteAgeFactor = (double)(quoteBaseAge) /
                 (double)(vehicleAgeInYears);
/*
The quote amount based on the age is $100 multiplied by
the age factor
Example $100 * 2 = $200
*/
quoteAgeFactorPremium = quoteBaseRate * quoteAgeFactor;

/*
Ask the user for the number of kilometres on the odometer
*/
Console.WriteLine("What is the current mileage (in km) " +
                  "of the vehicle?\n");
vehicleCurrentMileage = Convert.ToInt32(Console.ReadLine());

/*
Calculate the mileage factor. This is based on the number
of kilometres travelled each year and how the kilometres
per year is a ratio of the average expected 10000
kilometres as decided by the insurance company
Example: For a 5 year old car with 60000km the factor is
(60000/5)/10000 = 12000/10000 = 1.2
*/
quoteMileageFactor = (vehicleCurrentMileage /
                      vehicleAgeInYears) / quoteAverageExpectedKilometres;

/*
The quote amount based on the mileage is $100
multiplied by the mileage factor
Example $100 * 1.2 = $120
*/
quoteMileageFactorPremium = quoteBaseRate *
                            quoteMileageFactor;

/*
Calculate the quotation based on a base rate of $100.
This base rate is multiplied by the vehicle age factor
and by the vehicle mileage factor.
So, the older the vehicle the cheaper the quote or the
newer the vehicle the more expensive the quote.
The more kilometres travelled on average per year the
more expensive the quote or the less kilometres travelled
on average per year the cheaper the quote.
Example: For a 5 year old car, 60000km, age factor is 2
and mileage factor is 1.2
The quote is ($100*2) + ($100*1.2 )= $200 + $120 = $320
*/
/*
The quote amount based on the age premium plus the
mileage premium
Example $2000 + $120 = $320
*/
quoteAmountForPremium = quoteAgeFactorPremium +
                        quoteMileageFactorPremium;

/*
The discount amount is based on the age of the vehicle
Example:
5 year old vehicle gives discount of 1/5 = 20 percent */
quoteDiscount = (1 / (double)vehicleAgeInYears) *
                quoteAmountForPremium;

/*
The final quote with the discount applied
Example
5 year old vehicle gives discount of 100/5 = 20 percent
20% of $320 is $64.
So, the actual amount is $320 - $64 = $256
*/
quoteFinalAmountForPremium = quoteAmountForPremium -
                             quoteDiscount;

Console.WriteLine("**********************************\n");
Console.WriteLine("Quotation is for 1 year from today\n");
Console.WriteLine("**********************************\n");
Console.WriteLine("The age of the vehicle is :\t\t" +
                  vehicleAgeInYears);
Console.WriteLine("The age factor is for this vehicle " +
                  "is : " + quoteAgeFactor);
Console.WriteLine();
Console.WriteLine("The average kilometres per year " +
                  "is :\t" + (vehicleCurrentMileage / vehicleAgeInYears));
Console.WriteLine("The mileage factor is :\t\t\t" +
                  quoteMileageFactor);
Console.WriteLine();
Console.WriteLine("The quotation is :\t\t\t$" +
                  quoteAmountForPremium);
Console.WriteLine();
Console.WriteLine("The discount is :\t\t\t$" +
                  quoteDiscount);
Console.WriteLine();
Console.WriteLine("The final discounted amount is :\t$" +
                  quoteFinalAmountForPremium);

Console.WriteLine();
Console.WriteLine("*********************************\n");
Console.WriteLine("Quotation is for 1 year from today\n");
Console.WriteLine("*********************************\n");
Console.WriteLine("The age of the vehicle is :\t\t{0}", vehicleAgeInYears);
Console.WriteLine("The age factor for this vehicle is :\t{0}", quoteAgeFactor);
Console.WriteLine();
Console.WriteLine("The average kilometres per year is : \t{0:N2}", (vehicleCurrentMileage / vehicleAgeInYears));
Console.WriteLine("The mileage factor is :\t\t\t{0:N2}", quoteMileageFactor);
Console.WriteLine();
Console.WriteLine("The quotation is :\t\t\t{0:C2}", quoteAmountForPremium);
Console.WriteLine();
Console.WriteLine("The discount is :\t\t\t{0:C2}", quoteDiscount);
Console.WriteLine();
Console.WriteLine("The final discounted amount is :\t{0:C2}", quoteFinalAmountForPremium);
Console.WriteLine("*********************************\n");