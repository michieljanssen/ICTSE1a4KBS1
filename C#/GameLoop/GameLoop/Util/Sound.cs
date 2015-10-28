using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.IO;
using System.Runtime.InteropServices;

namespace GameLoop
{
    static class Sound
    {
        //volume veranderen
        [DllImport("winmm.dll")]
        public static extern int waveOutSetVolume(IntPtr hwo, uint dwVolume);

        //music
        public static Stream canCanMlgAncietnReality = Properties.Resources.CAN_CAN_MLG_ANCIENTREALITY;
        public static Stream darudeMlgStorm = Properties.Resources.Darude_MLGstorm;
        public static Stream sanic = Properties.Resources.ITS_SANNIIC;
        public static Stream skeleton = Properties.Resources.Spooky_Skeletons_MLW_Remix;

        //sound effect
        public static Stream headshot = Properties.Resources.Headshot;
        public static Stream hitmarker = Properties.Resources.Hitmarker_sound_shit;
        public static Stream illuminatieConfirmed = Properties.Resources.ILLUMINATI_CONFIRMED;


        //plays sound
        public static void playEffect(Stream stream)
        {
            //zet het volume voor het geluid uit de settings
            waveOutSetVolume(IntPtr.Zero, (uint)(uint.MaxValue  / 100 * Menutest.Settings.effectsVolume));
            //zet stream position naaar begin
            stream.Position = 0;
            SoundPlayer sound = new SoundPlayer(stream);
            //geluid afspelen
            sound.Play();

        }

    }
}
