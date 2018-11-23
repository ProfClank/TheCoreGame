using System;
using TheCoreGame.Armors;
using TheCoreGame.Characters.Enumerations;
using TheCoreGame.Characters.Interfaces;
using TheCoreGame.Weapons;

namespace TheCoreGame.Characters
{
    public abstract class Character : IAttack, IDefend
    {
        //Fields
        private bool _isAlive;

        private int _healthPoints;
        private int _level;
        private int _scores;

        private Faction _faction;
        private string _name;

        private Armor _bodyArmor;
        private Weapon _weapon;

        //Properties
        public bool IsAlive
        {
            get
            {
                return _isAlive;
            }
            protected set
            {
                _isAlive = value;
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
                if (value >= 0 && value <= 100)
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
        public int Score
        {
            get
            {
                return _scores;
            }
            protected set
            {
                _scores = value;
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
                _name = value;
            }
        }

        public Armor BodyArmor
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
        public Weapon Weapon
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

        //Constructors
        protected Character()
        {
        }

        protected Character(string name, int level)
        {
            Name = name;
            Level = level;
        }

        public abstract int Attack();


        public abstract int SpecialAttack();


        public abstract int Defend();

        public void TakeDamage(int damage, string attackerName, string type)
        {
            if (Defend() < damage)
            {
                //Should be a field?
                HealthPoints = HealthPoints - damage;

                if (HealthPoints <= 0)
                {
                    IsAlive = false;
                }
            }
            else
            {
                Console.WriteLine("Haha! Your damage was not enough to harm me!");
            }

            if (!IsAlive)
            {
                Tools.TypeSpecificColofulCW($"{Name} received {damage} damage from {attackerName}, and is now dead!", type);
            }
            else
            {
                Tools.TypeSpecificColofulCW($"{Name} received {damage} damage from {attackerName}, and now has {HealthPoints} healthpoints remaining!", type);
            }
        }

        public void WonBattle()
        {
            _scores++;

            if (_scores % 10 == 0)
            {
                _level++;
            }
        }
    }
}
