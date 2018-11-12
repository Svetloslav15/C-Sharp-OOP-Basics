using DungeonsAndCodeWizards.Entities.Characters;
using DungeonsAndCodeWizards.Entities.Characters.Interfaces;
using DungeonsAndCodeWizards.Entities.Items;
using System;
using System.Collections.Generic;

namespace DungeonsAndCodeWizards
{
    public static class ExceptionHandler
    {
        public static void NullCharacter(Character character, string name)
        {
            if (character == null)
            {
                throw new ArgumentException($"Character {name} not found!");
            }
        }

        public static void EmptyPool(IList<Item> itemPool)
        {
            if (itemPool.Count == 0)
            {
                throw new InvalidOperationException("No items left in pool!");
            }
        }

        public static void AttackableCharacter(Character attackerCharacter)
        {
            if (!(attackerCharacter is IAttackable))
            {
                throw new ArgumentException($"{attackerCharacter.Name} cannot attack!");
            }
        }

        public static void HealableCharacter(Character healerCharacter)
        {
            if (!(healerCharacter is IHealable))
            {
                throw new ArgumentException($"{healerCharacter.Name} cannot attack!");
            }
        }
    }
}
