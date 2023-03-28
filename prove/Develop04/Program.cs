using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.Write("Welome to Zen! Your Mindfulness Program.");
        Console.Clear();
        int action = 0;

        static int DisplayMenu(){
            Console.Clear();
            Console.WriteLine("Menu:");
            Console.WriteLine(" ");
            Console.WriteLine("Please select one of the following options:");
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Reflection Activity");
            Console.WriteLine("3. Start Listening Activity");
            Console.WriteLine("4. Quit");
            Console.WriteLine(" ");
            Console.Write("Enter your selection number(1-4):");
            string resp= Console.ReadLine();
            int respNum = int.Parse(resp);
            return respNum;
        }

        while (action != 4) {
            action = DisplayMenu();

            switch(action){
                case 1:
                    Breathing activ = new Breathing();
                    activ.BreathingActivity();
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
            }
        }



    }
}