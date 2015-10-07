using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gameconsoleversie
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Level level1 = new Level(20, 20,1,1,18,18);
            redraw:
            Console.Clear();
            level1.drawlvl();
            //Controllersetup
            ConsoleKeyInfo a;
            a = Console.ReadKey();
            Console.WriteLine(a.Key);
            switch (a.Key.ToString())
            {
                default:
                    break;
                case "DownArrow":
                    level1.moveuserdown();
                    break;
                case "UpArrow":
                    level1.moveuserup();
                    break;
                case "LeftArrow":
                    level1.moveuserleft();
                    break;
                case "RightArrow":
                    level1.moveuserright();
                    break;
            }
            if(level1.User.X == 18 && level1.User.Y == 18)
            {
                Console.Clear();
                level1.drawlvl();
                Environment.Exit(0);
            }
            goto redraw;


        }
    }
}
