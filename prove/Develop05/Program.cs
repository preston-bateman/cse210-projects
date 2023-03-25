using System;

class Program
{
    static void Main(string[] args)
    {
        List<Goals> goals = new List<Goals>();
        int points = 0;
        int action = 0;
        while (action != 6){
            Console.Clear();
            action = MenuHandler.RunMenu(points);
            switch(action){
                case 1:
                    Console.Clear();
                    int createType = MenuHandler.CreateMenu();
                    switch(createType) {
                        case 1:
                            break;
                        case 2:
                            break;
                        case 3:
                            break;
                    }
                    break;
                case 2:
                    foreach (Goals goal in goals){
                        
                    }
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
                case 6:
                    break;
            }
        }
    }
}