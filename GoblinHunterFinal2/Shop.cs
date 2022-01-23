using System;
using System.Collections.Generic;
using System.Text;

namespace GoblinHunterFinal2
{
    class Shop
    {
        Weapon [] wpn = new Weapon[3];
        Random rndwpn = new Random();
        Character player;

        public Shop(Character _Player, Weapon[]_wpn)
        {
            int number;
            player = _Player;
            for (int i = 0; i  <wpn.Length; i ++)
            {
                wpn[i] = RandomWeapon();
            }
        }
        private Weapon RandomWeapon()
        {
            if (rndwpn.Next() == 1)
            {
                return new MeleeWeapon(MeleeWeapon.weaponType.Dagger, 0, 0, "D");
            }
            if (rndwpn.Next() ==2)
            {
                return new MeleeWeapon(MeleeWeapon.weaponType.LongSword, 0, 0, "S");
            }
            if (rndwpn.Next()==3)
            {
                return new RangedWeapons(RangedWeapons.weaponType.Rifle, 0, 0, "R");
            }
            else
            {
                return new RangedWeapons(RangedWeapons.weaponType.Longbow, 0, 0, "L");
            }
        }
    }
}
