using System;
using TheCoreGame.Armors.Leather;
using TheCoreGame.Characters.Enumerations;
using TheCoreGame.Weapons.Sharp;

namespace TheCoreGame.Characters.Melees
{
    public class Assassin : Melee
    {
        private const Faction DefaultFaction = Faction.Melee;

        private const int DefaultLevel = 1;
        private const int DefaultAbilityPoints = 15;
        private const int DefaultHealthPoints = 100;

        private const string DefaultName = "Assassin";

        private readonly LeatherVest _defaultBodyArmor = new LeatherVest();
        private readonly Sword _defaultWeapon = new Sword();

        public Assassin()
            : this(DefaultName, DefaultLevel)
        {

        }

        public Assassin(string name, int level)
            : this(name, level, DefaultAbilityPoints)
        {

        }

        public Assassin(string name, int level, int abilityPoints)
            : base(name, level, abilityPoints)
        {
            HealthPoints = DefaultHealthPoints;
            Faction = DefaultFaction;
            BodyArmor = _defaultBodyArmor;
            Weapon = _defaultWeapon;
        }

        public void Raze()
        {
            throw new NotImplementedException();
        }

        public void Bleed()
        {
            throw new NotImplementedException();
        }

        public void Survival()
        {
            throw new NotImplementedException();
        }

        public override void Attack()
        {
            Raze();
        }

        public override void SpecialAttack()
        {
            Bleed();
        }

        public override void Defend()
        {
            Survival();
        }
    }
}