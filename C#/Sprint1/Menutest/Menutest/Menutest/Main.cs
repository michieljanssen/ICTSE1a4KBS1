using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menutest
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            settings.Visible = true;
        }

        private void QuitGameButton_Click(object sender, EventArgs e)
        {
            exitBox exit = new exitBox();
            exit.ShowDialog();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            settings.Visible = false;
        }
    }
}
