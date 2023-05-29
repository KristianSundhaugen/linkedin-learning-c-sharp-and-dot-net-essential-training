// LinkedIn Learning Course .NET Programming with C# by Joe Marini
// Example file for parsing numerical data from strings

string[] NumStrs = {"  1 ", " 1.45  ", "-100", "5e+04 "};

int testint;
float testfloat;
bool result;

// TODO: The Parse method attempts to parse a string to a number and
// throws an exception if the parse is unsuccessful
foreach (string str in NumStrs) {
    try
    {
        testfloat = float.Parse(str);
        System.Console.WriteLine($"Parsed number is {testfloat}");
        testint = int.Parse(str);
        System.Console.WriteLine($"Parsed int is {testint}");
    }
    catch (System.FormatException e)
    {
        System.Console.WriteLine($"Could not parse '{str}' : {e.Message}");    
    }
}

// TODO: The TryParse method returns 'true' if the parse is successful
result = int.TryParse(NumStrs[0], out testint);
System.Console.WriteLine($"{result} --  '{NumStrs[0]}' : {testint}");

result = float.TryParse(NumStrs[1], out testfloat);
System.Console.WriteLine($"{result} --  '{NumStrs[1]}' : {testfloat}");

result = int.TryParse(NumStrs[2], out testint);
System.Console.WriteLine($"{result} --  '{NumStrs[2]}' : {testint}");

result = float.TryParse(NumStrs[3], out testfloat);
System.Console.WriteLine($"{result} --  '{NumStrs[3]}' : {testfloat}");