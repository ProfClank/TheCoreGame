using System;
using TheCoreGame.Armors.Mail;
using TheCoreGame.Characters.Enumerations;
using TheCoreGame.Weapons.Sharp;

namespace TheCoreGame.Characters.Melees
{
    public class Warrior : Melee
    {
        private const Faction DefaultFaction = Faction.Melee;

        private const int DefaultLevel = 1;
        private const int DefaultAbilityPoints = 15;
        private const int DefaultHealthPoints = 100;

        private const string DefaultName = "Warrior";

        private readonly ChainLink _defaultBodyArmor = new ChainLink();
        private readonly Axe _defaultWeapon = new Axe();

        private ChainLink _bodyArmor;
        private Axe _weapon;

        public ChainLink BodyArmor
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
        public Axe Weapon
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

        public Warrior()
            : this(DefaultName, DefaultLevel)
        {

        }

        public Warrior(string name, int level)
            : this(name, level, DefaultAbilityPoints)
        {

        }

        public Warrior(string name, int level, int abilityPoints)
        {
            AbilityPoints = abilityPoints;
            HealthPoints = DefaultHealthPoints;
            Level = level;
            Faction = DefaultFaction;
            Name = name;
            BodyArmor = _defaultBodyArmor;
            Weapon = _defaultWeapon;
        }

        public void Strike()
        {
            throw new NotImplementedException();
        }

        public void Execute()
        {
            throw new NotImplementedException();
        }

        public void SkinHarden()
        {
            throw new NotImplementedException();
        }
    }
}