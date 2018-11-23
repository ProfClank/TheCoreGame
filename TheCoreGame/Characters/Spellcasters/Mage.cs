using System;
using TheCoreGame.Armors.Cloth;
using TheCoreGame.Weapons.Blunt;

namespace TheCoreGame.Characters.Spellcasters
{
    public class Mage : Spellcaster
    {
        private readonly ClothRobe _defaultBodyArmor = new ClothRobe();
        private readonly Staff _defaultWeapon = new Staff();

        public Mage()
            : this(Consts.Mage.DefaultName, Consts.Mage.DefaultLevel)
        {

        }

        public Mage(string name, int level)
            : this(name, level, Consts.Mage.DefaultManaPoints)
        {

        }

        public Mage(string name, int level, int manaPoints)
            : base(name, level, manaPoints)
        {
            HealthPoints = Consts.Mage.DefaultHealthPoints;
            Faction = Consts.Mage.DefaultFaction;
            BodyArmor = _defaultBodyArmor;
            Weapon = _defaultWeapon;
            IsAlive = true;
            Score = 0;
        }

        public int ArcaneWrath()
        {
            return Weapon.Damage + 10;
        }

        public int Firewall()
        {
            throw new NotImplementedException();
        }

        public int Meditation()
        {
            return BodyArmor.ArmorPoints + 5;
        }

        public override int Attack()
        {
            return ArcaneWrath();
        }

        public override int SpecialAttack()
        {
            return Firewall();
        }

        public override int Defend()
        {
            return Meditation();
        }
    }
}