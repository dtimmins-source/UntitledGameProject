using System;

namespace UntitledGameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GameFunctions.StartGame();

            PlayerCharacter playerCharacter = new PlayerCharacter("Unitialized", "Fist", 0);
            var command = new CommandHandler();
            var dragonRock = new DragonRockCommands(playerCharacter);

            dragonRock.DragonRockIntitaizer("INITIAL");

            Console.WriteLine("What is your character's name?");
            playerCharacter.CharacterName = Console.ReadLine();
            Console.WriteLine($"\nWelcome {playerCharacter.CharacterName}. Shall we go inside?\n" +
                $"\nThe Dragon'S MAW\n" +
                $"LEFT\n" +
                $"RIGHT\n");

            var direction = "placeholder";
            dragonRock.DragonRockIntitaizer(direction);
        }
    }
}
