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

            // Level 1 initializeren
            XDocument level1 = XDocument.Parse(Properties.Resources.Level1);
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

        // Methode om terug te gaan naar het main menu vanuit de game
        public void backToMain()
        {
            if (this.loop.window.InvokeRequired)
            {
                this.loop.window.Invoke(new MethodInvoker(this.loop.window.MainMenu.BringToFront));
                this.loop.window.Invoke(new MethodInvoker(() => this.loop.window.MainMenu.Visible = true));
            }
            this.loop.window.CreateGraphics().Clear(Color.White);
            this.loop.Running = false;
            this.loop.loopThread.Abort();
        }
        
        // Aantal keren dat je level complete per instance
        int timesWon = 0;
        // Array met strings
        static string[] levels = {
            Properties.Resources.Level1,
            Properties.Resources.Level2,
            Properties.Resources.Level3,
        };
        //Totaal aantal levels. De lengte van de array
        int totalLevels = levels.Length;
        // Methode om aan te roepen als je op de finish komt
        public void nextLevel()
        {
            timesWon++;
            // Als aantal keren gewonnen gelijk of groter is dan het aantal levels heb je het spel uitgespeeld
            if(timesWon >= totalLevels)
            {
                var result = MessageBox.Show("Exit game?", "You have beaten the game!",
                                                                     MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Environment.Exit(0);
                }
                else if (result == DialogResult.No)
                {
                    this.backToMain();
                }
                

            }
            // Zo niet, dan krijg je het volgende level
            else
            {
                var result = MessageBox.Show("Next level?", "You won!",
                                                 MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    XDocument level = XDocument.Parse(levels[timesWon]);
                    map = new Level(level, this);
                }
                else if (result == DialogResult.No)
                {
                    this.backToMain();
                }
            }
            

        }
    }
}
