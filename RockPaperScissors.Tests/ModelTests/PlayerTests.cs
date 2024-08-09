using Microsoft.VisualStudio.TestTools.UnitTesting;
using RockPaperScissors.Models;
using System;

namespace RockPaperScissors.Tests
{
  [TestClass]
  public class PlayerTests
  {
    [TestMethod]
    public void PlayerConstructor_CreatesInstanceOfPlayer_Player()
    {
      Player player1 = new Player();
      Assert.AreEqual(typeof(Player), player1.GetType());
    }

    [TestMethod]
    public void SetTurnInput_SetsValueOfTurnInput_String()
    {
      Player player1 = new Player();
      string newValue = "rock";
      player1.TurnInput = newValue;
      Assert.AreEqual(newValue, player1.TurnInput);
    }
  }
}