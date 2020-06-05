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
        private PictureBox snakePixel;
        private List<PictureBox> snakePixels = new List<PictureBox>();

        public Snake()
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
    }
}
