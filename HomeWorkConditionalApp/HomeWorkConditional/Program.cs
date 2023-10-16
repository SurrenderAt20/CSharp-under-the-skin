

Console.WriteLine("Hello!... potential student. To get accepted here you need to be taller than 175cm. What is your height?");
string? height = Console.ReadLine();

if (int.TryParse(height, out int heightOutput))
{
    if (heightOutput > 175)
    {
        Console.WriteLine("You are accepted!");
    }

    else
    {
        Console.WriteLine("You are too short you fucking midget");
    }
}
else
{
    Console.WriteLine("invalid input");
}