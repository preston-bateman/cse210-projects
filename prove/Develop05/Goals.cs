using System;

public abstract class Goals{
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

    public Goals(string name, string desc){
        
    }
    
    //getters and setters
    public string GetName(){
        return _name;
    }

    public virtual string SaveGoal(){
        return $"{_name},{_desc},{_value},{_compCount}";
    }
}