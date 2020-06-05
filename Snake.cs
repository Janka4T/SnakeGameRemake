using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace SnakeGameRemake
{
    class Snake
    {
        private Form game = null;
        private PictureBox snakePixel = null;
        private List<PictureBox> snakePixels = new List<PictureBox>();

        public Snake(Form form)
        {
            InitializeSnake();
            game = form;
        }

        private void InitializeSnake()
        {
            snakePixel = new PictureBox()
            {
                BackColor = Color.Black,
                Width = 20,
                Height = 20,
                Left = 200,
                Top = 200
            };
            snakePixels.Add(snakePixel);
        }

        public void Render()
        {
             
        }
    }
}
