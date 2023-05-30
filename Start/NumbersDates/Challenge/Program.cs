// Chalange is: Make the script take a input of valid date, then output how many days since/until that day

//TODO get a time of today
string writtenTime;
DateTime writtenTimeResult;
//Get input from user
Console.WriteLine("What time are you writing?");
writtenTime = Console.ReadLine();

if(writtenTime == "exit")
{
    System.Environment.Exit(1);
}



//Parse string from user to see if valid date format
if(DateTime.TryParse(writtenTime, out writtenTimeResult))
{
    DateTime todaysTime = DateTime.Today;

    if(writtenTimeResult > todaysTime)
    {
        int daysBetween =  (writtenTimeResult - todaysTime).Days;
        System.Console.WriteLine($"That date will be in {daysBetween} days!");
    } 
    else if(writtenTimeResult < todaysTime) 
    {
        int daysBetween =  (todaysTime - writtenTimeResult).Days;
        System.Console.WriteLine($"That date went by {daysBetween} days ago!");
    } 
    else 
    {
        System.Console.WriteLine("That date is today!");
    }

} 
else 
{
    System.Console.WriteLine("Written time isn't a date time");
}