
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