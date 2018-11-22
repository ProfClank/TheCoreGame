using System;
using TheCoreGame.Armors.Leather;
using TheCoreGame.Characters.Enumerations;
using TheCoreGame.Weapons.Sharp;

namespace TheCoreGame.Characters.Spellcasters
{
    public class Necromancer : Spellcaster
    {
        private const Faction DefaultFaction = Faction.Spellcasters;

        private const int DefaultLevel = 1;
        private const int DefaultManaPoints = 20;
        private const int DefaultHealthPoints = 100;

        private const string DefaultName = "Necromancer";

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

        public Necromancer()
            : this(DefaultName, DefaultLevel)
        {

        }

        public Necromancer(string name, int level)
            : this(name, level, DefaultManaPoints)
        {

        }

        public Necromancer(string name, int level, int manaPoints)
        {
            ManaPoints = manaPoints;
            HealthPoints = DefaultHealthPoints;
            Level = level;
            Faction = DefaultFaction;
            Name = name;
            BodyArmor = _defaultBodyArmor;
            Weapon = _defaultWeapon;
        }

        public void ShadowRage()
        {
            throw new NotImplementedException();
        }

        public void VampireTouch()
        {
            throw new NotImplementedException();
        }

        public void BoneShield()
        {
            throw new NotImplementedException();
        }
    }
}