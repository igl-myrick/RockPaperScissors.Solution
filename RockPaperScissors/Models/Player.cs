using System;

namespace RockPaperScissors.Models
{
  public class Player
  {
    public string TurnInput { get; set; }

    public bool CheckInput()
    {
      if (TurnInput.ToLower() == "rock" || TurnInput.ToLower() == "paper")
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