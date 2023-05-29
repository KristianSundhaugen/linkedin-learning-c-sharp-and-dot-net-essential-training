// LinkedIn Learning Course .NET Programming with C# by Joe Marini
// Example file for searching string content

string teststr = "The quick brown Fox jumps over the lazy Dog";

// TODO: Contains determines whether a string contains certain content
// System.Console.WriteLine($"{teststr.Contains("fox")}");
// System.Console.WriteLine($"{teststr.Contains("fox", StringComparison.CurrentCultureIgnoreCase)}");

// TODO: StartsWith and EndsWith determine if a string starts 
// or ends with a given test string
// System.Console.WriteLine($"{teststr.Contains("the")}");
// System.Console.WriteLine($"{teststr.Contains("the", StringComparison.CurrentCultureIgnoreCase)}");
// System.Console.WriteLine($"{teststr.Contains("dog")}");
// System.Console.WriteLine($"{teststr.Contains("dog", StringComparison.CurrentCultureIgnoreCase)}");

// TODO: IndexOf, LastIndexOf finds the index of a substring
// System.Console.WriteLine($"{teststr.IndexOf("the")}");
// System.Console.WriteLine($"{teststr.LastIndexOf("the")}");
// System.Console.WriteLine($"{teststr.IndexOf("the", StringComparison.CurrentCultureIgnoreCase)}");

// TODO: Determining empty, null, or whitespace
string str1 = null;
string str2 = "   ";
string str3 = String.Empty;

System.Console.WriteLine($"{String.IsNullOrEmpty(str1)}");
System.Console.WriteLine($"{String.IsNullOrEmpty(str2)}");
System.Console.WriteLine($"{String.IsNullOrWhiteSpace(str3)}");
