using System;
using System.Collections.Generic;
using System.Text;

namespace GoblinHunterFinal2
{
    class Hero : Character
    {
        //declaring the variables for the class
        int heroX, heroY;
        private int hp;
        String heroSymbol;
        String info;

        //declaring the getters and setters for the hp, max hp and hero damage 
        public int HP
        {
            get { return hp; }
            set { hp = value; }
        }

        private int maxhp;

        public int MAXHP
        {
            get { return maxhp; }
            set { maxhp = value; }
        }

        private int heroDamage;

        public Hero(int _CharacterX, int _CharacterY, TileType _TOT, string _Symbol, int _Hp, int _maxHp, int _Damage) : base(_CharacterX, _CharacterY, _TOT, _Symbol, _Hp, _maxHp, _Damage)
        {
            heroX = _CharacterX;
            heroY = _CharacterY;
            MAXHP = _maxHp;
            HP = _Hp;
            heroSymbol = _Symbol;
        }

        public int HERODAMAGE
        {
            get { return heroDamage; }
            set { heroDamage = value; }
        }


        //declaring the constructors and pulling the different variables 
        /*public Hero(int _HeroX, int _HeroY, TileType _TOT,int _HP,int _MaxHP,int _heroDamage,char _hSymbol) : base(_X, _Y, _TOT)
        {
            heroX = _HeroX;
            heroY = _HeroY;
            MAXHP = _MaxHP;
            HP = _HP;
            _hSymbol = heroSymbol;
        }*/
        public Movement noMovement()
        {
            if (movement != Movement.Down)
            {
                return Movement.noMovement;
            }
            else if (movement != Movement.Up)
            {
                return Movement.noMovement;
            }
            else if (movement != Movement.Left)
            {
                return Movement.noMovement;
            }
            else if (movement != Movement.Right)
            {
                return Movement.noMovement;
            }
            else
            {
                return Movement.noMovement;
            }

        }
        /*public override RetrunMove()
        {
        }*/
        //this method displayss the information related to this class
        public override string ToString()
        {
            info += "Player Stats:";
            info += "HP:" +"/" + "MaxHp:";
            info += "Damage: " + heroDamage;

            return info;
        }

        public override int ReturnMove()
        {
            throw new NotImplementedException();
        }
    }
}
