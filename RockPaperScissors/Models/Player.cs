using System;

namespace RockPaperScissors.Models
{
  public class Player
  {
    public string TurnInput { get; set; }

    public bool CheckInput()
    {
      if (TurnInput.ToLower() == "rock")
      {
        return true;
      }
    }
  }
}