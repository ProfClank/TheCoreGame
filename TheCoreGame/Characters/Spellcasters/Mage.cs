using System;
using TheCoreGame.Armors.Cloth;
using TheCoreGame.Characters.Enumerations;
using TheCoreGame.Weapons.Blunt;

namespace TheCoreGame.Characters.Spellcasters
{
    public class Mage : Spellcaster
    {
        private const Faction DefaultFaction = Faction.Spellcasters;

        private const int DefaultLevel = 1;
        private const int DefaultManaPoints = 20;
        private const int DefaultHealthPoints = 100;

        private const string DefaultName = "Mage";

        private readonly ClothRobe _defaultBodyArmor = new ClothRobe();
        private readonly Staff _defaultWeapon = new Staff();

        private ClothRobe _bodyArmor;
        private Staff _weapon;

        public ClothRobe BodyArmor
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
        public Staff Weapon
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

        public Mage()
            : this(DefaultName, DefaultLevel)
        {

        }

        public Mage(string name, int level)
            : this(name, level, DefaultManaPoints)
        {

        }

        public Mage(string name, int level, int manaPoints)
        {
            ManaPoints = manaPoints;
            HealthPoints = DefaultHealthPoints;
            Level = level;
            Faction = DefaultFaction;
            Name = name;
            BodyArmor = _defaultBodyArmor;
            Weapon = _defaultWeapon;
        }

        public void ArcaneWrath()
        {
            throw new NotImplementedException();
        }

        public void Firewall()
        {
            throw new NotImplementedException();
        }

        public void Meditation()
        {
            throw new NotImplementedException();
        }
    }
}