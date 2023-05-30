using System.Text.RegularExpressions;

class Program
{
    const string pattern = @"^(0?[1-9]|1[0-2])/(0?[1-9]|1\d|2\d|3[01])/\d{4}$";
    static void Main()
    {
        string writtenDate;
        //Get input from user
        Console.WriteLine("Date to convert? ( Use mm/dd/yyyy or 'exit' to quit)");
        writtenDate = Console.ReadLine();

        if (writtenDate == "exit")
        {
            System.Environment.Exit(1);
        }

        if (IsDateFormatValid(writtenDate, pattern))
        {
            System.Console.WriteLine($"The reversed format is: {ReverseDateFormat(writtenDate)}");
        }
        else
        {
            System.Console.WriteLine("That is not a valid date, try again");
        }

    }

    static bool IsDateFormatValid(string input, string pattern)
    {
        return Regex.IsMatch(input, pattern);
    }


    static string ReverseDateFormat(string input)
    {
        const int TIMEOUT = 1000;
        try
        {
            return Regex.Replace(input,
                    @"^(?<mon>\d{1,2})/(?<day>\d{1,2})/(?<year>\d{2,4})$",
                    "${year}-${mon}-${day}", RegexOptions.None,
                    TimeSpan.FromMilliseconds(TIMEOUT));
        }
        catch (RegexMatchTimeoutException)
        {
            return input;
        }
    }

}

