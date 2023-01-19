using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> num = new List<int>();
        int number = 0;

        do {
            Console.Write("Enter a number (0 to quit): ");
            string newNum = Console.ReadLine();
            number = int.Parse(newNum);

            if (number != 0) {
                num.Add(number);
            }

        }while (number != 0);

        int sum = 0;
        foreach (int i in num) {
            sum += i;
        }
        Console.WriteLine($"The Sum Is: {sum}");

        float avg = ((float)sum) / num.Count;
        Console.WriteLine($"The Average Is: {avg}");

        int maximum = num[0];

        foreach (int i in num) {
            if (i > maximum) {
                maximum = i;
            }
        }
        Console.WriteLine($"The Max Is: {maximum}");
    }
}