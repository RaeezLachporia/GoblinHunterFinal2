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
            GameEngine GM = new GameEngine(10, 10, 10, 10, 4, 5);
          
            GM.generateMap();
            txtPlayerInfo.Text = GM.PLAYERCHARACTER.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
