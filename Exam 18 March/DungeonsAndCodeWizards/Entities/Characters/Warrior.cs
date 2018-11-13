using DungeonsAndCodeWizards.Entities.Bags;
using DungeonsAndCodeWizards.Entities.Characters.Interfaces;
using System;


namespace DungeonsAndCodeWizards.Entities.Characters
{
    public class Warrior : Character, IAttackable
    {
        public Warrior(string name, Faction faction)
            : base(name, 100, 50, 40, new Satchel(), faction)
        {
        }

        public void Attack(Character character)
        {
            this.EnsureAlive();
            if (character == this)
            {
                throw new InvalidOperationException("Cannot attack self!");
            }
            if (character.Faction == this.Faction)
            {
                throw new ArgumentException($"Friendly fire! Both characters are from {this.Faction} faction!");
            }
            character.TakeDamage(this.AbilityPoints);
        }
    }
}
