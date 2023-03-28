using System;

public class LoadSave{
    private List<Goals> _goals = new List<Goals>();
    private int _points = 0;

    public void SaveGoals(List<Goals> goals, int points) {
        Console.WriteLine("Name of Saving File?");
        string fileName = Console.ReadLine();
        using(StreamWriter sw = new StreamWriter(fileName, true)){
            sw.WriteLine(points);
            foreach (Goals save in _goals){
                sw.WriteLine($"{save.SaveGoal()}");
            }
        }
    }

    public void LoadGoals(){
        Console.WriteLine("What's the name of the file you want to load from?");
        string loadFile = Console.ReadLine();
        string lines;

        using (StreamReader sr = new StreamReader(loadFile)){
            lines = sr.ReadLine();
            _points = int.Parse(lines);

            while((lines = sr.ReadLine()) != null){
                string[] goalParts = lines.Split(",");
                string goalType = goalParts[0];
                if (goalType == "Simple Goal:") {
                    var goal = new SimpleGoals(goalParts[1], goalParts[2]);
                    _goals.Add(goal);
                }
            }
        }
    }
}