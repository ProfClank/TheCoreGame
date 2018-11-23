using System;
using TheCoreGame.Armors.Leather;
using TheCoreGame.Characters.Enumerations;
using TheCoreGame.Weapons.Sharp;

namespace TheCoreGame.Characters.Spellcasters
{
    public class Druid : Spellcaster
    {
        private const Faction DefaultFaction = Faction.Spellcasters;
         
        private const int DefaultLevel = 1;
        private const int DefaultManaPoints = 20;
        private const int DefaultHealthPoints = 100;

        private const string DefaultName = "Druid";

        private readonly LeatherVest _defaultBodyArmor = new LeatherVest();
        private readonly Sword _defaultWeapon = new Sword();

        public Druid()
            : this(DefaultName, DefaultLevel)
        {

        }

        public Druid(string name, int level)
            : this(name, level, DefaultManaPoints)
        {

        }

        public Druid(string name, int level, int manaPoints)
            : base(name, level, manaPoints)
        {
            HealthPoints = DefaultHealthPoints;
            Faction = DefaultFaction;
            BodyArmor = _defaultBodyArmor;
            Weapon = _defaultWeapon;
        }

        public void Moonfire()
        {
            throw new NotImplementedException();
        }

        public void Starburst()
        {
            throw new NotImplementedException();
        }

        public void OneWithTheNature()
        {
            throw new NotImplementedException();
        }

        public override void Attack()
        {
            Moonfire();
        }

        public override void SpecialAttack()
        {
            Starburst();
        }

        public override void Defend()
        {
            OneWithTheNature();
        }
    }
}