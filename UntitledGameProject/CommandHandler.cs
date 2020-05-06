using System;
using System.Collections.Generic;
using System.Text;

namespace UntitledGameProject
{
    public class CommandHandler
    {
        public PlayerCharacter PlayerCharacter { get; set; }

        public CommandHandler(PlayerCharacter playerCharacter)
        {
            playerCharacter = PlayerCharacter;
        }

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
                case "MONEY":
                    Console.WriteLine("Some stuff with money");
                    break;
                default:
                    Console.WriteLine("\nUnknown Command\n");
                    break;
            }
            return;
        }
    }
}
