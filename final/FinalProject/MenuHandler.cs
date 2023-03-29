
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

}