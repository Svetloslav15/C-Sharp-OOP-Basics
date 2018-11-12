using DungeonsAndCodeWizards.Entities.Characters;
using System;

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
            character.Health = Math.Max(0, character.Health - 20);
            if (character.Health <= 0)
            {
                character.IsAlive = false;
            }
        }
    }
}
