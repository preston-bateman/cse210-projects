using System;

public class Word{
    private string _letters;
    private bool _clear = false;
    
    //constructors
    public Word(){}
    public Word(string text){
        _letters = text;
        _clear = false;
    }

    //methods

    public void Display(){
        if(_clear == true) {
            foreach(char letter in _letters){
                Console.Write("_");
            }
        }else {
                Console.Write(_letters);
        }
    }

    public void Clear() {
        _clear = true;
    }
    public bool IsCleared(){
        return _clear;
    }
}