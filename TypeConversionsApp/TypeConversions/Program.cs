

Console.Write("What is your age: ");
string? ageText = Console.ReadLine();

// Console.WriteLine(ageText + 15);
// int age = int.Parse(ageText);
int age;
bool isValidInt = int.TryParse(ageText, out age);

Console.WriteLine($"This is valid: {isValidInt}. The number was {age}");
Console.WriteLine(age + 15);

double testDouble = age;
decimal testDeci = (decimal)testDouble;

Console.Write("How are you doing sir? How much would you like to deposit:");
string? depositValue = Console.ReadLine();

bool isAmountValid = int.TryParse(depositValue, out int value);
Console.WriteLine($"This deposit amount is valid: {isAmountValid}. This was the value deposited: {value}");


Console.WriteLine("How much would you like the wager to be sir - chose the amount: ");
string? amountText = Console.ReadLine();

bool isWagerValid = int.TryParse(amountText, out int wagerAmount);
Console.WriteLine($"Time to let you know! Is this wager amount valid: {isWagerValid}. Congratulations if so! This is the amount: {wagerAmount}");


//Homework TypeConversion

Console.WriteLine("What is your name?");
string? personName = Console.ReadLine();

Console.WriteLine($"Nice to meet you {personName}! Can you please let me know your age?");
string? personAge = Console.ReadLine();

Console.WriteLine($"{personAge} is a great age {personName}!");

int futureAge = int.Parse(personAge) + 25;
int pastAge = int.Parse(personAge) - 25;

Console.WriteLine($"Being service minded as we are we are obligied to let you know that your age in 25 years are: {futureAge}. Your age 25 years earlier from the current date is: {pastAge}");