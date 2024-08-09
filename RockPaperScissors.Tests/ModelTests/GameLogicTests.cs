using Microsoft.VisualStudio.TestTools.UnitTesting;
using RockPaperScissors.Models;
using System;

namespace RockPaperScissors.Tests
{
  [TestClass]
  public class GameLogicTests
  {
    [TestMethod]
    public void GameLogicConstructor_CreatesInstanceOfGameLogic_GameLogic()
    {
      GameLogic newGame = new GameLogic();
      Assert.AreEqual(typeof(GameLogic), newGame.GetType());
    }
  }
}