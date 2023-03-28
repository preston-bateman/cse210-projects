using System;

public class Reflecting : Activity {
    
    //attributes
    private string[] _promptList = new string[]{
        "Think of a time when you stood up for yourself.",
        "Think on the most difficult thing you have ever done.",
        "Think of a time where you truly served another person.",
        "Think of a time that you did not live up to your vision of yourself."
    };
    private string[] _questions = new string[]{
        "Was this a meaningful experience for you?",
        "Have you talked about this experience with a significant other?",
        "What is something you would have done differently if you could?",
        "How did you grow from this experience?",
        "How did this experience build your character?",
        "If this experience was a movie, would you be the good guy in it?",
        "What is the first emotion you feel when you thing of this experience?"
    };

    public Reflecting(){
        _name = "Reflecting Activity";
        _desc = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    }

    public void GetPrompt(){
        Console.WriteLine("Get Ready...");
        Console.WriteLine();
        Console.WriteLine("Consider the following prompt: ");
        Console.WriteLine();
        Random randomP = new Random();
        int i = randomP.Next(this._promptList.Length);
        string prompt = this._promptList[i];
        Console.WriteLine($"\n---{prompt}---\n");
        Console.WriteLine("When you have something in mind, press enter to start...");
    }

    public void GetQuestions(){
        Random rando = new Random();
        int i = rando.Next(this._questions.Length);
        string question = this._questions[i];
        Console.Write($"{question}  ");
        var spin = new Spinner();
        spin.GetSpinner();
    }

    public void ReflcetingActivity(){
        int timer = GetDuration();

        Console.Clear();
        Intro();
        Console.Clear();
        GetPrompt();
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
        Console.Write("You may begin in: ");
        var count = new Count(5);
        count.GetCount();
        Console.Clear();

        while(timer != 0){
            GetQuestions();
        }
        this.Outro();
    }

    
}