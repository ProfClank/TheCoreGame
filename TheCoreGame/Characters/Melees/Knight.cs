using System;
using TheCoreGame.Armors.Mail;
using TheCoreGame.Characters.Enumerations;
using TheCoreGame.Weapons.Blunt;

namespace TheCoreGame.Characters.Melees
{
    public class Knight : Melee
    {
        private const Faction DefaultFaction = Faction.Melee;

        private const int DefaultLevel = 1;
        private const int DefaultAbilityPoints = 15;
        private const int DefaultHealthPoints = 100;

        private const string DefaultName = "Knight";

        private readonly ChainLink _defaultBodyArmor = new ChainLink();
        private readonly Hammer _defaultWeapon = new Hammer();

        public Knight()
            : this(DefaultName, DefaultLevel)
        {

        }

        public Knight(string name, int level)
            : this(name, level, DefaultAbilityPoints)
        {

        }

        public Knight(string name, int level, int abilityPoints)
            : base(name, level, abilityPoints)
        {
            HealthPoints = DefaultHealthPoints;
            Faction = DefaultFaction;
            BodyArmor = _defaultBodyArmor;
            Weapon = _defaultWeapon;
        }

        public void HolyBlow()
        {
            throw new NotImplementedException();
        }

        public void PurifySoul()
        {
            throw new NotImplementedException();
        }

        public void RighteousWings()
        {
            throw new NotImplementedException();
        }

        public override void Attack()
        {
            HolyBlow();
        }

        public override void SpecialAttack()
        {
            PurifySoul();
        }

        public override void Defend()
        {
            RighteousWings();
        }
    }
}