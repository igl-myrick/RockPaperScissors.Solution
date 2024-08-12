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
  }
}