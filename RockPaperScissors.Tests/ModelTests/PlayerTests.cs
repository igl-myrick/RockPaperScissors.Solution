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
      Player newGame = new Player();
      Assert.AreEqual(typeof(Player), newGame.GetType());
    }

    [TestMethod]
    public void Player
  }
}