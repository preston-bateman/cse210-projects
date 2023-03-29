using System;

public abstract class Hand{
    protected int _score = 0;
    protected string _id = "";
    protected int _playerNum = 0;
    protected string _status = "IN";

    
    public Hand (){

    }
    public Hand(int playerNum){
        _playerNum = playerNum;
        _score = 1;
    }

    public void ChangeScore(int attackingScore){
        _score += attackingScore;
        StatusChanger();
    }

    public int GetScore(){
        return _score;
    }
    
    public abstract void CreateID();

    public string GetID(){
        return _id;
    }


    public string StatusCheck(){
        return _status;
    }

    public void StatusChanger(){
        if(_score >= 5){
            _status = "OUT";
        }
        else {}
    }
}