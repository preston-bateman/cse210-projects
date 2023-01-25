using System;

class Program
{
    static void Main(string[] args)
    {


        Console.WriteLine("Welcome To Your Journal");
        string response = DisplayChoices();
        

        static string DisplayChoices() {
            Console.WriteLine("Please Select one of the following:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do?");
            string response = Console.ReadLine();
            if (response == "1" || response == "2" || response == "3" || response == "4" || response == "5") {
                return response;
            }
            else {
                Console.WriteLine("Please enter the number of your selection. Eg: '1'");
                return "" + DisplayChoices();
            }
        }
        Console.WriteLine($"You chose: {response}");
    }
}