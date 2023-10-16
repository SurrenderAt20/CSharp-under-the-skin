

string firstName = "pernilless";
int age = 77;

switch (age)
{

    case < 18:
        Console.WriteLine("you are not an adult");
        break;

    case >= 18 and < 66:
        Console.WriteLine("You should have a job");
        break;

    case >= 66:
        Console.WriteLine("You are retiring soon");
        break;

    default:
        Console.WriteLine("Age was not in an expected range");
        break;
}


/*
switch (firstName.ToLower())
{
    case "lasse" or "pernille":
        Console.WriteLine("Hello student");
        break;

    case "mark":
        Console.WriteLine("Hello Mark");
        break;

    default:
        Console.WriteLine("I don't know you");
        break;
}

*/
