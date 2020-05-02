using System;
using System.Collections.Generic;
using System.Text;

namespace UntitledGameProject
{
    class DragonsMawDialogue
    {
        public void YrshConversation(string MawAction)
        {
            var initial = MawAction;
            if (initial == "MAW")
            {
                Console.WriteLine("\nYou look around and see a few guests sitting at scattered tables in a nearly empty common area.\n" +
                    "No one looks over as you enter. An ancient looking sandling standing atop the bar glances up as you head over and\n" +
                    "pauses in the action on polishing a battered mug. Her ears perk and her eyes glisten as you approach.\n\n" +
                    "\"Welcome stranger, what can I get you, a DRINK or a ROOM?\"");
            }
            var response = Console.ReadLine().ToUpperInvariant();
            Yrsh(response);
        }

        public void Yrsh(string Command)
        {
            var commandHandler = new CommandHandler();
            var command = Command;
            switch (command)
            {
                case "DRINK":
                    Console.WriteLine("\nThe sandling pours you an amber coloured beverage and hands it to you.\n" +
                        "She holds out a dried yellow skinned hand: \"That will be a sesti.\"");
                    Console.WriteLine("\n...do I have any money...?");
                    Console.ReadLine();
                    goto case "BROKE";

                case "ROOM":
                    Console.WriteLine("\nYou're in luck, I have one left. That will be 6 sestis.");
                    Console.WriteLine("\n...do I have any money...?");

                    Console.ReadKey();

                    goto case "BROKE";

                case "BROKE":
                    Console.WriteLine("\nYou fish around in your pockets for a moment before you remember\n" +
                        "that you tipped your last sesti to the bora driver. You look sheepishly at the\n" +
                        "Sandling.");
                    Console.WriteLine("\n\"I'm broke...\"");
                    Console.ReadLine();
                    Console.WriteLine("\n\"I should have known...\" she mutters, but then looks you up and down.\n" +
                         "\"Hrm...you look like you can take care of yourself. I might have a job for you.\n");
                    Console.WriteLine("<continue>");
                    Console.ReadLine();
                    Console.WriteLine("\n\"Oh yea?\"");
                    Console.ReadLine();
                    Console.WriteLine("\nRats have taken up residence in the cellar, and rats are bad for business. If you kill \n" +
                         "the little bastards and I will give you a room and a drink.\"");
                    Console.ReadLine();
                    Console.WriteLine("\n\"Sounds good. Not that I have a choice.\"");
                    Console.ReadLine();
                    return ;
                default:
                    commandHandler.HandleCommand(command);
                    var commandTwo = Console.ReadLine().ToUpperInvariant();
                    Yrsh(commandTwo);
                    break;

            }           
        }
    }
}
