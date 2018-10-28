using DungeonsAndCodeWizards.Characters;
using DungeonsAndCodeWizards.Entities.Bags;
using DungeonsAndCodeWizards.Entities.Characters.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonsAndCodeWizards.Entities.Characters
{
    public class Warrior : Character, IAttackable
    {
        public Warrior(string name, Faction faction)
            : base(name, health: 100, armor: 50, abilityPoints: 40, bag: new Satchel(), faction: faction)
        {
        }

        public void Attack(Character character)
        {
            if (this.CheckIsAlive() && character.CheckIsAlive())
            {
                if (character == this)
                {
                    throw new InvalidOperationException("Cannot attack self!");
                }
                if (character.Faction == this.Faction)
                {
                    throw new InvalidOperationException($"Friendly fire! Both characters are from {this.Faction} faction!");
                }
                character.TakeDamage(this.AbilityPoints);
            }
        }
    }
}
