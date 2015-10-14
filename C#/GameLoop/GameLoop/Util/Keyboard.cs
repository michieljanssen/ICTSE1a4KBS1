﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace GameLoop
{
    class Keyboard
    {
        //array van alle mogelijk toetsen
        private Boolean[] keys;
        //status van toetsen die worden gebruikt in 
        public Boolean up, down, left, right, esc;

        public Keyboard()
        {
            //intalizeren toetsen
            keys = new Boolean[0xFE];
        }

        //update avn de keys
        public void update()
        {
            //checken of de toetsen zijn ingedrukt
            up = keys[38] || keys[87];
            down = keys[40] || keys[83];
            left = keys[37] || keys[65];
            right = keys[39] || keys[68];
            esc = keys[27];
        }

        //keydown event
        public void Window_KeyDown(object sender, KeyEventArgs e)
        {
            //zet de correcte toets op ingedrukt
            keys[e.KeyValue] = true;
        }

        //keyup event
        public void Window_KeyUp(object sender, KeyEventArgs e)
        {
            keys[e.KeyValue] = false;
        }


    }
}
