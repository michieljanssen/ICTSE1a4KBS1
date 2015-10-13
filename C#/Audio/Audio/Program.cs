using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.IO;

namespace Audio
{
    class Program
    {
        static Stream stream = Properties.Resources.test;
        static  SoundPlayer sound = new SoundPlayer(stream);
        static void Main(string[] args)
        {
            sound.Play();
            //Console.Read();
        }
    }
}
