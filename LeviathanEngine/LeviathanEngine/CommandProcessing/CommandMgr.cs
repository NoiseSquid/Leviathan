using LeviathanEngine.CommandProcessing;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeviathanEngine
{
    class CommandMgr
    {
        public CommandMgr()
        {
            processQueue = new List<Command>();
            outputQueue = new List<Command>();
        }

        public int unprocessedCommands { get { return processQueue.Count; } }
        public int processedCommands { get { return outputQueue.Count; } }
        private List<Command> processQueue;
        private List<Command> outputQueue;


        public string addCommandAndGetId(string command)
        {
            string id = Guid.NewGuid().ToString();
            Command wrappedCommand = new Command(id, command);
            processQueue.Add(wrappedCommand);
            return id;
        }

        public void processAll()
        {
            resetResults();

            for (int i = processQueue.Count - 1; i >= 0; i--)
            {
                processCommandAtIndex(i);
            }
        }

        public string getCommandResult(string cmdId)
        {
            foreach (var command in outputQueue)
            {
                if (command.Id == cmdId)
                    return command.Result;
            }
            return "";
        }


        private void resetResults()
        {
            outputQueue.Clear();
        }

        private void processCommandAtIndex(int cmdIndex)
        {
            Command command = processQueue[cmdIndex];
            command.Result = processRawCommand(command.RawCommand);
            outputQueue.Add(command);
            processQueue.RemoveAt(cmdIndex);
        }

        private string processRawCommand(string rawCommand)
        {
            return "processed";
        }
    }
}
