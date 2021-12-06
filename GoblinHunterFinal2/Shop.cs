using System;
using System.Collections.Generic;
using System.Text;

namespace GoblinHunterFinal2
{
    class Shop
    {
        Weapon [] wpn = new Weapon[3];
        Random rndwpn = new Random();
        Character player = new Character(0,0,Tile.TileType.Hero,"H",10,2);

        public Shop(Character _Player, Weapon[]_wpn)
        {
            int number;
            
            
        }
        private Weapon RandomWeapon()
        {
            if (rndwpn.Next() == 1)
            {
                return MeleeWeapon.weaponType.Dagger;
            }
            if (rndwpn.Next() ==2)
            {
                return MeleeWeapon.weaponType.LongSword;
            }
            if (rndwpn.Next()==3)
            {
                return RangedWeapons.weaponType.Rifle;
            }
            else
            {
                return RangedWeapons.weaponType.Longbow;
            }
        }
    }
}
