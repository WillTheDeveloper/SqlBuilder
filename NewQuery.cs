namespace SqlBuilder;

public class NewQuery
{
    public void Begin()
    {
        Console.Clear();
        Console.WriteLine("What kind of query do you want to make?");
        Console.WriteLine("1. SELECT");
        Console.WriteLine("2. INSERT");

        var selection = Console.ReadLine();
        var number = Convert.ToInt32(selection);

        switch (number)
        {
            case 1:
                new Select().Information();
                break;
        }
    }
}