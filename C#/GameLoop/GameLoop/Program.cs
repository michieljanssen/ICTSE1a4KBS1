using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menutest
{
    static class Program
    {
      /// <summary>
      /// Start applicatie
      /// </summary>
        [STAThread]
        static void Main()
        {  
            //aanmaken window
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
        }
    }
}
