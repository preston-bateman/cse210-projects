using System;

public class RightHand : Hand {
    private string _side = "Right";

    public RightHand(int playerNum) : base(playerNum){
        _playerNum = playerNum;
        _score = 1;
        CreateID();
    }

    public override void CreateID()
    {
        string x = _playerNum.ToString();
        _id = $"Player{x} {_side}Hand";
    }

}