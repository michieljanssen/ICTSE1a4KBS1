using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;


namespace GameLoop
{
    class Game
    {

        public Game()
        {


        }

        public void render(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Red, 1);
            e.Graphics.DrawRectangle(pen, 10, 10, 10, 10);
        }
        public void update(float time)
        {

        }

    }
}
