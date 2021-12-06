using System;
using System.Collections.Generic;
using System.Text;

namespace GoblinHunterFinal2
{
    class Goblin : Enemy
    {
        // public Goblin[] gobVision;
        int gobDirection;
        public Random rnd = new Random();

        private int health;
        public int Health
        {
            get { return health; }
            set { health = value; }
        }

        private int damage;

        public Goblin(int _CharacterX, int _CharacterY, TileType _TOT, string _Symbol, int _Hp, int _maxHp, int _Damage) : base(_CharacterX, _CharacterY, _TOT, _Symbol, _Hp, _maxHp, _Damage)
        {
        }

        public int Damage
        {
            get { return damage; }
            set { damage = value; }
        }

        public Movement GetMovement()
        {
            int RandomTileIndex = rnd.Next(0, GobVision.Count);
            while (GobVision[RandomTileIndex].TOT.Equals(typeof(EmptyTile)))
            {
                RandomTileIndex = rnd.Next(0, GobVision.Count);
            }
            if (GobVision[RandomTileIndex].X > X)
            {
                return Movement.Right;
            }
            else if (GobVision[RandomTileIndex].X < X)
            {
                return Movement.Left;
            }
            else if (GobVision[RandomTileIndex].Y > Y)
            {
                return Movement.Up;
            }
            else if (GobVision[RandomTileIndex].Y < Y)
            {
                return Movement.Down;
            }
            else
            {
                return Movement.noMovement;
            }
        }

        public override int ReturnMove()
        {
            throw new NotImplementedException();
        }
    }
}
