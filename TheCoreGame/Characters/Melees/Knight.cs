using System;
using TheCoreGame.Armors.Mail;
using TheCoreGame.Characters.Enumerations;
using TheCoreGame.Weapons.Blunt;

namespace TheCoreGame.Characters.Melees
{
    public class Knight : Melee
    {
        private const Faction DefaultFaction = Faction.Melee;

        private const int DefaultLevel = 1;
        private const int DefaultAbilityPoints = 15;
        private const int DefaultHealthPoints = 100;

        private const string DefaultName = "Knight";

        private readonly ChainLink _defaultBodyArmor = new ChainLink();
        private readonly Hammer _defaultWeapon = new Hammer();

        private ChainLink _bodyArmor;
        private Hammer _weapon;

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
        public Hammer Weapon
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

        public Knight()
            : this(DefaultName, DefaultLevel)
        {

        }

        public Knight(string name, int level)
            : this(name, level, DefaultAbilityPoints)
        {

        }

        public Knight(string name, int level, int abilityPoints)
        {
            AbilityPoints = abilityPoints;
            HealthPoints = DefaultHealthPoints;
            Level = level;
            Faction = DefaultFaction;
            Name = name;
            BodyArmor = _defaultBodyArmor;
            Weapon = _defaultWeapon;
        }

        public void HolyBlow()
        {
            throw new NotImplementedException();
        }

        public void PurifySoul()
        {
            throw new NotImplementedException();
        }

        public void RighteousWings()
        {
            throw new NotImplementedException();
        }
    }
}