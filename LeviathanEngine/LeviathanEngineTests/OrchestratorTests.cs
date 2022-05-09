using Microsoft.VisualStudio.TestTools.UnitTesting;

using LeviathanEngine;

namespace LeviathanEngineTests
{
    [TestClass]
    public class OrchestratorTests
    {
        [TestMethod]
        public void TurnNumberTicksUpOnNextTurn()
        {
            Orchestrator game = new Orchestrator();
            int initialTurnNumber = game.turnNumber;

            game.advanceTurn();
            Assert.AreEqual(initialTurnNumber + 1, game.turnNumber);
            game.advanceTurn();
            game.advanceTurn();
            Assert.AreEqual(initialTurnNumber + 3, game.turnNumber);
        }

        [TestMethod]
        public void CanAddCommandsToQueue()
        {
            Orchestrator game = new Orchestrator();
            game.addCommand("test");
            Assert.AreEqual(1, game.unprocessedCommands);
        }

        [TestMethod]
        public void CommandsProcessedOnNextTurn()
        {
            Orchestrator game = new Orchestrator();
            game.addCommand("test");
            game.addCommand("test");
            game.advanceTurn();
            game.addCommand("test");
            Assert.AreEqual(2, game.processedCommands);
            Assert.AreEqual(1, game.unprocessedCommands);
            game.advanceTurn();
            Assert.AreEqual(1, game.processedCommands);
            Assert.AreEqual(0, game.unprocessedCommands);
        }

        [TestMethod]
        public void CanGetCommandResult()
        {
            Orchestrator game = new Orchestrator();
            string cmdId = game.addCommandAndGetId("test");

            game.advanceTurn();
            string cmdResult = game.getCommandResult(cmdId);
            Assert.AreNotEqual(0, cmdResult.Length);
        }
    }
}
