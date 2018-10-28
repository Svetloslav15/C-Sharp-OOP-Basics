using DungeonsAndCodeWizards.Characters;
using DungeonsAndCodeWizards.Entities.Bags;
using DungeonsAndCodeWizards.Entities.Characters.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonsAndCodeWizards.Entities.Characters
{
    public class Cleric : Character, IHealable
    {
        public Cleric(string name, Faction faction)
            : base(name, health: 50, armor: 25, abilityPoints: 40, bag: new Backpack(), faction: faction)
        {
        }

        public override double RestHealMultiplier => 0.5;

        public void Heal(Character character)
        {
            this.CheckIsAlive();

            if (!character.IsAlive)
            {
                throw new InvalidOperationException("Must be alive to perform this action!");
            }

            if (this.Faction != character.Faction)
            {
                throw new InvalidOperationException("Cannot heal enemy character!");
            }

            character.Health = Math.Min(character.BaseHealth, character.Health + this.AbilityPoints);
        }
    }
}
