using System;
using System.Collections.Generic;
using System.Text;

namespace GoblinHunterFinal2
{
    class MeleeWeapon : Weapon
    {
        public MeleeWeapon(weaponType _WT, int _X, int _Y, string _Symbol) : base(_X, _Y, _Symbol)
        {
            String WeaponType = _Symbol;
            WeaponType = "Dagger";

        }

        public enum weaponType
        {
            Dagger,
            LongSword
        }

        private weaponType wt;

        public weaponType WT
        {
            get { return wt; }
            set { wt = value; }
        }

        public override int Range()
        {
            int Range = 1;
            return Range;
        }
        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
