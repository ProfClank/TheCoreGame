using TheCoreGame.Characters.Enumerations;

namespace TheCoreGame
{
    public static class Consts
    {
        public static class Warrior
        {
            public const Faction DefaultFaction = Faction.Melee;
            public const int DefaultLevel = 1;
            public const int DefaultAbilityPoints = 15;
            public const int DefaultHealthPoints = 100;
            public const string DefaultName = "Warrior";
        }

        public static class Mage
        {
            public const Faction DefaultFaction = Faction.Spellcasters;
            public const int DefaultLevel = 1;
            public const int DefaultManaPoints = 20;
            public const int DefaultHealthPoints = 100;
            public const string DefaultName = "Mage";
        }
    }
}
