// LinkedIn Learning Course .NET Programming with C# by Joe Marini
// Example file for formatting string content

float f1 = 123.4f;
int i1 = 2000;

// TODO: Spacing and Alignment: Indexes
System.Console.WriteLine("{0, -15} {1,10}", "Float Val", "Int Val");
System.Console.WriteLine("{0, -15} {1,10}", f1, i1);

// TODO: Spacing and Alignment: Interpolation
System.Console.WriteLine("{0, -15} {1,10}", "Float Val", "Int Val");
System.Console.WriteLine($"{f1, -15} {i1,10}");
