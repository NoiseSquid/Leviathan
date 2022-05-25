using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LeviathanEngine
{
    public class Game_POC
    {
        private HexMap gameMap;
        private Dictionary<Guid, string> unprocessedCommands;
        private Dictionary<Guid, string> commandResultMessages;

        public Game_POC(GameParameters gParams)
        {
            gameMap = new HexMap(gParams.width, gParams.height);
            unprocessedCommands = new Dictionary<Guid, string>();
            commandResultMessages = new Dictionary<Guid, string>();
        }

        public HexMap GetMap(int playerId)
        {
            return gameMap;
        }

        public Guid RegisterCommand(string command)
        {
            Guid guid = new Guid();
            unprocessedCommands.Add(guid, command);
            return guid;
        }

        public string getCommandResult(Guid commandId)
        {
            if (commandResultMessages.ContainsKey(commandId))
                return commandResultMessages[commandId];
            else
                return "";
        }

        public async void NextTurn()
        {
            await Task.Run(() => processAllCommands());
        }

        private void processAllCommands()
        {
            foreach (KeyValuePair<Guid, string> command in unprocessedCommands)
            {
                commandResultMessages.Add(command.Key, "Command parsed (no processing implemented yet)");
            }
        }
    }
}
