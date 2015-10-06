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
        float x = 0;
        Boolean direction;

        public Game()
        {


        }

        public void render(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Red, 1);
            for (int xx = 0; xx < 20; xx++)
            {
                for (int y = 0; y <20; y++)
                {
                    
                    e.Graphics.DrawRectangle(pen, x + xx * 64, y * 64, 64, 64);
                }
            }
        }
        public void update(float time)
        {
            if (direction)
            {
                x += 1f * time;
            }
            else {
                x -= 1f * time;
            }
            if (x > 200) {
                direction = false;
            }
            else if (x < 20) {
                direction = true;
            }
        }

    }
}
