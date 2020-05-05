using System;
using System.Collections.Generic;
using System.Text;

namespace UntitledGameProject
{
    public static class GameFunctions
    {
        public static void StartGame()
        {
            Console.WriteLine("******************************************************************************************");
            Console.WriteLine("******************************************************************************************");
            Console.WriteLine("*********                 THE LAND OF OLIM I: THE CURSE OF OORT                 **********");
            Console.WriteLine("******************************************************************************************");
            Console.WriteLine("******************************************************************************************");
            return;
        }

        public static void EndGame()
        {
            Console.ReadLine();
            Console.WriteLine("\n*********                                GAME OVER!!!                          **********");
            Console.ReadLine();
            Environment.Exit(0);
        }

        
    }
}
