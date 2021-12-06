using System;
using System.Collections.Generic;
using System.Text;

namespace GoblinHunterFinal2
{
    class RangedWeapons : Weapon
    {
        public RangedWeapons(weaponType _WT,int _X, int _Y, string _Symbol) : base(_X, _Y, _Symbol)
        {
            String WeaponType = _Symbol;
            WeaponType = "Rifle";
            WeaponType = "Longbow";
            RangedWeapons RRWPN = new RangedWeapons(weaponType.Rifle, 0, 0, "R");
            RangedWeapons RBWPN = new RangedWeapons(weaponType.Longbow, 0, 0, "LB");


            RRWPN.Durability = 3;
            RRWPN.Range = 3;
            RRWPN.Damage = 5;
            RRWPN.Cost = 7;

            RBWPN.Durability = 4;
            RBWPN.Range = 2;
            RBWPN.Damage = 4;
            RBWPN.Cost = 6;
        }

        public enum weaponType
        {
            Rifle,
            Longbow
        }

        private weaponType wt;

        public weaponType WT
        {
            get { return wt; }
            set { wt = value; }
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
