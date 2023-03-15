using System;

public class Goals{
    protected string _name;
    protected string _desc;
    protected int _value;
    protected int _compCount;

    //constructors
    public Goals(){}
    public Goals(string name, string desc, int value){
        _name = name;
        _desc = desc;
        _value = value;
    }
    
    //getters and setters
    public string GetName(){
        return _name;
    }
}