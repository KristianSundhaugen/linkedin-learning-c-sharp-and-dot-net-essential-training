// LinkedIn Learning Course .NET Programming with C# by Joe Marini
// Example file for formatting date information
using System.Globalization;
// Define a date
DateTime AprFools = new DateTime(2025, 4, 1, 13, 23, 30);

// TODO: 'd' Short date: mm/dd/yyyy (or dd/mm depending on locale)
// System.Console.WriteLine($"{AprFools:d}");

// // TODO: 'D' Full date: mm/dd/yyyy (or dd/mm depending on locale)
// System.Console.WriteLine($"{AprFools:D}");


// // TODO: 'f' Full date, short time
// System.Console.WriteLine($"{AprFools:f}");

// // TODO: 'F' Full date, long time
// System.Console.WriteLine($"{AprFools:F}");

// // TODO: 'g' General date and time
// System.Console.WriteLine($"{AprFools:g}");

// // TODO: 'G' General date and time
// System.Console.WriteLine($"{AprFools:G}");

// TODO: Format using a specific CultureInfo
// System.Console.WriteLine(AprFools.ToString("d", CultureInfo.CreateSpecificCulture("de-DE")));

// TODO: Defining custom date and time formats
System.Console.WriteLine($"{AprFools:dddd, MMMM, d yyyy}");
System.Console.WriteLine($"{AprFools:ddd h:mm:ss tt}");
System.Console.WriteLine($"{AprFools:MMM d yyyy}");