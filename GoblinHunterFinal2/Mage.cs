using System;
using System.Collections.Generic;
using System.Text;

namespace GoblinHunterFinal2
{
    internal class Mage : Enemy
    {
        private int mHealth;

        public Mage(int _X, int _Y, TileType _TOT, string _Symbol, int _HP) : base(_X, _Y, _TOT, _Symbol, _HP, 5, 5)// We set a maxHp value not an HP
        {

        }

        public int MHEALTH
        {
            get { return mHealth; }
            set { mHealth = value; }
        }

        private int mDamage;

        public int MDAMAGE
        {
            get { return mDamage; }
            set { mDamage = value; }
        }

        public override int ReturnMove()
        {
            return 0;
        }
    }
}
