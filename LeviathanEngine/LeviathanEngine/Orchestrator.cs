using System;
using System.Collections.Generic;

namespace LeviathanEngine
{
    public class Orchestrator
    {
        public Orchestrator()
        {
            commander = new CommandMgr();
        }

        public int turnNumber { get; private set; }
        public int unprocessedCommands { get { return commander.unprocessedCommands; } }
        public int processedCommands { get { return commander.processedCommands; } }

        private CommandMgr commander;


        public void advanceTurn()
        {
            turnNumber++;
            commander.processAll();
        }

        public void addCommand(string command)
        {
            addCommandAndGetId(command);
        }

        public string addCommandAndGetId(string command)
        {
            return commander.addCommandAndGetId(command);
        }

        public string getCommandResult(string cmdId)
        {
            return commander.getCommandResult(cmdId);
        }
    }
}
