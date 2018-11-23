using System;

namespace TheCoreGame.Characters.Spellcasters
{
    public abstract class Spellcaster : Character
    {
        private int _manaPoints;

        public int ManaPoints
        {
            get
            {
                return _manaPoints;
            }
            set
            {
                if (value >= 0 && value <= 15)
                {
                    _manaPoints = value;
                }
                else
                {
                    Console.WriteLine("Invalid Mana Points.\nDefault set to 0.");
                    _manaPoints = 1;
                }
            }
        }

        protected Spellcaster(string name, int level, int manaPoints)
            : base(name, level)
        {
            ManaPoints = manaPoints;
            Level = level;
            Name = name;
        }
    }
}
