using System;
using System.Collections.Generic;
using System.Text;

namespace GoblinHunterFinal2
{
    internal class Mage : Enemy
    {
        private int mHealth;

        public Mage(int _X, int _Y, TileType _TOT, string _Symbol, int _HP,int _eMaxHp,int _eDamage) : base(_X, _Y, _TOT, _Symbol, 5,5)// We set a maxHp value not an HP
        {
            Mage mage = new Mage(0, 0, TileType.Enemy, "M", 5, 5, 5);

            mage.eMAXHP = 5;
            mage.eDAMAGE = 5;
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
