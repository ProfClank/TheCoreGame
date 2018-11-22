using System;
using TheCoreGame.Armors.Cloth;
using TheCoreGame.Characters.Enumerations;
using TheCoreGame.Weapons.Blunt;

namespace TheCoreGame.Characters.Spellcasters
{
    public class Mage
    {
        private const Faction DefaultFaction = Faction.Spellcasters;

        private const int DefaultLevel = 1;
        private const int DefaultAbilityPoints = 15;
        private const int DefaultHealthPoints = 100;

        private const string DefaultName = "Mage";

        private readonly ClothRobe _defaultBodyArmor = new ClothRobe();
        private readonly Staff _defaultWeapon = new Staff();

        private int _abilityPoints;
        private int _healthPoints;
        private int _level;

        private Faction _faction;
        private string _name;

        private ClothRobe _bodyArmor;
        private Staff _weapon;

        public int AbilityPoints
        {
            get
            {
                return _abilityPoints;
            }
            set
            {
                if (value >= 0 && value <= 20)
                {
                    _abilityPoints = value;
                }
                else
                {
                    Console.WriteLine("Invalid Ability Points.\nDefault set to 0.");
                    _abilityPoints = 1;
                }
            }
        }

        public int HealthPoints
        {
            get
            {
                return _healthPoints;
            }
            set
            {
                if (value >= 1 && value <= 80)
                {
                    _healthPoints = value;
                }
                else
                {
                    Console.WriteLine("Invalid Health Points.\nDefault set to 1.");
                    _healthPoints = 1;
                }
            }
        }

        public int Level
        {
            get
            {
                return _level;
            }
            set
            {
                if (value >= 1 && value <= 100)
                {
                    _level = value;
                }
                else
                {
                    Console.WriteLine("Level should be from 1 to 100.\nDefault set to 1.");
                    _level = 1;
                }
            }
        }

        public Faction Faction
        {
            get
            {
                return _faction;
            }
            set
            {
                _faction = value;
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (value.Length >= 2 && value.Length <= 10)
                {
                    _name = value;
                }
                else
                {
                    Console.WriteLine("Your name should be between 2 and 10 characters");
                    _name = "Bob";
                }
            }
        }

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
            : this(name, level, DefaultAbilityPoints)
        {

        }

        public Mage(string name, int level, int abilityPoints)
        {
            _abilityPoints = abilityPoints;
            _healthPoints = DefaultHealthPoints;
            _level = level;
            _faction = DefaultFaction;
            _name = name;
            _bodyArmor = _defaultBodyArmor;
            _weapon = _defaultWeapon;
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