using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Xml;
using System.Xml.Linq;
using System.IO;


namespace GameLoop
{
    public class Game
    {
        //game variablene declarenen
        public Loop loop;
        //keyboard input class
        public Keyboard keyboard;
      
        private Level map;
        public Boolean paused = false;

        public Game(Loop loop)
        {
            this.loop = loop;

            //variablene intializeren
            keyboard = new Keyboard();
            //  Location levelformaat = new Location(20, 20);
            //  Location startpunt = new Location(1, 1);
            // Location eindpunt = new Location(10, 10);
            // int tilesize = 32;
            // map = new Level(levelformaat, startpunt, eindpunt, tilesize);
            XDocument level1 = XDocument.Parse(Properties.Resources.Level1);
            //Properties.Resources.ResourceManager.GetStream("Level1.xml");
            map = new Level(level1, this);

        }

        //render metode
        public void render(object sender, PaintEventArgs e)
        {
            map.Paint(sender, e);
          
        }

        //update metode
        public void update(float time)
        {
            if (!paused)
            {
                //keyboard update
                keyboard.update();

                map.update(keyboard, time);
            }
        }

        public void changeLevel(XDocument xdoc)
        {
            map = new Level(xdoc, this);
        }

        int timesWon = 0;
        string[] levels = {
            Properties.Resources.Level1,
            Properties.Resources.Level2,
            Properties.Resources.Level3,
        };
        public void nextLevel()
        {
            timesWon++;
            XDocument level = XDocument.Parse(levels[timesWon]);
            map = new Level(level, this);
        }
    }
}
