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
        //game variablene declarenen

        //keyboard input class
        public Keyboard keyboard;

        public Game()
        {
            //variablene intializeren
            keyboard = new Keyboard();

        }

        //render metode
        public void render(object sender, PaintEventArgs e)
        {
          
        }

        //update metode
        public void update(float time)
        {
            //keyboard update
            keyboard.update();
          
        }
    }
}
