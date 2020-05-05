using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Text;
using UntitledGameProject.The_Dragon_s_Maw;

namespace UntitledGameProject
{
    class DragonsMawDialogue
    {
        public PlayerCharacter PlayerCharacter { get; set; }

        public DragonsMawDialogue(PlayerCharacter playerCharacter)
        {
            PlayerCharacter = playerCharacter;
        }

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
                    Console.WriteLine("\nHow much MONEY do I have?");
                    
                    var roomResponse = Console.ReadLine().ToUpperInvariant();
                    if (roomResponse == "MONEY")
                    {
                        goto case "MONEY";
                    }
                    else
                    {
                        goto case "BROKE";
                    }
                    

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

                    var dragonsMawBasement = new DragonMawBasement(PlayerCharacter);
                    bool completedKillRatQuest = dragonsMawBasement.KillRatQuest();
                    if (completedKillRatQuest == true)
                    {
                        Console.WriteLine("\nYou saunter over to the Sandling and toss the mangled rat corpse onto the bar.\n" +
                        "The sandling smirks at the corpse and kicks it towards an ogron the corner.\n" +
                        "\"There you go Split, dinner!\"\n" +
                        "As the ogron snatches up the rat and begins to bite into it, the sandling pours you a drink and hands it to you\n" +
                        "\"The name's Yrsh. What's yours?\"");
                        Console.WriteLine("\n<Reply>");
                        Console.ReadLine();
                        Console.WriteLine($"\nI'm {PlayerCharacter.CharacterName}.");
                        Console.ReadLine();
                        Console.WriteLine($"\n\"Well {PlayerCharacter.CharacterName}, as promised, a room and a drink.\" Yrsh tosses you a small brass key. Second floor, third\n" +
                            "on the left. At she goes back to the work of cleaning glasses you head up the stairs to get some sleep.");
                        return;
                    }
                    break;
                case "MONEY":
                    Console.WriteLine($"\nYou have {PlayerCharacter.Money} sestis.");
                    Console.WriteLine("\nTry to PAY or admit you are BROKE?");
                    var brokeOrBluff = Console.ReadLine().ToUpperInvariant();
                    if (brokeOrBluff == "PAY")
                    {
                        goto case "PAY";
                    }
                    else
                    {
                        goto case "BROKE";
                    }
                case "PAY":
                    var cashOnHand = PlayerCharacter.Money;
                    if (PlayerCharacter.Money >= 6)
                    {
                        PlayerCharacter.Money -= 6;
                        Console.WriteLine("\nThe sandling takes your money and tosses you a small brass key. Second floor, third\n" +
                            "on the left. At she goes back to the work of cleaning glasses you head up the stairs to get some sleep.");
                        GameFunctions.EndGame();
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"The sandling scowls at you and says \"It looks like you don't have enough money.\"");
                        goto case "BROKE";
                    }
                default:
                    commandHandler.HandleCommand(command);
                    var commandTwo = Console.ReadLine().ToUpperInvariant();
                    Yrsh(commandTwo);
                    break;

            }           
        }
    }
}
