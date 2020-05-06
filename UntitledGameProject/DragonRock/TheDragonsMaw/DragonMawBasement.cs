using System;
using System.Collections.Generic;
using System.Text;

namespace UntitledGameProject.TheDragonsMaw
{
    public class DragonMawBasement
    {
        public PlayerCharacter PlayerCharacter { get; set; }

        public DragonMawBasement(PlayerCharacter playerCharacter)
        {
            PlayerCharacter = playerCharacter;
        }

        public bool KillRatQuest()
        {
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
                    PlayerCharacter.Weapon = "Rusty Knife";
                    Console.ReadLine();
                    goto case "HUNTING";

                case "HUNTING":
                    Console.WriteLine($"\nYou begin hunting about for one of the rats with only your {PlayerCharacter.Weapon} for a weapon.\n" +
                        "Soon enough you find a large rat, the size of a small dog, hunching down behind a jar of something\n" +
                        "that looks suspiciously like a giant jar of pickled hands.");
                    Console.WriteLine($"\n<Lunge at the rat with your {PlayerCharacter.Weapon}>");
                    Console.ReadLine();
                    switch (PlayerCharacter.Weapon)
                    {
                        case "Fist":
                            Console.WriteLine("\nThe rat is quick and mangages to dodge your blow as you stumble forward and land flat on\n" +
                                "your face. The last thing you see are the dozens of beady eyes appearing in the dark before the rats swarm\n" +
                                "over your unprotected face.");
                            Console.WriteLine("\n<continue>");
                            GameFunctions.EndGame();
                            break;

                        default:
                            Console.WriteLine($"\nYour blow is good and your {PlayerCharacter.Weapon} mangles the rat. You pick up the fresh corpse by the\n" +
                                "tail head back upstairs to see the sandling.");

                            Console.WriteLine("\n<Head upstairs>");
                            Console.ReadLine();
                            return true;
                    }
                    break;
                default:
                    Console.WriteLine("\nYou lollygag around the cellar for a bit before the sound of rustiling stops. and everything grows\n" +
                        "eerily quiet. Suddenly a mass of rats bursts forth from behind a pair of old crates and swarms over your\n" +
                        "feet and legs. Startled you trip and fall. The last thing you see are the dozens of beady eyes appearing in the\n" +
                        "dark before the rats swarm over your unprotected face.");
                    Console.WriteLine("\n<continue>");
                    GameFunctions.EndGame();
                    break;
            }
            return false;
        }
    }
}
