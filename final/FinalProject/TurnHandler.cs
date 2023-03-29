using System;

public class TurnHandler{
    private int _whoseTurn;
    Spinner spinner = new Spinner();

    public void Game(){
        Player player1 = new Player();
        Player player2 = new Player();

        Console.Clear();
        _whoseTurn = 1;
        while(_whoseTurn != 0){
            player1.DisplayHands();
            player2.DisplayHands();
            if(_whoseTurn == 1){
                Console.WriteLine("Player 1:");
                player1.AttackHand();
            }else {
                Console.WriteLine("Player 2:");
            }
        }
    }

    public void isOutChecker(Player playerUno, Player playerDos){
        if(playerUno.GetOut() == 1){
            Console.Clear();
            Console.WriteLine("Player 1 Wins! Bask in the humliation of your opponent.");
            spinner.GetSpinner();
            _whoseTurn = 0;
        }
    }
}