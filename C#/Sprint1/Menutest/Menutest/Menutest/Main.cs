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
            
            Settings settings = new Settings();
            settings.StartPosition = FormStartPosition.CenterParent;
            settings.Show();
            this.Hide();
        }

        private void QuitGameButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
