using DungeonsAndCodeWizards.Entities.Characters;
using System;

namespace DungeonsAndCodeWizards.Factories
{
    public class CharacterFactory
    {
        public Character CreateCharacter(string faction, string type, string name)
        {
            if (!Enum.TryParse(typeof(Faction), faction, out object parsed))
            {
                throw new ArgumentException($"Invalid faction \"{faction}\"!");
            }
            Faction factionParsed = (Faction)parsed;
            switch (type)
            {
                case "Warrior":
                    return new Warrior(name, factionParsed);
                case "Cleric":
                    return new Cleric(name, factionParsed);
                default:
                    throw new ArgumentException($"Invalid character type \"{type}\"!");
            }
        }
    }
}
