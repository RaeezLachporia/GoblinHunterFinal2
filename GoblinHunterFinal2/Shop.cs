using System;
using System.Collections.Generic;
using System.Text;

namespace GoblinHunterFinal2
{


    class Shop
    {
        Weapon[] wpn = new Weapon[3];
        Random rndwpn = new Random();
        Character player = new Character(0, 0, Tile.TileType.Hero, "H", 10, 2);
        int number;
        public Shop(Character _Player, Weapon[] _wpn)
        {

            number = rndwpn.Next(1, 3);


        }
        private Weapon RandomWeapon()
        {
            if (number == 1)
            {
                return (Weapon)MeleeWeapon.weaponType.Dagger;
            }
            if (rndwpn.Next() == 2)
            {
                return (Weapon)MeleeWeapon.weaponType.LongSword;
            }
            if (rndwpn.Next() == 3)
            {
                return (Weapon)RangedWeapons.weaponType.Rifle;
            }
            else
            {
                return (Weapon)RangedWeapons.weaponType.Longbow;
            }
        }
    }
}
