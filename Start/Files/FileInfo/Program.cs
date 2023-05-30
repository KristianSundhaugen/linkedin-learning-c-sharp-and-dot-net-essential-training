// LinkedIn Learning Course .NET Programming with C# by Joe Marini
// Working with file information

// Make sure the example file exists
const string filename = "TestFile.txt";

if (!File.Exists(filename)) {
    using (StreamWriter sw = File.CreateText(filename)) {
        sw.WriteLine("This is a text file.");
    }
}

// TODO: Get some information about the file
// System.Console.WriteLine(File.GetCreationTime(filename));
// System.Console.WriteLine(File.GetLastWriteTime(filename));
// System.Console.WriteLine(File.GetLastAccessTime(filename));

// File.SetAttributes(filename, FileAttributes.ReadOnly);
// System.Console.WriteLine(File.GetAttributes(filename));

// TODO: We can also get general information using a FileInfo 
// try
// {
//     FileInfo fi = new FileInfo(filename);
//     System.Console.WriteLine($"{fi.Length}");
//     System.Console.WriteLine($"{fi.Directory}");
//     System.Console.WriteLine($"{fi.IsReadOnly}");
// }
// catch (System.Exception e)
// {
//     System.Console.WriteLine($"Exception: {e}");
// }

// TODO: File information can also be manipulated
DateTime dt = new DateTime(2020, 7, 1);
File.SetCreationTime(filename, dt);
System.Console.WriteLine(File.GetCreationTime(filename));
