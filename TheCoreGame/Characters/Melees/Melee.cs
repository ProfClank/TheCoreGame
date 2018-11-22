using System;

namespace TheCoreGame.Characters.Melees
{
    public class Melee : Character
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
    }
}
