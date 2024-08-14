using System;

namespace RockPaperScissors.Models
{
  public class Player
  {
    public string TurnInput { get; set; }

    public bool CheckInput()
    {
      if (TurnInput.ToLower() == "rock" || TurnInput.ToLower() == "paper" || TurnInput.ToLower() == "scissors")
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