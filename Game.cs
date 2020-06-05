using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeGameRemake
{
    public partial class Game : Form
    {
        GameZone gameZone = null;
        public Game()
        {
            InitializeComponent();
            InitializeGame();
        }

        private void InitializeGame()
        {
            gameZone = new GameZone();
            this.Controls.Add(gameZone);
        }
    }
}
