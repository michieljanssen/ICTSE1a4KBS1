using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

using Gameconsoleversie;

namespace GameLoop
{
    class Game
    {
        public Level level;

        public Game()
        {
            level = new Level(20, 20, 1, 1, 18, 18);

        }

        public void render(object sender, PaintEventArgs e)
        {
            level.drawlvl( sender, e);

        }
        public void update(float time)
        {
          
          
            if (level.User.X == 18 && level.User.Y == 18)
            {
                Environment.Exit(0);
            }
        }
    }
}
