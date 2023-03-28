using System;

public class Breathing : Activity{
    private string _bIN = "Breath in...";
    private string _bOut = "Now breath out...";

    public Breathing(){
        _name = "Breathing Activity";
        _desc = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus completely on your breathe.";
    }

    public string GetIn(){
        return _bIN;
    }

    public string GetOut(){
        return _bOut;
    }


    public void BreathIn(){
        Console.Write(_bIN);
        Count countIn = new Count(4);
        countIn.GetCount();
        Console.WriteLine();
    }

    public void BreathOut(){
        Console.Write(_bOut);
        Count countIn = new Count(4);
        countIn.GetCount();
        Console.WriteLine();
    }
    
    public void BreathingActivity(){
        Console.Clear();
        Intro();
        Console.Clear();
        Console.WriteLine("Get Ready...");
        var spin = new Spinner();
        spin.GetSpinner();

    }


}