using System;

public class TurnHandler{
    private int _whoseTurn;
    Spinner spinner = new Spinner();

    public void Game(){
        Player player1 = new Player(1);
        Player player2 = new Player(2);
        int attackHand;
        int attackHandScore;
        int defendHand;

        Console.Clear();
        _whoseTurn = 1;
        while(_whoseTurn != 0){
            player1.DisplayHands();
            player2.DisplayHands();
            Console.WriteLine();
            Console.WriteLine();
            if(_whoseTurn == 1){
                Console.WriteLine("Player 1:");
                attackHand = player1.AttackHand();
                attackHandScore = GetAttackHandScore(attackHand, player1);
                defendHand = DefendHand();
                player2.AddScoreToHand(defendHand, attackHandScore);
                isOutChecker(player1, player2);
                _whoseTurn = 2;
                Console.Clear();
            }else {
                Console.WriteLine("Player 2:");
                attackHand = player2.AttackHand();
                attackHandScore = GetAttackHandScore(attackHand, player2);
                defendHand = DefendHand();
                player1.AddScoreToHand(defendHand, attackHandScore);
                isOutChecker(player1, player2);
                _whoseTurn = 1;
                Console.Clear();
            }
        }
    }

    public void isOutChecker(Player playerUno, Player playerDos){
        if(playerDos.GetOut() == 1){
            Console.Clear();
            Console.WriteLine("Player 1 Wins! Bask in the humliation of your opponent.");
            spinner.GetSpinner();
            _whoseTurn = 0;
        }else if (playerUno.GetOut() == 1){
            Console.Clear();
            Console.WriteLine("Player 2 Wins! Lord over your opponent with your well deserved epic bragging rights!");
            spinner.GetSpinner();
            _whoseTurn = 0;
        }else {

        }
    }

    public int GetAttackHandScore(int oneOf, Player player){
        return player.GetHandScore(oneOf);
    }

    public int DefendHand(){
        Console.WriteLine("Which hand are you attacking?");
        Console.WriteLine("1 for opponents Left Hand");
        Console.WriteLine("2 for opponents Right Hand");
        string choice = Console.ReadLine();
        int defender = Int32.Parse(choice);
        return defender;
    }
}