using System;

public class GoalManager{
    private List<Goals> _goalList = new List<Goals>();
    private int _points;

    //constructors
    public GoalManager(){}

    public List<Goals> GetGoalList(){
        return _goalList;
    }
    public void SetGoalList(List<Goals>goalList){
        _goalList = goalList;
    }
    public int GetPoints(){
        return _points;
    }
    public void SetPoints(int points){
        _points = points;
    }
    
    //Methods
    public void RecordEvent(){

    }
    public void Display(){

    }
    public void AddGoal(){

    }
    public void Save(){

    }
    public void Load(){
        
    }

}