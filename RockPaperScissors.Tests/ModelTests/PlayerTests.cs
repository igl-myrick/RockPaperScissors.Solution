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

    [TestMethod]
    public void CheckInput_ChecksIfRock_Boolean()
    {
      Player player1 = new Player();
      player1.TurnInput = "rock";
      Assert.AreEqual(true, player1.CheckInput());
    }

    [TestMethod]
    public void CheckInput_ChecksIfPaper_Boolean()
    {
      Player player1 = new Player();
      player1.TurnInput = "paper";
      Assert.AreEqual(true, player1.CheckInput());
    }

    [TestMethod]
    public void CheckInput_ChecksIfScissors_Boolean()
    {
      Player player1 = new Player();
      player1.TurnInput = "scissors";
      Assert.AreEqual(true, player1.CheckInput());
    }

    [TestMethod]
    public void CheckInput_ChecksIfFalse_Boolean()
    {
      Player player1 = new Player();
      player1.TurnInput = "rockk";
      Assert.AreEqual(false, player1.CheckInput());
    }

    [TestMethod]
    public void PlayerHasWon_ReturnsTrueIfPlayerHasWon_Boolean()
    {
      Player player1 = new Player();
      player1.TurnInput = "rock";
      bool result = player1.PlayerHasWon("scissors");
      Assert.AreEqual(true, result);
    }

    [TestMethod]
    public void PlayerHasWon_ReturnsFalseIfPlayerHasNotWon_Boolean()
    {
      Player player1 = new Player();
      player1.TurnInput = "rock";
      bool result = player1.PlayerHasWon("paper");
      Assert.AreEqual(false, result);
    }
  }
}