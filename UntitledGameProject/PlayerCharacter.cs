using System;
using System.Collections.Generic;
using System.Text;

namespace UntitledGameProject
{
    public class PlayerCharacter
    {
        public string CharacterName { get; set; }
        public string Weapon { get; set; }
        public int Money { get; set; }

        public PlayerCharacter(string characterName, string weapon, int money)
        {
            CharacterName = characterName;
            Weapon = weapon;
            Money = money;

        }
        
    }
}
