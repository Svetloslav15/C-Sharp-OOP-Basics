using DungeonsAndCodeWizards.Characters;
using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonsAndCodeWizards.Entities.Items
{
    public class HealthPotion : Item
    {
        public const int pointsToIncrease = 20; 
        public HealthPotion() : base(5)
        {
        }
        public override void AffectCharacter(Character character)
        {
            base.AffectCharacter(character);
            character.Health += pointsToIncrease;
        }
    }
}
