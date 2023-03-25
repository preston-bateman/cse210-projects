using System;

public class Activity{
    
    //attributes
    protected string _name;
    protected string _duration;
    protected string _desc;
    private string _wellDone;
    private string _exitMSG;

    public Activity() {
        _name = "";
        _duration = "";
        _wellDone = "Well Done";
        _exitMSG = "";
    }

    public Activity(string name, string description){
        _name = name;
        _desc = description;
        _wellDone = "Well Done";
    }

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
    public string GetDuration(){
        return this._duration;
    }
    public void SetDuration(){
        Console.Write($"How long, in seconds, would you like for your session? ");
        string duration = Console.ReadLine();
        _duration = duration;
    }
    public string GetExit(){
        return this._exitMSG;
    }
    public void SetExit(string msg){
        _exitMSG = msg;
    }
}