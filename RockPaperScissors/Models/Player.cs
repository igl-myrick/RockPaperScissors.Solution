using System;

namespace RockPaperScissors.Models
{
  public class Player
  {
    public string TurnInput { get; set; }

    public bool CheckInput()
    {
      if (TurnInput == "rock" || TurnInput == "paper" || TurnInput == "scissors")
      {
        return true;
      }
      else
      {
        return false;
      }
    }

    public bool PlayerHasWon(string opponentResult)
    {
      if ((TurnInput == "rock" && opponentResult == "scissors") || (TurnInput == "scissors" && opponentResult == "paper") || (TurnInput == "paper" && opponentResult == "rock"))
      {
        return true;
      }
      else
      {
        return false;
      }
    }

    public string GetOpponentResult()
    {
      Random rand = new Random();
      switch (rand.Next(3))
      {
        case 0:
          return "rock";
        case 1:
          return "paper";
        case 2:
          return "scissors";
        default:
          return "rock";
      }
    }
  }
}