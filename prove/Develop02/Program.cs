using System;
using System.IO;
using System.Data;
using Newtonsoft;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Converters;
using System.Collections.Generic;


class Program {
    static void Main(string[] args){
        int response = 0;
        Journal journal = new Journal();

        Console.WriteLine("Welcome to your new Digital Journal!");

        while (response != 5)
        {
            response = displayChoices();

            switch(response){
                case 1:
                    string prompt = randomPrompt();
                    Entry entry1 = new Entry(prompt);
                    journal.entries.Add(entry1);
                    break;
                case 2:
                    journal.Display();
                    break;
                case 3:
                    Console.Write("What is the file name");
                    string userFileName = Console.ReadLine();
                    if(File.Exists(userFileName))
                    {
                        var readEntry = JsonConvert.DeserializeObject<List<Entry>>(File.ReadAllText(userFileName));
                        for (int i = 0; i < readEntry.Count; i++){
                            journal.entries.Add(readEntry[i]);
                        }
                        Console.Write(readEntry);
                    }
                    else {
                        Console.WriteLine("File Doesn't exist please type the entire file path");
                    }
                    break;
                case 4:
                    var jList = journal.entries;
                    string json = JsonConvert.SerializeObject(jList, Formatting.Indented);
                    Console.Write("What is the file name (.json)?");
                    string saveFileName = Console.ReadLine();
                    if(File.Exists(saveFileName)){
                        File.WriteAllText(saveFileName, json);
                    }else{
                        File.WriteAllText(saveFileName, json);
                    }
                    break;
                case 5:
                    Console.WriteLine("Have a wonderful rest of your day. See you tomorrow!");
                    break;
                default:
                    Console.WriteLine("That is not a valid choice. Use only the menu numbers.");
                    break;
            }
        }

        static int displayChoices(){
            Console.WriteLine("Please Select one of the following:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do?");
            string response1 = Console.ReadLine();
            int numResponse = int.Parse(response1);
            return numResponse;
        }
        static string randomPrompt(){
            var random = new Random();

            var prompts = new List<string> {
                "What was your happiest moment today?",
                "How did you help someone else today?",
                "Who was your favorite person to talk with today?",
                "If you could go back in time, what is one thing you would have done differently today?",
                "What are you most grateful for today?",
                "What was the best part of your day today?"
            };

            int i = random.Next(prompts.Count);
            string selectedPrompt = prompts[i];
            return selectedPrompt;
        }















        //var fileName = @"C:\Code\School\CSE210\cse210-projects\prove\Develop02\test.json";
        //Entry entry = new Entry("test");

        //string json = JsonConvert.SerializeObject(entry, Formatting.Indented);

        //Object readEntry = JsonConvert.DeserializeObject<Object>(File.ReadAllText(fileName));
        //Console.Write(readEntry);
    }
}