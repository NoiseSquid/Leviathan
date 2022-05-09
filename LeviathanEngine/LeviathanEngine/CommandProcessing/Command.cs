using System;
using System.Collections.Generic;
using System.Text;

namespace LeviathanEngine.CommandProcessing
{
    class Command
    {
        public readonly string Id;
        public readonly string RawCommand;
        public string Result;

        public Command(string id, string command)
        {
            Id = id;
            RawCommand = command;
        }
    }
}
