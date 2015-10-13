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
    public partial class ReallyClose : Form
    {
        public ReallyClose()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void No_Click(object sender, EventArgs e)
        {
            Window.istrue = false;
            this.Close();
        }

        private void Yes_Click(object sender, EventArgs e)
        {
            Window.istrue = true;
            this.Close();
        }
    }
}
