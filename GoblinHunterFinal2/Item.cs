using System;
using System.Collections.Generic;
using System.Text;

namespace GoblinHunterFinal2
{
     abstract class Item : Tile
    {
        public Item(int _X, int _Y, TileType _TOT, string _Symbol) : base(_X, _Y, _TOT, _Symbol)
        {

        }


        public abstract string ToString();

    }
}
