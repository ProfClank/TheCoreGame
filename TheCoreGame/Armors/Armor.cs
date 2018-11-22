using System;

namespace TheCoreGame.Armors
{
    public class Armor
    {
        private int _armorPoints;

        public int ArmorPoints
        {
            get
            {
                return _armorPoints;
            }
            set
            {
                if (value >= 1)
                {
                    _armorPoints = value;
                }
                else
                {
                    Console.WriteLine("ArmorPoints should be a positive number higher than 0.\nDefault set to 1.");
                    _armorPoints = 1;
                }
            }
        }
    }
}
