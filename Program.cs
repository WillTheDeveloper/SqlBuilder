using SqlBuilder;

Console.WriteLine("Welcome to SQL Builder in CLI");
Console.WriteLine("Please select an option:");
Console.WriteLine("1. Create a new query");

var selection = Console.ReadLine();

var number = Convert.ToInt32(selection);

switch (number)
{
    case 1:
        new NewQuery().Begin();
        break;
}