using DungeonsAndCodeWizards.Entities.Bags;
using DungeonsAndCodeWizards.Entities.Characters;
using DungeonsAndCodeWizards.Entities.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonsAndCodeWizards.Characters
{
    public abstract class Character
    {
        private string name;
        public double BaseHealth { get; set; }
        public double BaseArmor { get; set; }
        private double health;
        private double armor;

        public double AbilityPoints { get; set; }
        public Bag Bag { get; set; }
        public Faction Faction { get; set; }
        public bool IsAlive { get; set; }
        public virtual double RestHealMultiplier { get; set; }
        public double Armor
        {
            get => this.armor;
            set
            {
                this.armor = Math.Min(value, this.BaseArmor);
            }
        }
        public double Health
        {
            get => this.health;
            set
            {
                this.health = Math.Min(value, this.BaseHealth);
            }
        }
        public string Name
        {
            get => this.name;
            set
            {
                if (value.Trim() == "")
                {
                    throw new ArgumentException("Name cannot be null or whitespace!");
                }
                this.name = value;
            }
        }
        
        public void TakeDamage(double hitPoints)
        {
            if (this.CheckIsAlive())
            {
                this.Armor -= hitPoints;
                hitPoints -= this.Armor;
                if (hitPoints > 0)
                {
                    this.Health -= hitPoints;
                    if (this.Health <= 0)
                    {
                        this.IsAlive = false;
                    }
                }
            }
        }
        public void Rest()
        {
            if (this.CheckIsAlive())
            {
                this.health += this.BaseHealth * this.RestHealMultiplier;
            }
        }
        public void UseItem(Item item)
        {
            if (this.CheckIsAlive())
            {
                this.UseItemOn(item, this);
            }
        }
        public void UseItemOn(Item item, Character character)
        {
            if (this.CheckIsAlive() && character.IsAlive)
            {
                this.UseItemOn(item, character);
            }
        }
        public void GiveCharacterItem(Item item, Character character)
        {
            if (this.CheckIsAlive() && character.IsAlive)
            {
                character.ReceiveItem(item);
            }
        }
        public void ReceiveItem(Item item)
        {
            if (this.IsAlive)
            {
                this.Bag.AddItem(item);
            }
        }
        public bool CheckIsAlive()
        {
            if (!this.IsAlive)
            {
                throw new InvalidOperationException("Must be alive to perform this action!");
            }
            return true;
        }

        protected Character(string name, double health, double armor, double abilityPoints, Bag bag, Faction faction)
        {
            this.Name = name;
            this.BaseHealth = health;
            this.Health = health;
            this.BaseArmor = armor;
            this.Armor = armor;
            this.AbilityPoints = abilityPoints;
            this.Bag = bag;
            this.Faction = faction;
        }
    }
}
