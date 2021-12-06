using System;
using System.Collections.Generic;
using System.Text;

namespace GoblinHunterFinal2
{
    abstract class Character : Tile
    {
        //declaring  variables for the class
        protected Tile[] charVision;
        protected int hp;
        protected String Symbol;
        protected int maxHp;
        protected Movement movement;
        public int up = 1;
        public int right = 2;
        public int down = 3;
        public int left = 4;
        public int X, Y;
        int goldPurse = 0;

        // declaring getters and setters for the class for hp, max hp and damage for the character
        public int Hp
        {
            get { return hp; }
            set { hp = value; }
        }

        private int maxhp;

        public int MaxHp
        {
            get { return maxhp; }
            set { maxhp = value; }
        }

        private int damage;

        public int Damage
        {
            get { return damage; }
            set { damage = value; }
        }
        // declaring constructors for the character classes and pulling the neccessary variables
        /*public Character(int _X, int _Y, TileType _TOT, string _Symbol) : base(_X, _Y, _TOT, _Symbol)
         {
             _X = X;
             _Y = Y;
         }*/
        // declaring constructors for the character classes and pulling the neccessary variables
        public Character( int _X, int _Y, TileType _TOT, string _Symbol, int _maxHp, int _Damage) : base(_X,_Y, _TOT, _Symbol)
        {
            
            maxHp = _maxHp;
            Damage = _Damage;
            charVision = new Tile[4];
        }

        //declaring an enum list for the different movements for the charcter 
        public enum Movement
        {
            noMovement,
            Up,
            Down,
            Left,
            Right
        }
        //minuses the damage of the player by the enemies health 
        public virtual void Attack(Character _Target)
        {
            _Target.hp -= damage;
        }
        //,ethod checks if the player and goblins are dead and returns the neccessary info accordingly
        public Boolean isDead()
        {
            Boolean isDead = false;
            if (hp <= 0)
            {
                return isDead;
            }
            else
            {
                return true;
            }

        }
        //check if the character is in range of their target and does the math to determine how much damage is done for each range value
        public virtual bool checkRange(Character _Target)
        {
            int Range = 1;
            Boolean inRange = false;
            if (DistanceTo(_Target) < Range)
            {
                return true;
            }
            else
            {
                return inRange;
            }
            return inRange;
        }


        //this method checks the distance from which the player is to the target 
        private int DistanceTo(Character _Target)
        {
            //int distanceToTarget = 0;         ---> becuase it set the value to 0

            int _Xspaces = X - _Target.X;
            int _Yspaces = Y - _Target.Y;

            int distanceToTarget = Math.Abs(_Xspaces + _Yspaces); // Keeps all values positive

            return distanceToTarget;
        }
       
        

        public override string ToString()
        {
            return base.ToString();
        }

        public abstract int ReturnMove();

        public void Pickup(Item i)
        {
            if (i is Gold)
            {
                Gold gold = i as Gold;
                goldPurse = goldPurse + gold.GOLD;
            }
        }



    }
}





