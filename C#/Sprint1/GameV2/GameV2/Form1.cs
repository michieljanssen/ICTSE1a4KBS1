using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace GameV2
{
    public partial class Form1 : Form
    {
        Player speler;
        Level map;
        public Form1() // main window
        {
            Location levelformaat = new Location(10, 10);
            Location startpunt = new Location(1, 1);
            Location eindpunt = new Location(10, 10);
            int tilesize = 32;
            map = new Level(levelformaat,startpunt,eindpunt,tilesize);
            speler = new Player(map.Start,tilesize);
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            map.Paint(sender, e);
            speler.Paint(sender, e);
        }
    }
}
