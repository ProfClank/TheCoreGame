using System;
using TheCoreGame.Armors.Mail;
using TheCoreGame.Weapons.Sharp;

namespace TheCoreGame.Characters.Melees
{
    public class Warrior
    {
        private int _abilityPoints;
        private int _healthPoints;
        private int _level;

        private string _faction;
        private string _name;

        private ChainLink _bodyArmor;
        private Axe _weapon;

        public int AbilityPoints
        {
            get
            {
                return _abilityPoints;
            }
            set
            {
                if (value >= 0 && value <= 15)
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
                if (value >= 1 && value <= 110)
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

        public string Faction
        {
            get
            {
                return _faction;
            }
            set
            {
                if (value == "Spellcasters" || value == "Melee")
                {
                    _faction = value;
                }
                else
                {
                    Console.WriteLine("Faction should be Spellcasters or Melee");
                    _faction = "Melee";
                }
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
                if (_name.Length >= 2 && _name.Length <= 10)
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
        {
            _abilityPoints = 15;
            _healthPoints = 100;
            _level = 1;
            _faction = "Melee";
            _name = "Bobbert";
            _bodyArmor = new ChainLink();
            _weapon = new Axe();
        }

        public Warrior(string name, int level)
        {
            _abilityPoints = 15;
            _healthPoints = 100;
            _level = level;
            _faction = "Melee";
            _name = name;
            _bodyArmor = new ChainLink();
            _weapon = new Axe();
        }

        public Warrior(string name, int level, int abilityPoints)
        {
            _abilityPoints = abilityPoints;
            _healthPoints = 100;
            _level = level;
            _faction = "Melee";
            _name = name;
            _bodyArmor = new ChainLink();
            _weapon = new Axe();
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