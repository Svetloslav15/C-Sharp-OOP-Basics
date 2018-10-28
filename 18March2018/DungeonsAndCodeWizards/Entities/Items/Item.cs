using DungeonsAndCodeWizards.Characters;
using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonsAndCodeWizards.Entities.Items
{
    public abstract class Item
    {
        public int Weight { get; }

        public virtual void AffectCharacter(Character character)
        {
            if (!character.IsAlive)
            {
                throw new InvalidOperationException("Must be alive to perform this action!");
            }
        }

        public Item(int weight)
        {
            this.Weight = weight;
        }
    }
}
