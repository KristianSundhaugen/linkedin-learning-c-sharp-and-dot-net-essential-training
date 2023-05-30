using System;
using System.Collections.Generic;
using System.IO;

class FileAnalyzer
{
    private Dictionary<string, int> counts;

    public FileAnalyzer()
    {
        counts = new Dictionary<string, int>
        {
            ["totalFileCount"] = 0,
            ["excelFileCount"] = 0,
            ["wordFileCount"] = 0,
            ["ppFileCount"] = 0,
            ["totalFileSize"] = 0,
            ["excelFileSize"] = 0,
            ["wordFileSize"] = 0,
            ["ppFileSize"] = 0
        };
    }

    public void AnalyzeFiles(string directory)
    {
        List<string> files = new List<string>(Directory.EnumerateFiles(directory));

        foreach (string file in files)
        {
            string fileExtension = Path.GetExtension(file);

            if (IsValidFileExtension(fileExtension))
            {
                counts["totalFileCount"] += 1;

                if (fileExtension == ".pptx")
                {
                    IncrementCount("ppFileCount");
                    IncrementSize("ppFileSize", file);
                }
                else if (fileExtension == ".xlsx")
                {
                    IncrementCount("excelFileCount");
                    IncrementSize("excelFileSize", file);
                }
                else if (fileExtension == ".docx")
                {
                    IncrementCount("wordFileCount");
                    IncrementSize("wordFileSize", file);
                }

                IncrementSize("totalFileSize", file);
            }
        }
    }

    private bool IsValidFileExtension(string extension)
    {
        return extension == ".pptx" || extension == ".xlsx" || extension == ".docx";
    }

    private void IncrementCount(string key)
    {
        counts[key] += 1;
    }

    private void IncrementSize(string key, string file)
    {
        counts[key] += (int)new FileInfo(file).Length;
    }

    public void PrintResults()
    {
        Console.WriteLine("~~~~ Result ~~~~");
        Console.WriteLine($"Total Files: {counts["totalFileCount"]}");
        Console.WriteLine($"Excel Count: {counts["excelFileCount"]}");
        Console.WriteLine($"Word Count: {counts["wordFileCount"]}");
        Console.WriteLine($"PowerPoint Count: {counts["ppFileCount"]}");
        Console.WriteLine($"----");
        Console.WriteLine($"Total Size: {counts["totalFileSize"]}");
        Console.WriteLine($"Excel Size: {counts["excelFileSize"]}");
        Console.WriteLine($"Word Size: {counts["wordFileSize"]}");
        Console.WriteLine($"PowerPoint Size: {counts["ppFileSize"]}");
    }
        public void PrintResultsToFile(string resultPageName)
    {
        using (StreamWriter sw = new StreamWriter(resultPageName))
        {
            sw.WriteLine("~~~~ Result ~~~~");
            sw.WriteLine($"Total Files: {counts["totalFileCount"]}");
            sw.WriteLine($"Excel Count: {counts["excelFileCount"]}");
            sw.WriteLine($"Word Count: {counts["wordFileCount"]}");
            sw.WriteLine($"PowerPoint Count: {counts["ppFileCount"]}");
            sw.WriteLine($"----");
            sw.WriteLine($"Total Size: {counts["totalFileSize"]}");
            sw.WriteLine($"Excel Size: {counts["excelFileSize"]}");
            sw.WriteLine($"Word Size: {counts["wordFileSize"]}");
            sw.WriteLine($"PowerPoint Size: {counts["ppFileSize"]}");
        }
    }
}

class Program
{
    static void Main()
    {
        const string dirname = "FileCollection";
        const string resultPageName = "result.txt";

        FileAnalyzer analyzer = new FileAnalyzer();
        analyzer.AnalyzeFiles(dirname);
        analyzer.PrintResultsToFile(resultPageName);
        System.Console.WriteLine("Done");
    }
}
