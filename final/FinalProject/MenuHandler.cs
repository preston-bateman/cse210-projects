
using System;

public class MenuHandler{
    public static int RunMenu(){
        Console.WriteLine($"Main Menu:");
        Console.WriteLine();
        Console.WriteLine($"1. Create New Game");
        Console.WriteLine($"2. Quit");
        Console.Write($"Enter your selection number: ");
        string answer = Console.ReadLine();
        int selection = int.Parse(answer);

        return selection;
    }

    public static int CreateMenu(){
        Console.WriteLine($"What type of Goal do you wish to make:");
        Console.WriteLine($"1. Simple Goal");
        Console.WriteLine($"2. Eternal Goal");
        Console.WriteLine($"3. Checklist Goal");
        Console.Write($"Enter the number for the Goal Type: ");
        string newanswer = Console.ReadLine();
        int selection = int.Parse(newanswer);

        return selection;
    }
}