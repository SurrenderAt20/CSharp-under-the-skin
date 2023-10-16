using System.Globalization;

DateTime today = DateTime.Now;

//DateTime birthday = DateTime.Parse("15/6/1998");
//DateTime birthday = DateTime.ParseExact("12/9/2002", "d/M/yyyy", CultureInfo.InvariantCulture);
//Console.WriteLine(birthday.ToString());

Console.WriteLine(today.ToString("MMMM dd, yyyy HH: mm tt zzz"));

//DateOnly

DateOnly birthday = DateOnly.Parse("5/3/1995");
Console.WriteLine(birthday.ToString("MMMM/dd/yyyy"));