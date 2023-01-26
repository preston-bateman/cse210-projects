using System;
using System.Collections.Generic;

public class Journal{
    public List<Entry> entries = new List<Entry> ();
    
    
    public Journal (){
        
    }

public void Display(){
    Console.WriteLine("All of your Journal Entries:");
    foreach(Entry i in entries) {
        Console.WriteLine($"{i.entryDate}");
        Console.WriteLine($"{i.prompt}");
        Console.WriteLine($"{i.response}");
    }
}

}