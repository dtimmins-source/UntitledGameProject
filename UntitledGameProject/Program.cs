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
            var command = new CommandHandler();
            var dragonRock = new DragonRockCommands();

            dragonRock.DragonRockIntitaizer("INITIAL");

            Console.WriteLine("What is your character's name?");
            playerCharacter.CharacterName = Console.ReadLine();
            Console.WriteLine($"\nWelcome {playerCharacter.CharacterName}. Shall we go inside?\n" +
                $"\nThe Dragon'S MAW\n" +
                $"LEFT\n" +
                $"RIGHT\n");

            var direction = "placeholder";
            dragonRock.DragonRockIntitaizer(direction);

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
