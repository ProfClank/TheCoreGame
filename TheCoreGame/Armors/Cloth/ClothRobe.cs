using System;

namespace TheCoreGame.Armors.Cloth
{
    public class ClothRobe
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

        public ClothRobe()
        {
            _armorPoints = 10;
        }
    }
}