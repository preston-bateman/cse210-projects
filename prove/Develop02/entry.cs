using System;
using System.Collections.Generic;

[Serializable]
public class Entry {
    public string entryDate;
    public string prompt;
    public string response;

    public Entry(string selectedPrompt){
        prompt = selectedPrompt;
        entryDate = GenerateDate();
        response = GetResponse();
    }

    public string GetResponse(){
        Console.WriteLine($"{prompt}:");
        string entry = Console.ReadLine();
        return entry;
    }
    public string GenerateDate(){
        var todayDate = DateTime.Today;
        string todayString = todayDate.ToShortDateString();
        return todayString;
    }

}