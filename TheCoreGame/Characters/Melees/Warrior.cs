using System;
using TheCoreGame.Armors.Mail;
using TheCoreGame.Weapons.Sharp;

namespace TheCoreGame.Characters.Melees
{
    public class Warrior : Melee
    {
        private readonly ChainLink _defaultBodyArmor = new ChainLink();
        private readonly Axe _defaultWeapon = new Axe();

        public Warrior()
            : this(Consts.Warrior.DefaultName, 1)
        {
        }

        public Warrior(string name, int level)
            : this(name, level, Consts.Warrior.DefaultAbilityPoints)
        {
        }

        public Warrior(string name, int level, int abilityPoints)
            : base(name, level, abilityPoints)
        {
            HealthPoints = Consts.Warrior.DefaultHealthPoints;
            Faction = Consts.Mage.DefaultFaction;
            BodyArmor = _defaultBodyArmor;
            Weapon = _defaultWeapon;
            IsAlive = true;
            Score = 0;
        }

        public int Strike()
        {
            return Weapon.Damage + 10;
        }

        public int Execute()
        {
            throw new NotImplementedException();
        }

        public int SkinHarden()
        {
            return BodyArmor.ArmorPoints + 5;
        }

        public override int Attack()
        {
            return Strike();
        }

        public override int SpecialAttack()
        {
            return Execute();
        }

        public override int Defend()
        {
            return SkinHarden();
        }
    }
}