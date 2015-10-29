using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GameLoop;

namespace Menutest
{
    public partial class ExitBox : Form
    {
        //opent het afsluit notificatie menu
        public ExitBox()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        //sluit het exit menu
        private void button2_Click(object sender, EventArgs e)
        {
            Sound.playEffect(Sound.hitmarker);
            this.Close();
        }
        //sluit applicatie af als de ja knop word ingedrukt
        private void YesBtn_Click(object sender, EventArgs e)
        {
            Sound.playEffect(Sound.hitmarker);
            Application.Exit();
        }
    }
}
