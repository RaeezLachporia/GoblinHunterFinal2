using System;
using System.Collections.Generic;
using System.Text;

namespace GoblinHunterFinal2
{
    abstract class Weapon : Item
    {
        private int damage;

        public int Damage
        {
            get { return damage; }
            set { damage = value; }
        }

        private int range;

        public int Range
        {
            get { return range; }
            set { range = value; }
        }

        private int durability;

        public int Durability
        {
            get { return durability; }
            set { durability = value; }
        }

        private int cost;

        public int Cost
        {
            get { return cost; }
            set { cost = value; }
        }

        private int weapontype;

        public int WeaponType
        {
            get { return weapontype; }
            set { weapontype = value; }
        }


        protected Weapon(int _X, int _Y, string _Symbol) : base(_X, _Y, _Symbol)
        {

        }
    }


}
