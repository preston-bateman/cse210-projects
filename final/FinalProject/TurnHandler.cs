using System;

public class TurnHandler{
    //private int _whoseTurn;
    Spinner spinner = new Spinner();

    public void Game(){
        Player player1 = new Player(1);
        Player player2 = new Player(2);
        int attackHand;
        int attackHandScore;
        int defendHand;
        int whoseTurn;

        Console.Clear();
        whoseTurn = 1;
        while(whoseTurn != 0){
            whoseTurn = player1.DisplayHands(whoseTurn);
            whoseTurn = player2.DisplayHands(whoseTurn);
            Console.WriteLine();
            Console.WriteLine();
            if(whoseTurn == 1){
                Console.WriteLine("Player 1:");
                attackHand = player1.AttackHand();
                attackHandScore = GetAttackHandScore(attackHand, player1);
                defendHand = DefendHand();
                player2.AddScoreToHand(defendHand, attackHandScore);
                whoseTurn = 2;
                Console.Clear();
            }else if(whoseTurn == 2) {
                Console.WriteLine("Player 2:");
                attackHand = player2.AttackHand();
                attackHandScore = GetAttackHandScore(attackHand, player2);
                defendHand = DefendHand();
                player1.AddScoreToHand(defendHand, attackHandScore);
                whoseTurn = 1;
                Console.Clear();
            }else {
                break;
            }
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