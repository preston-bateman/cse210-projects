using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the number grade of your assignment?");
        string numGradeString = Console.ReadLine();
        int numGrade = int.Parse(numGradeString);
        string letter = "";
        string plusOrMinus = "null";

        if (numGrade < 60) {
            letter = "F";
        }
        else if (numGrade < 70) {
            letter = "D";
        }
        else if (numGrade < 80) {
            letter = "C";
        }
        else if (numGrade < 90) {
            letter = "B";
        }
        else if (numGrade <= 100) {
            letter = "A";
        }

        if (numGrade % 10 >= 7 ) {
            plusOrMinus = "+";
        }
        else if (numGrade % 10 < 3) {
            plusOrMinus = "-";
        }
        else {
            plusOrMinus = null;
        }

        if (plusOrMinus == "-" || plusOrMinus == "+") {
            letter += plusOrMinus;
        }
        else {
            letter = letter;
        }

        if (letter == "F") {
            Console.WriteLine($"Sorry you failed with an {letter}");
        }
        else {
            Console.WriteLine($"You made an {letter}");
        }


    }
}