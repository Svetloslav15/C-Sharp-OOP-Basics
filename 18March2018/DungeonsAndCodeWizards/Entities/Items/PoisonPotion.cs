using DungeonsAndCodeWizards.Characters;
using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonsAndCodeWizards.Entities.Items
{
    public class PoisonPotion : Item
    {
        public const int pointsToDecrease = 20;
        public PoisonPotion() : base(5)
        {
        }
        public override void AffectCharacter(Character character)
        {
            base.AffectCharacter(character);
            character.Health -= pointsToDecrease;
            if (character.Health < 0)
            {
                character.IsAlive = false;
            }
        }
    }
}
