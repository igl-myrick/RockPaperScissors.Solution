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
    public void GetTurnInput_GetsTurnInput_String()
    {
      Player player1 = new Player();
      string newValue = player1.TurnInput;
      Assert.AreEqual(newValue, player1.TurnInput);
    }

    [TestMethod]
    public void SetTurnInput_SetsValueOfTurnInput_String()
    {
      Player player1 = new Player();
      string newValue = "scissors";
      player1.TurnInput = newValue;
      Assert.AreEqual(newValue, player1.TurnInput);
    }

    public void CheckInput_ChecksIfRock_Boolean()
    {
      Player player1 = new Player();
      player1.TurnInput = "rock";
      Assert.AreEqual(true, player1.CheckInput());
    }

    public void CheckInput_ChecksIfPaper_Boolean()
    {
      Player player1 = new Player();
      player1.TurnInput = "paper";
      Assert.AreEqual(true, player1.CheckInput());
    }

    public void CheckInput_ChecksIfScissors_Boolean()
    {
      Player player1 = new Player();
      player1.TurnInput = "Scissors";
      Assert.AreEqual(true, player1.CheckInput());
    }

    public void CheckInput_ChecksIfFalse_Boolean()
    {
      Player player1 = new Player();
      player1.TurnInput = "rockk";
      Assert.AreEqual(false, player1.CheckInput());
    }
  }
}