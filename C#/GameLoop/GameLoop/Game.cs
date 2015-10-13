using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Xml;
using System.IO;

namespace GameLoop
{
    class Game
    {
        //game variablene declarenen

        //keyboard input class
        public Keyboard keyboard;
      
        private Level map;

        public Game()
        {
            //variablene intializeren
            keyboard = new Keyboard();
          //  Location levelformaat = new Location(20, 20);
          //  Location startpunt = new Location(1, 1);
           // Location eindpunt = new Location(10, 10);
           // int tilesize = 32;
           // map = new Level(levelformaat, startpunt, eindpunt, tilesize);
            XmlReader testxml = Controller.XML.read(new FileStream(Directory.GetCurrentDirectory() + "/Resources/" + "Test.xml", FileMode.Open));
            map = new Level(testxml);

        }

        //render metode
        public void render(object sender, PaintEventArgs e)
        {
            map.Paint(sender, e);
          
        }

        //update metode
        public void update(float time)
        {
            //keyboard update
            keyboard.update();
           
            map.update(keyboard, time);
        }
    }
}
