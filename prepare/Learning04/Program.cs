using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment test = new Assignment();
        test.SetStudentName("Ben Midgley");
        test.GetStudentName();
        Console.WriteLine(test.GetSummary());

        MathAssignment math1 = new MathAssignment();
        math1.SetStudentName("Seymour Butts");
        math1.SetTopic("Complex Polynomil Algorythms: Why They Are Made Up");
        math1.SetProblems("All of them...Till you die");
        math1.SetTextBookSection("Infinity");
        Console.WriteLine($"{math1.GetSummary()} and {math1.GetHomeworkList()}");

        WritingAssignment writer = new WritingAssignment();
        writer.SetTitle("Green Eggs and Hamm");
        writer.SetTopic("Childrens Fiction and Fun");
        writer.SetStudentName("Al Coholic");
        Console.WriteLine($"{writer.GetSummary()} and {writer.GetWritingInformation()}");
    }
}