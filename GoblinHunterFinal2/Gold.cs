using System;
using System.Collections.Generic;
using System.Text;

namespace GoblinHunterFinal2
{
    class Gold : Item
    {
        public Gold(int _X, int _Y, TileType _TOT, string _Symbol) : base(_X, _Y, _TOT, _Symbol)
        {
            gold = rndGold.Next(1, 6);
        }

        private int gold;

        public int GOLD     // What this does
        {
            get { return gold; }
            set { gold = value; }
        }
        private Random rndGold = new Random();

        public override string ToString()
        {
            return "gold";     // base.ToString();
        }

        /*  public override string ToString()
          {
              throw new NotImplementedException();
          }*/
    }
}
