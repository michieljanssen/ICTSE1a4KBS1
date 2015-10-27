using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.IO;

namespace GameLoop
{
    static class Sound
    {
        //music
        public static Stream canCanMlgAncietnReality = Properties.Resources.CAN_CAN_MLG_ANCIENTREALITY;
        public static Stream darudeMlgStorm = Properties.Resources.Darude_MLGstorm;
        public static Stream sanic = Properties.Resources.ITS_SANNIIC;
        public static Stream skeleton = Properties.Resources.Spooky_Skeletons_MLW_Remix;

        //sound effect
        public static Stream headshot = Properties.Resources.Headshot;
        public static Stream hitmarker = Properties.Resources.Hitmarker_sound_shit;
        public static Stream airHorn = Properties.Resources.air_horn_sad_violin_preview;
        public static Stream alluhaAkbar = Properties.Resources.Alluha_Akbar_Sound_Effect;
        public static Stream fuckHerRightInThePussy = Properties.Resources.Fuck_her_right_in_the_puss_sound_effect;
        public static Stream getNoscoped = Properties.Resources.GET_NOSCOPED;
        public static Stream wasted = Properties.Resources.GTA_V_Wasted_Busted;
        public static Stream illuminatieConfirmed = Properties.Resources.ILLUMINATI_CONFIRMED;
        public static Stream johnCena = Properties.Resources.JOHN_CENA;
        public static Stream ohBabyATriple = Properties.Resources.Oh_Baby_A_Triple_Sound;
        public static Stream shotsFired = Properties.Resources.SHOTS_FIRED;
        public static Stream smokeWeedEveryday = Properties.Resources.Smoke_Weed_Everyday;
        public static Stream whatAreThose = Properties.Resources.WHAT_ARE_THOSE;
        public static Stream wow = Properties.Resources.Wow_MLG_Sound_Effect;


        //plays sound
        public static void playEffect(Stream stream)
        {
            //zet stream position naaar begin
            stream.Position = 0;
            SoundPlayer sound = new SoundPlayer(stream);

            sound.Play();

        }

    }
}
