using System;

public class Verse{
    private List<Word> _words =  new List<Word>();
    private bool _allHidden;

    //constructors
    public Verse(){}
    public Verse(string content) {
        foreach(string i in content.Split(' ')){
            Word word = new Word(i);
            _words.Add(word);
        }
        _allHidden = false;
    }

    public void Display(){
        foreach(Word i in _words){
            i.Display();
            Console.Write(" ");
        }
        Console.WriteLine("");
    }

    public void HideRandom(){
        
    }
    public bool GetAllHidden(){
        if(_allHidden == false){
            return false;
        }else {
            return true;
        }
    }



}