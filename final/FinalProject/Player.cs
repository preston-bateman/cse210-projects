using System;

public class Player{
    protected int _playerNumber;
    protected LeftHand _lefty;
    protected RightHand _righty;
    private int _isOut = 0;

    public Player(){
        _lefty = new LeftHand(_playerNumber);
        _righty = new RightHand(_playerNumber);
    }

    public int AttackHand(){
        Console.WriteLine("Which hand will you attack with?");
        Console.WriteLine("1 for Left Hand");
        Console.WriteLine("2 for Right Hand");
        string choice = Console.ReadLine();
        int adder = Int32.Parse(choice);
        return adder;
    }

    public int DefendHand(){
        Console.WriteLine("Which hand are you attacking?");
        Console.WriteLine("1 for opponents Left Hand");
        Console.WriteLine("2 for opponents Right Hand");
        string choice = Console.ReadLine();
        int defender = Int32.Parse(choice);
        return defender;
    }

    public int GetHandScore(int hand){
        int score;
        if(hand == 1){
            score = _lefty.GetScore();
        }else if(hand == 2 ) {
            score = _righty.GetScore();
        }else {
            score = 0;
        }
        return score;
    }

    public void AddScoreToHand(int num, int handnum){
        if(handnum  == 1){
            _lefty.ChangeScore(num);
        }else if (handnum == 2){
            _righty.ChangeScore(num);
        }
    }

    public int GetOut(){
        return _isOut;
    }

    public void DisplayHands(){
        Console.WriteLine($"{_lefty.GetID()}---{_righty.GetID()}");
        Console.WriteLine($"        {_lefty.GetScore()}                 {_righty.GetScore()}");
    }
}