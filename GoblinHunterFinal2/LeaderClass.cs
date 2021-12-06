using System;
using System.Collections.Generic;
using System.Text;

namespace GoblinHunterFinal2
{
    class LeaderClass : Enemy
    {

        

        private int leaderlocate;

        public int LEADERLOCATE
        {
            get { return leaderlocate; }
            set { leaderlocate = value; }
        }

        public LeaderClass(int _X, int _Y, TileType _TOT, string _Symbol, int _EMAXHP, int _EDAMAGE) : base(_X, _Y, _TOT, _Symbol, _EMAXHP, _EDAMAGE)
        {
            LeaderClass Leader = new LeaderClass(0,0,TileType.Enemy,"L",20,2);

            Leader.eMAXHP = 20;
            Leader.eDAMAGE = 2;
        }

        public override int ReturnMove()
        {
            throw new NotImplementedException();
        }
    }
}
