
bool isValidAge;
int age;

do
{
    Console.Write("What is your age:");
    string ageText = Console.ReadLine();

    isValidAge = int.TryParse(ageText, out age);

    if (isValidAge == false)
    {
        Console.WriteLine("invalid age");
    }

} while (!isValidAge);

Console.WriteLine($"Your age is valid and is {age}");



//Infinite Loop
//int testNumber = 0;

//do
//{
//    Console.WriteLine(testNumber);
//    testNumber += 3;

//} while (testNumber != 10);