using System;
using System.Collections.Generic;
using System.Text;

namespace GoblinHunterFinal2
{
    abstract class Enemy : Character
    {
        //declaring the variables for the enemy class
        public Random rnd = new Random();
        public String EnemyClassName = " ";
        String enemySymbol;
        int enemyX;
        int enemyY;
        public List<Tile> GobVision;
        private int edamage;




        //declaring th egetters and setters for the damage and maxhp for the class
        public int eDAMAGE
        {
            get { return edamage; }
            set { edamage = value; }
        }

        private int emaxHp;

        protected Enemy(int _X, int _Y, TileType _TOT, string _Symbol,int _EMAXHP, int _EDAMAGE) : base(_X,_Y, _TOT, _Symbol, _EMAXHP, _EDAMAGE)
        {
            GobVision = new List<Tile>();
            edamage = _EDAMAGE;
            emaxHp = _EMAXHP;
        }

        public int eMAXHP
        {
            get { return emaxHp; }
            set { emaxHp = value; }
        }

        public override string ToString()
        {
            return "[" + x.ToString() + "," + y.ToString() + "]";
        }
    }
}

   

