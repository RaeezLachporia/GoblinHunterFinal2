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
        // declaring the getters and the setter for the values used in the class
        private Map game;

        public Map Game
        {
            get { return game; }
            set { game = value; }
        }
        //this method moves the player 
        public bool movePlayer(Movement movement)
        {
            return true;
        }


        //declaring the constructor and pulling the variables that are neccessary in this class
       /* public GameEngine(int _X, int _Y, String _ESYMBOL, TileType _TOT, int _Damage, int _MAXHP, int _mapMinHGHT, int _mapMaxHGHT, int _mapMinWDTH, int _mapMaxWDTH, int _NumberOfEnemies, int _Gold) : base(_X, _Y, " ", _TOT, _mapMinHGHT, _mapMaxHGHT, _mapMinWDTH, _mapMaxWDTH, 0, 9)
        {
           *//* int _gX = _X;
            int _gY = _Y;
            String _gSymbol = _ESYMBOL;
            TileType _gTOT = _TOT;
            int _gD = _Damage;
            int _gMAXHP = _MAXHP;
            int _gMapMinHght = _mapMinHGHT;
            int _gMapMaxHght = _mapMinHGHT;
            int _gMapMinWDTH = _mapMinWDTH;
            int _gMapMaxWDTH = _mapMaxWDTH;
            int _gNumEnemies = _NumberOfEnemies;
            int _gGold = _Gold;
           *//* Map mp = new Map(_gX, _gY, _gSymbol, _gTOT, _gMapMinWDTH, _gMapMaxWDTH, _gMapMinHght, _gMapMaxHght, _gNumEnemies, _gGold);
            Map mmap = new Map(10, 10, " ", TileType.Empty, 10, 10, 10, 10, 10, 10);*//*
        }*/

        

        public void Save()
        {

            BinaryFormatter bf = new BinaryFormatter();
            FileStream fsin = new FileStream("GoblinHunter.dat", FileMode.Open, FileAccess.Read, FileShare.None);

            try
            {
                using (fsin)
                {
                    // = (Map)bf.Deserialize(fsin);
                    Console.WriteLine(Map.TileType.Barrier);
                    Console.WriteLine(Map.TileType.Empty);
                    Console.WriteLine(Map.TileType.Hero);
                    Console.WriteLine(Map.TileType.Enemy);
                    Console.WriteLine(Map.TileType.Gold);
                    Console.WriteLine(Map.TileType.Weapon);
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

        public GameEngine(int _EnemyX, int _EnemyY, string _ESYMBOL, TileType _TOT, int _MINWIDTH, int _MAXWIDTH, int _MINHEIGHT, int _MAXHEIGHT, int _NUMBEROFENEMIES, int _NUMGOLD) : base(_EnemyX, _EnemyY, _ESYMBOL, _TOT, _MINWIDTH, _MAXWIDTH, _MINHEIGHT, _MAXHEIGHT, _NUMBEROFENEMIES, _NUMGOLD)
        {
        }
    }
}
