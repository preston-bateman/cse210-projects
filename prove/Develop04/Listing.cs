using System;
using System.Diagnostics;

public class Listing : Activity{
    private string[] _listQuestions = new string[]{
        "Who are people that you appreciate?",
        "What are personal strengths fo yours?",
        "Who are people that you have helped this week?",
        "Do you like pineapple on your pizza, and if so, why do you hate yourself?",
        "When have you felt the Holy Ghost this month?",
        "Who are some personal heroes in your life?",
        "What is the average wing speed velocity of an unladen swallow?"
    };
    private Spinner _thisSpin = new Spinner();
    private Count counter = new Count(5);

    public Listing(){
        _name = "Listing Activity";
        _desc = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area";
    }

    public void GetListPrompt(){
        Random rando = new Random();
        int i = rando.Next(this._listQuestions.Length);
        string listQuestion = this._listQuestions[i];
        Console.WriteLine($"\n---{listQuestion}---\n");
    }

    public void ListingActivity(){
        int listCount = 0;

        Console.Clear();
        int timer = Intro();
        Console.Clear();
        Console.WriteLine("Get ready...");
        _thisSpin.GetSpinner();
        Console.WriteLine();
        Console.WriteLine("List as many responses you can to the following prompt: ");
        GetListPrompt();
        Console.Write("You may begin in: ");
        counter.GetCount();
        Console.WriteLine();
        Stopwatch stopper = new Stopwatch();
        stopper.Start();
        while(timer > stopper.Elapsed.TotalSeconds){
            Console.Write(">");
            Console.ReadLine();
            listCount++;
        }
        stopper.Stop();
        Console.WriteLine($"You listed {listCount} items!");
        Outro();
    }


}