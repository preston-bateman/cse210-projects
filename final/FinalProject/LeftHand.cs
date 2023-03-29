using System;

public class LeftHand : Hand {
    private string _side = "Left";

    public LeftHand(int playerNum) : base(playerNum){
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