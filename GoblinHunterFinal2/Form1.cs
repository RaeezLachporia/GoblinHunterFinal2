using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoblinHunterFinal2
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            GameEngine GM = new GameEngine(10, 10, " ", Tile.TileType.Empty, 10, 10, 10, 10, 10, 10,3,3);
          
            GM.generateMap();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
