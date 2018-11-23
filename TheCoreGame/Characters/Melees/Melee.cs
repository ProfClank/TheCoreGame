using System;

namespace TheCoreGame.Characters.Melees
{
    public abstract class Melee : Character
    {
        private int _abilityPoints;

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

        protected Melee(string name, int level, int abilityPoints)
            : base(name, level)
        {
            AbilityPoints = abilityPoints;
            Level = level;
            Name = name;
        }
    }
}
