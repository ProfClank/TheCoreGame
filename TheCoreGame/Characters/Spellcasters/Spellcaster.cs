using System;

namespace TheCoreGame.Characters.Spellcasters
{
    public class Spellcaster : Character
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
    }
}
