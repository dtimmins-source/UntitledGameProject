using System;

namespace UntitledGameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("******************************************************************************************");
            Console.WriteLine("******************************************************************************************");
            Console.WriteLine("*********                 THE LAND OF OLIM I: THE CURSE OF OORT                 **********");
            Console.WriteLine("******************************************************************************************");
            Console.WriteLine("******************************************************************************************");

            PlayerCharacter playerCharacter = new PlayerCharacter("Unitialized", "Fist");

            Console.WriteLine("You have arrived in the bustling ciy of Dragon Rock only this morning. In looking for a \n" +
                "place to stay you were directed to an establishment known as The Dragons Maw. You stand \n" +
                "outide the door in the busy dusty street, but before you enter you need to get your story\n" +
                "straight...\n");

            Console.WriteLine("What is your character's name?");
            playerCharacter.CharacterName = Console.ReadLine();
            Console.WriteLine($"\nWelcome {playerCharacter.CharacterName}. Shall we go inside?\n" +
                $"\nThe Dragon'S MAW\n" +
                $"LEFT\n" +
                $"RIGHT\n");

            var direction = Console.ReadLine().ToUpper();

            switch (direction)
            {
                case "MAW":
                    Console.WriteLine("\nYou walk through the battered batwing doors and into the Dragon's Maw.\n" +
                        "A ancient sandling looks at you from atop the bar, her pointy ears perking up at your arrival.\n" +
                        "\"DRINK or a ROOM?\", she squawks as she finishes polishing a cup." );
                    var mawAction = Console.ReadLine().ToUpper();
                    switch (mawAction)
                    {
                        case "DRINK":
                            Console.WriteLine("\nThe sandling pours you an amber coloured beverage and hands it to you.\n" +
                                "She holds out a dried yellow skinned hand: \"That will be a sesti.\"");
                            Console.WriteLine("\n...do I have any money...?");
                            Console.ReadLine();
                            goto case "Broke";

                        case "ROOM":
                            Console.WriteLine("\nYou're in luck, I have one left. That will be 6 sestis.");
                            Console.WriteLine("\n...do I have any money...?");
                            Console.ReadLine();
                            goto case "Broke";

                        case "Broke":
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
                            break;
                        default:
                            Console.WriteLine("\nThe sandlish scrunches her wrinkled face at you and mutters. \n" +
                                "\"Adventurers and their foriegn tongues... Do you want a DRINK or a ROOM?\"");
                            var secondAsk = Console.ReadLine().ToUpper();
                            if (secondAsk == "DRINK")
                            {
                                goto case "DRINK";
                            }
                            else if (secondAsk == "ROOM")
                            {
                                goto case "ROOM";
                            }
                            else
                            {
                                goto default;
                            }
                    }       
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
                    Console.WriteLine("\nYou spend a few more moments enjoying the scenery before heading into the Dragon's Maw.");
                    goto case "MAW";
            }

            Console.WriteLine("\nYou head over to the trap door and into the dark cellar. Enough light makes its way through the\n" +
                "floorboards above that you can just see what you are doing. You hear the sounds of something scurrying around\n" +
                "in the darkened corners as you look about. Do you look for a WEAPON or start HUNTING the rats?");
            var basementAction = Console.ReadLine().ToUpper();

            switch (basementAction)
            {
                case "WEAPON":
                    Console.WriteLine("\nYou hunt aroung the room looking for something to use as a weapon and come accross a\n" +
                        "rusty old dagger. Its not great but its better than nothing.");
                    Console.WriteLine("<Pick it up>");
                    playerCharacter.Weapon = "Rusty Knife";
                    Console.ReadLine();
                    goto case "HUNTING";

                case "HUNTING":
                    Console.WriteLine($"\nYou begin hunting about for one of the rats with only your {playerCharacter.Weapon} for a weapon.\n" +
                        "Soon enough you find a large rat, the size of a small dog, hunching down behind a jar of something\n" +
                        "that looks suspiciously like a giant jar of pickled hands.");
                    Console.WriteLine($"\n<Lunge at the rat with your {playerCharacter.Weapon}>");
                    Console.ReadLine();
                    switch (playerCharacter.Weapon)
                    {
                        case "Fist":
                            Console.WriteLine("\nThe rat is quick and mangages to dodge your blow as you stumble forward and land flat on\n" +
                                "your face. The last thing you see are the dozens of beady eyes appearing in the dark before the rats swarm\n" +
                                "over your unprotected face.");
                            Console.WriteLine("\n<continue>");
                            Console.ReadLine();
                            Console.WriteLine("\n\n*********                                GAME OVER!!!                          **********");
                            Console.ReadLine();
                            Environment.Exit(0);
                            break;

                        default:
                            Console.WriteLine($"\nYour blow is good and your {playerCharacter.Weapon} mangles the rat. You pick up the fresh corpse by the\n" +
                                "tail head back upstairs to see the sandling.");

                            Console.WriteLine("\n<Head upstairs>");
                            Console.ReadLine();
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("\nYou lollygag around the cellar for a bit before the sound of rustiling stops. and everything grows\n" +
                        "eerily quiet. Suddenly a mass of rats bursts forth from behind a pair of old crates and swarms over your\n" +
                        "feet and legs. Startled you trip and fall. The last thing you see are the dozens of beady eyes appearing in the\n" +
                        "dark before the rats swarm over your unprotected face.");
                    Console.WriteLine("\n<continue>");
                    Console.ReadLine();
                    Console.WriteLine("\n\n*********                                GAME OVER!!!                          **********"); Console.ReadLine();
                    Environment.Exit(0);
                    break;
            }

            Console.WriteLine("\nYou saunter over to the Sandling and toss the mangled rat corpse onto the bar.\n" +
                "The sandling smirks at the corpse and kicks it towards an ogron the corner.\n" +
                "\"There you go Split, dinner!\"\n" +
                "As the ogron snatches up the rat and begins to bite into it, the sandling pours you a drink and hands it to you\n" +
                "\"The name's Yrsh. What's yours?\"");
            Console.WriteLine("\n<Reply>");
            Console.ReadLine();
            Console.WriteLine($"\nI'm {playerCharacter.CharacterName}.");
            Console.ReadLine();
            Console.WriteLine($"\n\"Well {playerCharacter.CharacterName}, as promised, a room and a drink.\" Yrsh tosses you a small brass key. Second floor, third\n" +
                "on the left. At she goes back to the work of cleaning glasses you head up the stairs to get some sleep.");

            Console.ReadLine();
        }
    }
}
