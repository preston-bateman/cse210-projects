using System;

class Program
{
    static void Main(string[] args)
    {
        int action = 0;
        Console.Clear();
        Console.WriteLine("Welcome to the Finger Math Game!");
        Thread.Sleep(2000);

        while(action != 2){
            Console.Clear();
            action = MenuHandler.RunMenu();
            switch(action){
                case 1:
                    TurnHandler newGame = new TurnHandler();
                    newGame.Game();
                    break;
                case 2:
                    
                    break; 
            }
        }
    }
}