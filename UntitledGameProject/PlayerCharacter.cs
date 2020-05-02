using System;
using System.Collections.Generic;
using System.Text;

namespace UntitledGameProject
{
    class PlayerCharacter
    {
        public string CharacterName { get; set; }
        public string Weapon { get; set; }

        public PlayerCharacter(string characterName, string weapon)
        {
            CharacterName = characterName;
            Weapon = weapon;
        }
        
    }
}
