bool isComplete = false;

Console.WriteLine("What is your first name: ");
string? firstName = Console.ReadLine();
firstName = firstName.ToLower();


if (firstName == "lasse")
{
    Console.WriteLine($"Omggggg its the hot famous {firstName}. He has to receive VIP treatment!");
    Console.WriteLine("Would you like 10 champagnes on your table?");
    string? serviceAnswer = Console.ReadLine();

    if (serviceAnswer == "yes")
    {
        Console.WriteLine("omggg thats amaaaaziiiing. Here you go say if you need more");
    }
    else
    {
        Console.WriteLine("okiii mister enjoy your soooo coool evening");
    }
}
else
{
    Console.WriteLine($"Oh my goood so boring. It's just a regular dude. His first name is {firstName}. That suxxxx");
}

Console.WriteLine("End program");