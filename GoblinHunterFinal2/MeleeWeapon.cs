using System;
using System.Collections.Generic;
using System.Text;

namespace GoblinHunterFinal2
{
    class MeleeWeapon : Weapon
    {
        

        
        public MeleeWeapon(weaponType _WT, int _X, int _Y, string _Symbol) : base(_X, _Y,TileType.Weapon, _Symbol)
        {
            String WeaponType = _Symbol;
            WeaponType = "Dagger";
            WeaponType = "LongSord";
            MeleeWeapon MDWPN = new MeleeWeapon(weaponType.Dagger,0,0,"D");
            MeleeWeapon MLWPN = new MeleeWeapon(weaponType.LongSword, 0, 0, "LS");


            MDWPN.Durability = 10;
            MDWPN.Damage = 3;
            MDWPN.Cost = 3;

            MLWPN.Durability = 6;
            MLWPN.Damage = 4;
            MLWPN.Cost = 5;


        }

        public enum weaponType
        {
            Dagger,
            LongSword,
            Rifle,
            Longbow
        }

        private weaponType wt;

        public weaponType WT
        {
            get { return wt; }
            set { wt = value; }
        }

        public new int Range = 1;
        
        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
