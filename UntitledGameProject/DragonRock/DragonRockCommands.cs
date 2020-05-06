using System;
using System.Collections.Generic;
using System.Text;

namespace UntitledGameProject
{
    class DragonRockCommands
    {
        public PlayerCharacter PlayerCharacter { get; }

        public DragonRockCommands(PlayerCharacter playerCharacter)
        {
            PlayerCharacter = playerCharacter;
        }

        public void DragonRockIntitaizer(string command)
        {
            var initial = command;
            if (initial == "INITIAL")
            {
                Console.WriteLine("You have arrived in the bustling ciy of Dragon Rock only this morning. In looking for a \n" +
                "place to stay you were directed to an establishment known as The Dragons Maw. You stand \n" +
                "outide the door in the busy dusty street, but before you enter you need to get your story\n" +
                "straight...\n");
                return;
            }
            var response = Console.ReadLine().ToUpperInvariant();
            DragonsMaw(response);
        }

        public void DragonsMaw(string Command)
        {
            var commandHandler = new CommandHandler(PlayerCharacter);
            var command = Command;
            switch (command)
            {
                case "MAW":
                    var dragonsMawDialogue = new DragonsMawDialogue(PlayerCharacter);
                    Console.WriteLine("\nYou walk through the battered batwing doors and into the Dragon's Maw.");
                    dragonsMawDialogue.YrshConversation("MAW");
                    break;

                case "LEFT":
                    Console.WriteLine("\nYou head up the street to the left. There doesn't seem to be much of interest here.\n" +
                        "You head back to the Dragon's Maw");
                    goto case "MAW";
                case "RIGHT":
                    Console.WriteLine("\nYou head up the street to the right. There doesn't seem to be much of interest here.\n" +
                        "You head back to the Dragon's Maw");
                    goto case "MAW";
                default:
                    commandHandler.HandleCommand(command);
                    DragonRockIntitaizer(command);
                    break;
            }
        }

    }
}
