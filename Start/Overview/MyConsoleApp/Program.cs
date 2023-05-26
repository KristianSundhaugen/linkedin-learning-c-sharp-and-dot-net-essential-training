// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string response;
Console.WriteLine("What's your name?");
response = Console.ReadLine();
Console.WriteLine($"Enjoy the course, {response}");

// Use the platform to get some information about the system
OperatingSystem thisOS = Environment.OSVersion;
Console.WriteLine(thisOS.Platform);
Console.WriteLine(thisOS.VersionString);