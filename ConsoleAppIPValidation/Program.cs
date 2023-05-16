using System.Net;
using System.Text.RegularExpressions;

//while(!Console.KeyAvailable) //(Console.ReadKey(true).Key != ConsoleKey.X)
do 
{
    // Type your ip and press enter
    Console.WriteLine("enter Ip");
    // Create a string variable and get user input from the keyboard and store it in the variable
    string ip = Console.ReadLine();
    //Initialize IP address
    //IPAddress ipaddrss;
    //Regular expression of IP address
    Regex regip = new Regex(@"\b\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}\b");
    //find match between regular expression and enterd value
    MatchCollection result = regip.Matches(ip);
    if (result.Count == 0)
    {
        Console.WriteLine("Invalid");
    }
    else
    {
        Console.WriteLine("Valid");
    }
}
while (Console.ReadKey().Key != ConsoleKey.X);

