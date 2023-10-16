
string firstName;

do
{
    Console.WriteLine("what is your name: ");
    firstName = Console.ReadLine();
    Console.WriteLine($"Hello {firstName}");
} while (firstName != "exit");

Console.WriteLine("The application has ended");