using System;
using System.Windows.Forms;
using GameLoop;

namespace Menutest
{
    public partial class Main : Form
    {
        //Voor de GameLoop:
        private Loop loop;

        //Haalt de settings op uit de Settings class
        static int refreshRate = Settings.refreshRate;
        static int musicVolume = Settings.musicVolume;
        static int effectsVolume = Settings.effectsVolume;
        //Maakt een boolean aan voor de exitwithoutsave bij het settings menu
        public static bool istrue = false;

        public Panel GPanel { get { return GamePanel; } }

        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            //Opent het settings menu
            mainmenu.Visible = false;
            settings.Visible = true;
            //Set de settings naar de values van de Settings class
            refreshRate = Settings.refreshRate;
            musicVolume = Settings.musicVolume;
            effectsVolume = Settings.effectsVolume;
            musicVolumeSlider.Value = Settings.musicVolume;
            effectsVolumeSlider.Value = Settings.effectsVolume;
            refreshRateBox.Text = Settings.refreshRate.ToString();
        }

        private void QuitGameButton_Click(object sender, EventArgs e)
        {
            //Opent het 'wil je echt stoppen'-scherm als je op 'Quit Game' drukt
            ExitBox exit = new ExitBox();
            exit.ShowDialog();
        }

        private void Main_Load(object sender, EventArgs e)
        {
           this.DoubleBuffered = true;
           this.KeyPreview = true;
           this.KeyUp +=new KeyEventHandler(Main_KeyUp);
           this.KeyDown += new KeyEventHandler(Main_KeyDown);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            //Controleert of alle settings zijn opgeslagen
            if (refreshRate != Settings.refreshRate || musicVolume != Settings.musicVolume
                || effectsVolume != Settings.effectsVolume)
            {
                //Zo nee: Open SettingsNoSave Dialog
                SettingsNoSave a = new SettingsNoSave();
                a.ShowDialog();
                //Als er op ja gedrukt wordt in deze Dialog wordt alles gereset en wordt naar het hoofdmenu gegaan
                if (istrue)
                {
                    //Kiest de gebruiker voor teruggaan zonder op te slaan, dan gebeurt dat
                    settings.Visible = false;
                    mainmenu.Visible = true;

                    //istrue wordt weer teruggezet voor een volgende keer teruggaan naar het hoofdmenu zonder opslaan
                    istrue = false;

                    //Reset de settings
                    refreshRate = Settings.refreshRate;
                    musicVolume = Settings.musicVolume;
                    effectsVolume = Settings.effectsVolume;
                    refreshRateBox.Text = Settings.refreshRate.ToString();
                }
            }
            //Als alles al is opgeslagen wordt zonder Dialog naar het hoofdmenu gegaan
            else
            {
                settings.Visible = false;
                mainmenu.Visible = true;
            }
        }

        private void SelectLevel_Click(object sender, EventArgs e)
        {
            loop = new Loop(this, 60, true, Menutest.Settings.refreshRate);


            //Zolang de panel niet werkt:
            //GameLoop.Window i = new GameLoop.Window();
            //i.ShowDialog();
            
            mainmenu.Visible = false;
            GamePanel.Visible = true;
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void effectsVolumeSlider_Scroll(object sender, EventArgs e)
        {
            //Set de int effectsVolume elke keer als er gescrollt wordt in de effectsVolumeSlider
            effectsVolume = effectsVolumeSlider.Value;
            //Console.WriteLine("Effects: {0}", effectsVolumeSlider.Value);
        }

        private void musicVolumeSlider_Scroll(object sender, EventArgs e)
        {
            //Set de int musicVolume elke keer als er gescrollt wordt in de musicVolumeSlider
            musicVolume = musicVolumeSlider.Value;
            //Console.WriteLine("Music: {0}", musicVolumeSlider.Value);
        }

        private void refreshRateBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Zorgt ervoor dat alleen nummers, backspace en delete kunnen worden gebruikt in de refreshratebox
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            //Sla alles op
            if (refreshRateBox.Text != "")
            {
                Settings.refreshRate = refreshRate;
            }
            Settings.musicVolume = musicVolumeSlider.Value;
            Settings.effectsVolume = effectsVolumeSlider.Value;
        }

        private void refreshRateBox_Enter(object sender, EventArgs e)
        {
            //Als de tekst in de refreshratebox niet niks is wordt deze als int opgeslagen in de int refreshRate
            if (refreshRateBox.Text != "")
            {
                refreshRate = Int32.Parse(refreshRateBox.Text);

            }
        }

        private void refreshRateBox_ClientSizeChanged(object sender, EventArgs e)
        {
            //Set de text in de refreshratebox naar de refreshrate bij het starten van het programma
            refreshRateBox.Text = refreshRate.ToString();
        }

        private void musicVolumeSlider_ClientSizeChanged(object sender, EventArgs e)
        {
            musicVolumeSlider.Value = musicVolume;
        }

        private void refreshRateBox_KeyUp(object sender, KeyEventArgs e)
        {
            //Update de refreshRate elke keer als er een toets word aangeslagen
            if (refreshRateBox.Text != "")
            {
                refreshRate = Int32.Parse(refreshRateBox.Text);
                Console.WriteLine("Refresh Rate: {0}", refreshRate);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void mainmenu_Paint(object sender, PaintEventArgs e)
        {
          
        }

        private void GamePanel_Paint(object sender, PaintEventArgs e)
        {
           
        }
        //keydown event
        private void Main_KeyDown(object sender, KeyEventArgs e)
        {
            if (loop != null)
            {
                loop.game.keyboard.Window_KeyDown(sender, e);
            }
        }
        //keyup event
        private void Main_KeyUp(object sender, KeyEventArgs e)
        {
          if(loop != null){
             loop.game.keyboard.Window_KeyUp(sender, e);
           }
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (loop != null)
            {
                loop.Running = false;
                loop.loopThread.Abort();
            }
        }

    }
}
