using System;
using TheCoreGame.Characters.Enumerations;

namespace TheCoreGame.Characters
{
    public class Character
    {
        //Fields

        private int _healthPoints;
        private int _level;

        private Faction _faction;
        private string _name;


        //Properties
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
    }
}
