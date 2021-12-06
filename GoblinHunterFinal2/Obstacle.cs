using System;
using System.Collections.Generic;
using System.Text;

namespace GoblinHunterFinal2
{
    class Obstacle : Tile
    {
        public Obstacle(int _X, int _Y, TileType _TOT, string _Symbol) : base(_X, _Y, _TOT, _Symbol)
        {
            X = _X;
            Y = _Y;
            TOT = _TOT;
        }

        public int ObstacleX()
        {
            return base.X;
        }

        public int ObstacleY()
        {
            return base.Y;
        }
    }
    
}
