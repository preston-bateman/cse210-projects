using System;

public class Scripture{
    private string _ref;
    private List<Verse> _verses = new List<Verse>();
    private bool _hidden = false;

    //constructors
    public Scripture(){}
    public Scripture(string reference, List<string> verses){
        _ref = reference;
        foreach(string i in verses){
            Verse verse = new Verse(i);
            _verses.Add(verse);
        }

    }

   public void Hide(){
    foreach(Verse i in _verses){
        if(i.GetAllHidden() == false){
            i.HideRandom();
        }
    }
   }

}