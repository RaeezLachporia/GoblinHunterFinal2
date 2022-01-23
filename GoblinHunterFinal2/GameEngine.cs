using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace GoblinHunterFinal2
{
    [Serializable]
    class GameEngine : Map
    {
        public Map GAMEMAP;
        public GameEngine(/*int _X, int _Y, string _ESYMBOL, TileType _TOT,*/ int _MINWIDTH, int _MAXWIDTH, int _MINHEIGHT, int _MAXHEIGHT, int _NUMBEROFENEMIES, int _NUMGOLD) : base( _MINWIDTH, _MAXWIDTH, _MINHEIGHT, _MAXHEIGHT, _NUMBEROFENEMIES, _NUMGOLD)
        {
            GAMEMAP = new Map(10, 10, 10, 10, 4, 5);
        }
        // declaring the getters and the setter for the values used in the class
        private Map game;

        public Map Game
        {
            get { return game; }
            set { game = value; }
        }
        //this method moves the player 
        public bool movePlayer(Character.Movement movement)
        {
            return true;
        }


        //declaring the constructor and pulling the variables that are neccessary in this class
       
        public bool MovePlayer(Character.Movement move)
        {
            if (GAMEMAP.PLAYERCHARACTER.ReturnMove(move) == Convert.ToInt32(move))
            {
                GAMEMAP.Create(Tile.TileType.Empty, GAMEMAP.PLAYERCHARACTER.X, GAMEMAP.PLAYERCHARACTER.Y);

                GAMEMAP.PLAYERCHARACTER.move(move);
                GAMEMAP.MAPCONTAINER[GAMEMAP.PLAYERCHARACTER.X, GAMEMAP.PLAYERCHARACTER.Y] = GAMEMAP.PLAYERCHARACTER;
                return true;
            }
            return false;
        }
        
        public String PlayerAttack(int EnemyIndex)
        {
            bool EnemyInRange = false;
            foreach(Tile T in GAMEMAP.ITEMS)
            {
                if(T.X ==GAMEMAP.ENEMIES[EnemyIndex].X && (T.Y == GAMEMAP.ENEMIES[EnemyIndex].Y))
                {
                    EnemyInRange = true;
                }
            }
            return EnemyInRange.ToString();
        }
        public void Save()
        {

            BinaryFormatter bf = new BinaryFormatter();
            FileStream fsin = new FileStream("GoblinHunter.dat", FileMode.Open, FileAccess.Read, FileShare.None);

            try
            {
                using (fsin)
                {
                    // = (Map)bf.Deserialize(fsin);
                   
                    Console.WriteLine();
                }
            }
            catch (Exception)
            {

                Console.WriteLine("Couldnt write to file ");
            }
        }

        public Boolean Load()
        {
            Boolean found = false;
            BinaryFormatter BR = new BinaryFormatter();
            FileStream fsin = new FileStream("GoblinHunter.dat", FileMode.Open, FileAccess.Read, FileShare.None);
            try
            {
                using (fsin)
                {
                    Game = (Map)BR.Deserialize(fsin);

                }
                found = true;
            }
            catch (Exception)
            {

                found = false;
            }
            return found;

        }




        //sets the symbols for the player, goblin, obstacles and empty tiles 
        public char enemy = 'G';
        public char Hero = 'H';
        public char Obstacle = 'X';
        public char emptyTile = '.';

        
    }
}
