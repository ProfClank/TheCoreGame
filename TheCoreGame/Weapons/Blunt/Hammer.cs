using System;

namespace TheCoreGame.Weapons.Blunt
{
    public class Hammer
    {
        private int _damage;

        public int Damage
        {
            get
            {
                return _damage;
            }
            set
            {
                if (value >= 1)
                {
                    _damage = value;
                }
                else
                {
                    Console.WriteLine("Damage should be a positive number higher than 0.\nDefault set to 1.");
                    _damage = 1;
                }
            }
        }

        public Hammer()
        {
            _damage = 10;
        }

        public void Stun()
        {
            throw new NotImplementedException();
        }
    }
}