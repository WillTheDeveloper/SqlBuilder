using System.Data.Common;

namespace SqlBuilder;

public class Select
{
    private List<string> parameters = null!;
    private string Table = "";
    private List<Selectors> selectors = null!;

    /// <summary>
    /// Get the information regarding the new SELECT query
    /// </summary>
    public void Information()
    {
        Console.WriteLine("What is the name of the table?");
        Table = Console.ReadLine()!;
        Console.WriteLine("Which columns would you like to select? Asterisk is accepted");

        /*var input = new List<string>();*/

        var columns = Console.ReadLine();
        
        Console.WriteLine("Enter a selector for WHERE statement which will be added:");
        
        Console.WriteLine("Name of column:");
        
        var wherecolumn = Console.ReadLine();
        
        Console.WriteLine("Enter value to check for");

        var comparator = Console.ReadLine();

        selectors.Add(new Selectors()
        {
            Tab = wherecolumn!,
            Param = comparator!
        });

        if (columns != "")
        {
            Console.WriteLine("Enter name of column");
            var add = Console.ReadLine();
            if (add != "")
            {
                parameters.Add(columns!);
            }
            else if (add == "*")
            {
                parameters.Add("*");
                Generate();
            }
        }
    }

    /// <summary>
    /// Generate the query and output it to the user
    /// </summary>
    public void Generate()
    {
        Console.Clear();

        var outputcolumns = "";

        foreach (var col in parameters)
        {
            outputcolumns = outputcolumns + col! + ",";
        }
        
        if (parameters == null)
        {
            outputcolumns = "*";
        }
        
        Console.WriteLine("Generated SQL SELECT command:");
        Console.WriteLine("SELECT " + outputcolumns + " FROM " + Table + " WHERE " + selectors.First().Tab + " = " + selectors.First().Param);
    }
}