using System;
using TheCoreGame.Armors.Leather;
using TheCoreGame.Characters.Enumerations;
using TheCoreGame.Weapons.Sharp;

namespace TheCoreGame.Characters.Melees
{
    public class Assassin : Melee
    {
        private const Faction DefaultFaction = Faction.Melee;

        private const int DefaultLevel = 1;
        private const int DefaultAbilityPoints = 15;
        private const int DefaultHealthPoints = 100;

        private const string DefaultName = "Assassin";

        private readonly LeatherVest _defaultBodyArmor = new LeatherVest();
        private readonly Sword _defaultWeapon = new Sword();

        private LeatherVest _bodyArmor;
        private Sword _weapon;

        public LeatherVest BodyArmor
        {
            get
            {
                return _bodyArmor;
            }
            set
            {
                _bodyArmor = value;
            }
        }
        public Sword Weapon
        {
            get
            {
                return _weapon;
            }
            set
            {
                _weapon = value;
            }
        }

        public Assassin()
            : this(DefaultName, DefaultLevel)
        {

        }

        public Assassin(string name, int level)
            : this(name, level, DefaultAbilityPoints)
        {

        }

        public Assassin(string name, int level, int abilityPoints)
        {
            AbilityPoints = abilityPoints;
            HealthPoints = DefaultHealthPoints;
            Level = level;
            Faction = DefaultFaction;
            Name = name;
            BodyArmor = _defaultBodyArmor;
            Weapon = _defaultWeapon;
        }

        public void Raze()
        {
            throw new NotImplementedException();
        }

        public void Bleed()
        {
            throw new NotImplementedException();
        }

        public void Survival()
        {
            throw new NotImplementedException();
        }
    }
}