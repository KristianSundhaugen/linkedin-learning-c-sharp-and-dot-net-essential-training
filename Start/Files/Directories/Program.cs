// LinkedIn Learning Course .NET Programming with C# by Joe Marini
// Creating and Deleting Directories

// const string dirname = "TestDir";

// TODO: Create a Directory if it doesn't already exist
// if(!Directory.Exists(dirname)){
//     Directory.CreateDirectory(dirname);
// }
// else {
//     Directory.Delete(dirname);
// }

// TODO: Get the path for the current directory
string curPath = Directory.GetCurrentDirectory();
// System.Console.WriteLine($"Current directory is {curPath}");

// TODO: Just like with files, you can retrieve info about a directory
// DirectoryInfo di = new DirectoryInfo(curPath);
// System.Console.WriteLine($"{di.Name}");
// System.Console.WriteLine($"{di.Parent}");
// System.Console.WriteLine($"{di.CreationTime}");

// TODO: Enumerate the contents of directories
Console.WriteLine("Just directories:");
List<string> thedirs = new List<string>(Directory.EnumerateDirectories(curPath));

foreach (string dir in thedirs)
{
    System.Console.WriteLine(dir);
}

Console.WriteLine("---------------");

Console.WriteLine("Just files:");

List<string> thefiles = new List<string>(Directory.EnumerateFiles(curPath));

foreach (string files in thefiles)
{
    System.Console.WriteLine(files);
}

Console.WriteLine("---------------");

Console.WriteLine("All directory contents:");

List<string> thefilesystems = new List<string>(Directory.EnumerateFileSystemEntries(curPath));

foreach (string filesystems in thefilesystems)
{
    System.Console.WriteLine(filesystems);
}
