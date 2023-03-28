using System;

public class Activity{
    
    //attributes
    protected string _name;
    protected int _duration;
    protected string _desc;
    private string _exitMSG;


    public string GetName(){
        return this._name;
    }
    public void SetName(string name){
        _name = name;
    }
    public string GetDesc(){
        return this._desc;
    }
    public void SetDesc(string desc){
        _desc = desc;
    }
    public int GetDuration(){
        return this._duration;
    }
    public void SetDuration(){
        Console.Write($"How long, in seconds, would you like for your session? ");
        int duration = Int32.Parse(Console.ReadLine());
        _duration = duration;
    }
    public string GetExit(){
        return _exitMSG;
    }
    public void SetExit(){
        _exitMSG = $"You have completed another {_duration} seconds of the {_name}.";
    }

    public void Intro(){
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine(" ");
        Console.WriteLine($"{_desc}");
        SetDuration();
    }

    public void Outro(){
        Console.WriteLine($"Well Done!!!");
        Console.WriteLine(" ");
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}.");
    }
}