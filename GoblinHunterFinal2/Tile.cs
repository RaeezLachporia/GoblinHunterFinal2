using System;
using System.Collections.Generic;
using System.Text;

namespace GoblinHunterFinal2
{
    public abstract class Tile
    {
        //delcaring the enum for the movement parameters for the players and the enemies
        public enum TileType
        {
            Hero,
            Enemy,
            Gold,
            Weapon,
            Empty,
            Barrier
        }
        //declaring the getters and setter for the x, y and titletype for the method 
        protected int x;

        public int X
        {
            get { return x; }
            set { x = value; }
        }

        protected int y;

        public int Y
        {
            get { return y; }
            set { y = value; }
        }
        private TileType tot;

        public TileType TOT
        {
            get { return tot; }
            set { tot = value; }
        }

        private String symbol;

        public String Symbol
        {
            get { return symbol; }
            set { symbol = value; }
        }

        //declaring a constructor with the neccessary perameters
        public Tile(int _X, int _Y, TileType _TOT, String _Symbol)
        {
            X = _X;
            Y = _Y;
            TOT = _TOT;
            Symbol = _Symbol;

        }
    }
}
