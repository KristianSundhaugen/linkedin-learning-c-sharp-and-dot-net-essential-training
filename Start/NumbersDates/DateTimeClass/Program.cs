// LinkedIn Learning Course .NET Programming with C# by Joe Marini
// Example file for working with Dates and Times

// TODO: Use DateTime.Now property to get the current date and time
DateTime now = DateTime.Now;
// System.Console.WriteLine(now);

// TODO: DateTime.Today gets just the current date with time set to 12:00:00 AM
DateTime today = DateTime.Today;
// System.Console.WriteLine(today);

// TODO: DateOnly and TimeOnly represent just dates and times
// DateOnly dt = DateOnly.FromDateTime(DateTime.Now);
// TimeOnly tm = TimeOnly.FromDateTime(DateTime.Now);
// System.Console.WriteLine(dt);
// System.Console.WriteLine(tm);

// TODO: Dates have properties that can be inspected
// System.Console.WriteLine(today.DayOfWeek);
// System.Console.WriteLine(today.DayOfYear);

// TODO: Dates also have methods to change their values
// now = now.AddDays(5);
// now = now.AddHours(9);
// now = now.AddMonths(1);
// System.Console.WriteLine(now);

// TODO: The TimeSpan class represents a duration of time
// DateTime AprilFools = new DateTime(now.Year, 4, 1);
// DateTime NewYears = new DateTime(now.Year, 1, 1);
DateTime AprilFools = new DateTime(now.Year, 4, 1);
DateTime NewYears = new DateTime(now.Year, 1, 1);
TimeSpan interval = AprilFools - NewYears;
System.Console.WriteLine(interval);

// TODO: Dates can be compared using regular operators
System.Console.WriteLine($"{NewYears < AprilFools}");
System.Console.WriteLine($"{NewYears > AprilFools}");