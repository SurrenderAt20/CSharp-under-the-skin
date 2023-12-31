﻿
//similar to string[] firstNames = new string[5]
using System.Reflection.Metadata;

List<string> firstNames = new List<string>();

firstNames.Add("Lasse");
firstNames.Add("Mark");
firstNames.Add("Jon");
firstNames.Add("Nate");
firstNames.Add("Navi");

//last element in the list
Console.WriteLine(firstNames[firstNames.Count -1]);

//new block - shown with integer

List<int> ages =  new List<int>();
ages.Add(1);
ages.Add(2);
ages.Add(3);
ages.Add(4);


//List<T> - generic | define yourself what that T(ype) is going to be

string data = "Lasse, Mark, Jenny, Navi";
List<string> lastNames = data.Split(',').ToList();
lastNames.Add("ipson");
lastNames.Add("carey");
lastNames.Add("pippi");

Console.WriteLine(lastNames[lastNames.Count - 1]);


string groceryData = "Eggs,Pasta,Break,Cheese,Milk";
List <string> gData = groceryData.Split(",").ToList();
gData.Add("chips");
gData.Add("sweets");

Console.WriteLine(gData[gData.Count -3]);

List<string> cars = new List<string>();
cars.Add("Mercedes");
cars.Add("Lambo");
cars.Add("Ferrari");
cars.Add("Porsche");

Console.WriteLine(cars[cars.Count -2]);

//testing the created list in a foreach
foreach (string car in cars)
{
    Console.WriteLine(car);
}


//static approach
List<string> studentsstat = new List<string>();
studentsstat.Add("Pernille");
studentsstat.Add("Lasse");
studentsstat.Add("Morten");
studentsstat.Add("Christian");
studentsstat.Add("Mikkel");
studentsstat.Add("Sassi");
studentsstat.Add("done");

int studentCountStat = studentsstat.Count;
Console.WriteLine($"This is the student count: {studentCountStat}");

//dynamic approach

List<string> students = new List<string>();

do
{
    Console.WriteLine("Enter student name or 'done' when no more values");
    string studentName = Console.ReadLine();
    if (studentName == "done")
    {
        Console.WriteLine("This is all students needed to be added to the roster!");
        break;
    }
    students.Add(studentName);

} while (true);

int studentCount = students.Count;
Console.WriteLine($"The student count for the roster is the following: {studentCount}");

//all student names in a foreach loop
foreach (string student in students)
{
    Console.WriteLine($"This are all the student names added to the roster: {student}");
}

for (int i = 0; i < studentCount; i++)
{
    Console.WriteLine(students[i]);
}


List<string> members = new List<string>();

do
{

    Console.WriteLine("Add the name of the member or value 'done' if you wish to end");
    string membersname = Console.ReadLine();

    if (membersname == "done")
    {
        Console.WriteLine("All members added - closing application");
        break;
    }

    members.Add(membersname);

} while (true);

int membersCount = members.Count;
Console.WriteLine($"This is all I need for the count and the count is: {membersCount}");

List <string> animals = new List<string>();

do
{
    Console.WriteLine("Enter the animal name or 'done' when there are no more values you wish to insert");
    string animalsname = Console.ReadLine();

    if (animalsname == "done")
    {
        Console.WriteLine("All animals has been added");
        break;
    }

    animals.Add(animalsname);

} while (true);

int animalsCount = animals.Count;
Console.WriteLine($"Total amount of animals are: {animalsCount}");

for (int i = 0;i < animalsCount; i++)
{
    Console.WriteLine(animals[i]);
}


