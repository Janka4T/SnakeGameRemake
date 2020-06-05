﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeGameRemake
{
    public partial class Game : Form
    {
        GameZone gameZone = null;
        Snake snake = null;
        public Game()
        {
            InitializeComponent();
            InitializeGame();
        }

        private void InitializeGame()
        {
            this.Width = 500;
            this.Height = 500;

            gameZone = new GameZone();
            gameZone.Location = new Point(50, 50);
            this.Controls.Add(gameZone);

            snake = new Snake();
           
        }
    }
}
