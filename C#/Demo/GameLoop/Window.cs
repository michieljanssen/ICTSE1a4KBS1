using System;
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
        private GameLoop loop;

        public Window()
        {
           
            loop = new GameLoop(this, 60, false, 60);
            InitializeComponent();
            
            this.SetStyle(System.Windows.Forms.ControlStyles.AllPaintingInWmPaint, true); 
            this.SetStyle(System.Windows.Forms.ControlStyles.OptimizedDoubleBuffer, true) ;
          
            this.SetStyle(ControlStyles.FixedHeight, true);
            this.SetStyle(ControlStyles.FixedWidth, true);
            this.SetStyle(System.Windows.Forms.ControlStyles.UserPaint, true);
            this.SetTopLevel(true);
        }

      

        private void Window_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

       
        private void Window_Load(object sender, EventArgs e)
        {

            this.Paint += new PaintEventHandler(loop.render);
            this.DoubleBuffered = true;
        }

        private void Window_FormClosing(object sender, FormClosingEventArgs e)
        {
            loop.Running = false;
            loop.loopThread.Abort();
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            Console.WriteLine(e.KeyValue);
            switch (e.KeyValue)
            {

                case 39:
                    loop.game.level.moveuserdown();
                    break;
                case 37:
                    loop.game.level.moveuserup();
                    break;
                case 38:
                    loop.game.level.moveuserleft();
                    break;
                case 40:
                    loop.game.level.moveuserright();
                    break;
            }
            //loop.game.level.;
        }
       
    }
}
