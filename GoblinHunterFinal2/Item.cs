using System;
using System.Collections.Generic;
using System.Text;

namespace GoblinHunterFinal2
{
     abstract class Item : Tile
    {
        public Item(int _X, int _Y, TileType _TOT, string _Symbol) : base(_X, _Y,_TOT, _Symbol)
        {

        }

        protected Item(int x, int y, string symbol)
        {
            this.x = x;
            this.y = y;
            Symbol = symbol;
        }

        public abstract string ToString();

    }
}
