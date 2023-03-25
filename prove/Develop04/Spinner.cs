using System;

public class Spinner{
    public Spinner(){}

    public void GetSpinner(){
        int spinTime = 0;
        while (spinTime != 3){
            Console.Write("|");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("/");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("-");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("\\");
            Thread.Sleep(500);
            Console.Write("\b \b");
            spinTime += 1;
        }
    }
}