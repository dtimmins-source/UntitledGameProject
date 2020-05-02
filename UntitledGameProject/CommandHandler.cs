using System;
using System.Collections.Generic;
using System.Text;

namespace UntitledGameProject
{
    class CommandHandler
    {
        public void HandleCommand(string command)
        {
            switch (command)
            {
                case "HELP":
                    Console.WriteLine("\nThese are help options\n");
                    break;
                case "INV":
                    Console.WriteLine("\nThis is your inventory\n");
                    break;
                default:
                    Console.WriteLine("\nUnknown Command\n");
                    break;
            }
            return;
        }
    }
}
