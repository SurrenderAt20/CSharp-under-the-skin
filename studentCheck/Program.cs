Console.WriteLine("Hello sir/mrs. What is your name?");
string? firstName = Console.ReadLine();

Console.WriteLine($"Lovely to meet you {firstName}. May I ask what your number of age is?");
string? ageText = Console.ReadLine();

int age;
if (int.TryParse(ageText, out age))
{
    string formattedName;


    if (firstName.ToLower() == "lasse" && age >= 21 || firstName.ToLower() == "yasse" && age >= 21)
    {
        formattedName = $"Professor {firstName}";
    }
    else
    {
        formattedName = firstName;
    }

    if (age >= 21 && age < 70)
    {
        Console.WriteLine($"Nice to meet you {formattedName}. You meet the age requirements");
    }
    else if (age > 70)
    {
        Console.WriteLine("Sorry amigo but you are to old to be enrolled. The app stops here");
        return;
    }
    else
    {
        int applyingAge = 21 - age;
        Console.WriteLine($"Dear {formattedName}. You do not meet the age requirements yet. Please apply in {applyingAge} years");
    }
}