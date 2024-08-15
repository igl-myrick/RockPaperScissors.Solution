using System;
using RockPaperScissors.Models;

namespace RockPaperScissors
{
  class Program
  {
    static void Main()
    {
      Player player1 = new Player();
      Console.WriteLine("Rock Paper Scissors");
      HandleInput(player1);
    }
    
    static void HandleInput(Player player)
    {
      Console.WriteLine("-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-");
      Console.WriteLine("Enter 'Rock', 'Paper' or 'Scissors':");
      player.TurnInput = Console.ReadLine().ToLower();
      if (player.CheckInput() == false)
      {
        Console.WriteLine("Incorrect input, please re-enter your choice:");
        HandleInput(player);
      }
      else
      {
        string opponentResult = player.GetOpponentResult();
        if (opponentResult == player.TurnInput)
        {
          HandleTie(player, player.TurnInput, opponentResult);
        }
        else if (player.PlayerHasWon(opponentResult) == true)
        {
          Console.WriteLine("You win!");
          HandleGameEnd(player.TurnInput, opponentResult);
        }
        else
        {
          Console.WriteLine("You lose!");
          HandleGameEnd(player.TurnInput, opponentResult);
        }
      }
    }

    static void HandleTie(Player player, string playerChoice, string opponentChoice)
    {
      Console.WriteLine("Tie!");
      Console.WriteLine($"Your input: {playerChoice} | Opponent's choice: {opponentChoice}");
      Console.WriteLine("Next round:");
      HandleInput(player);
    }

    static void HandleGameEnd(string playerChoice, string opponentChoice)
    {
      Console.WriteLine($"Your input: {playerChoice} | Opponent's choice: {opponentChoice}");
      Console.WriteLine("To play again, enter 'new'. To exit, enter any key.");
      string userChoice = Console.ReadLine();
      if (userChoice.ToLower() == "new")
      {
        Main();
      }
    }
  }
}