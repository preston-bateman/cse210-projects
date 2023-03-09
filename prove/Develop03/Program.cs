using System;

class Program
{
    static void Main(string[] args)
    {
        //running program interaction
        List<string> verses = new List<string>();
        string verse = "";
        Console.Write("Enter the scripture reference: ");
        string reference = Console.ReadLine();

        //adding verses
        while(verse.ToLower() != "stop") {
            Console.WriteLine("Enter one verse. If you have entered in all the verses, type 'stop': ");
            verse = Console.ReadLine();
            if(verse.ToLower() != "exit") {
                verses.Add(verse);
            }
        }
        
        bool keepGoing = true;
        while(keepGoing == true) {
            Scripture scripture = new Scripture(reference, verses);
            Console.Clear();
            Console.WriteLine("Press ENTER to continue or type QUIT to end. ");
            string userInput = Console.ReadLine();
            while(scripture.AllHidden() == false){

            }
        }

    
    }
}