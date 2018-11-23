using System;
using TheCoreGame.Armors.Leather;
using TheCoreGame.Characters.Enumerations;
using TheCoreGame.Weapons.Sharp;

namespace TheCoreGame.Characters.Spellcasters
{
    public class Necromancer : Spellcaster
    {
        private const Faction DefaultFaction = Faction.Spellcasters;

        private const int DefaultLevel = 1;
        private const int DefaultManaPoints = 20;
        private const int DefaultHealthPoints = 100;

        private const string DefaultName = "Necromancer";

        private readonly LeatherVest _defaultBodyArmor = new LeatherVest();
        private readonly Sword _defaultWeapon = new Sword();

        public Necromancer()
            : this(DefaultName, DefaultLevel)
        {

        }

        public Necromancer(string name, int level)
            : this(name, level, DefaultManaPoints)
        {

        }

        public Necromancer(string name, int level, int manaPoints)
            : base(name, level, manaPoints)
        {
            HealthPoints = DefaultHealthPoints;
            Faction = DefaultFaction;
            BodyArmor = _defaultBodyArmor;
            Weapon = _defaultWeapon;
        }

        public void ShadowRage()
        {
            throw new NotImplementedException();
        }

        public void VampireTouch()
        {
            throw new NotImplementedException();
        }

        public void BoneShield()
        {
            throw new NotImplementedException();
        }

        public override void Attack()
        {
            ShadowRage();
        }

        public override void SpecialAttack()
        {
            VampireTouch();
        }

        public override void Defend()
        {
            BoneShield();
        }
    }
}