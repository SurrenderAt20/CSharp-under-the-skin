//Array is a variable type which holds a bunch of something more or less


//string array
//New string array with the length of 5 - when defining the number is the amount of values hold
//string[] firstNames = new string[5];

////When I assign the variable with a number like below it's defining the position in the array | We operate with 0 based counting. 0,1,2,3,4
//firstNames[0] = "Lasse";
//firstNames[1] = "Mark";
//firstNames[2] = "James";
////not forced into use all of them it is rarely done however
//firstNames[4] = "Corey";


//Console.WriteLine($"The firstNames are {firstNames[0]}, {firstNames[1]}, {firstNames[2]}, {firstNames[4]},");
//firstNames[0] = "John";
//Console.WriteLine(firstNames[0]);
//firstNames[5] = "Messi";

//single quote identifies a char
//double identifies a string


string data = "bob,sue,hanes,mark,bobby";
string[] firstNames = data.Split(',');

Console.WriteLine($"{firstNames[1]}");

Console.WriteLine(firstNames.Length);

string[] lastNames = new string[] { "corey", "smith", "jones" };
int[] ages = new int[] {2,3,4};


string[] brothers = new string[] { "Morten, Mikkel" };
int[] brothersAge = new int[] {23, 33};

string friendsdata = "jonathan, niklas, ludvig, teis, oscar, kasper";
string[] friends = friendsdata.Split(",");

Console.WriteLine($"{friends[2]}");