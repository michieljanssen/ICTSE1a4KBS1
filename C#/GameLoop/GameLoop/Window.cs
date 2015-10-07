﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameLoop
{
    public partial class Window : Form
    {
        //defineren gameloop
        private GameLoop loop;

        //aanmaken window
        public Window()
        {
            //aanmaken gameloop
            loop = new GameLoop(this, 60, false, 60);
            InitializeComponent();
            
            //style van het scherm aanpassen voor optimalizatie
          
        }

        //load event van het scherm
        private void Window_Load(object sender, EventArgs e)
        {
            //paint/render compenent in de renderloop
            this.Paint += new PaintEventHandler(loop.render);
            this.DoubleBuffered = true;
        }    

        //closing event van het scherm
        private void Window_FormClosing(object sender, FormClosingEventArgs e)
        {
            //sluit de gameloop en thread af
            loop.Running = false;
            loop.loopThread.Abort();
        }
        //keydown event
        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            loop.game.keyboard.Window_KeyDown(sender, e);
        }
        //keyup event
        private void Window_KeyUp(object sender, KeyEventArgs e)
        {
            loop.game.keyboard.Window_KeyUp(sender, e);
        }

        
    }
}
