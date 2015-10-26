using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.IO;

namespace GameLoop
{
    class Sound
    {
        static SoundPlayer music;

        public static Stream headshot = Properties.Resources.Headshot;
        public static Stream hitmarker = Properties.Resources.Hitmarker_sound_shit;
        
        public Sound() { 
        
        
        }

        public static void playEffect(Stream stream) {
            SoundPlayer sound = new SoundPlayer(stream);
            sound.Play();
        }

        public static void playMusic(Stream stream) { 
           music =  new SoundPlayer(stream);
           music.PlayLooping();
        }

    }
}
