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


        public Panel MainMenu { get { return mainmenu; } set { mainmenu = value; } }
        public Panel GameSettings { get { return settings; } set { settings = value; } }

        public Main()
        {
            InitializeComponent();
            Control_Down.Parent = this;
            Control_Up.Parent = this;
            Control_Left.Parent = this;
            Control_Right.Parent = this;
            Control_Menu.Parent = this;
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            Sound.playEffect(Sound.hitmarker);
            //Opent het settings menu
            mainmenu.Visible = false;
            settings.Visible = true;

            //Set de settings naar de values van de Settings class
            refreshRate = Settings.refreshRate;
            musicVolume = Settings.musicVolume;
            effectsVolume = Settings.effectsVolume;
            //musicVolumeSlider.Value = Settings.musicVolume;
            effectsVolumeSlider.Value = Settings.effectsVolume;
            refreshRateBox.Text = Settings.refreshRate.ToString();
        }

        private void QuitGameButton_Click(object sender, EventArgs e)
        {
            //Opent het 'wil je echt stoppen'-scherm als je op 'Quit Game' drukt
            Sound.playEffect(Sound.hitmarker);
            ExitBox exit = new ExitBox();
            exit.ShowDialog();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.KeyUp += new KeyEventHandler(Main_KeyUp);
            this.KeyDown += new KeyEventHandler(Main_KeyDown);
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Sound.playEffect(Sound.hitmarker);
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

            //Zolang de panel niet werkt:
            //GameLoop.Window i = new GameLoop.Window();
            //i.ShowDialog();
            // this.Visible = true;
            mainmenu.Hide();
            mainmenu.Visible = false;
            settings.Hide();
            settings.Visible = false;
            this.Visible = true;
            Sound.playEffect(Sound.hitmarker);
            loop = new Loop(this, 60, true, Menutest.Settings.refreshRate);


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
            //musicVolume = musicVolumeSlider.Value;
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
            Sound.playEffect(Sound.hitmarker);
            //Sla alles op in de settings klasse
            if (refreshRateBox.Text != "")
            {
                Settings.refreshRate = refreshRate;
            }
            //Settings.musicVolume = musicVolumeSlider.Value;
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

        private void refreshRateBox_KeyUp(object sender, KeyEventArgs e)
        {
            //Update de refreshRate elke keer als er een toets word aangeslagen
            if (refreshRateBox.Text != "")
            {
                refreshRate = Int32.Parse(refreshRateBox.Text);
                Console.WriteLine("Refresh Rate: {0}", refreshRate);
            }
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
            if (loop != null)
            {
                loop.game.keyboard.Window_KeyUp(sender, e);
            }
        }
        //sluit de gameloop af als hij aanstaat
        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (loop != null)
            {
                loop.Running = false;
                loop.loopThread.Abort();
            }
        }

        //on screen control released event
        private void ControlUp(object sender, MouseEventArgs e)
        {
            if (loop != null)
            {
                if (sender.Equals(Control_Up))
                {
                    loop.game.keyboard.ControlUp(38);
                }
                else if (sender.Equals(Control_Down))
                {
                    loop.game.keyboard.ControlUp(40);
                }
                else if (sender.Equals(Control_Left))
                {
                    loop.game.keyboard.ControlUp(37);
                }
                else if (sender.Equals(Control_Right))
                {
                    loop.game.keyboard.ControlUp(39);
                }
            }
        }

        //on screen control pressed event
        private void ControlDown(object sender, MouseEventArgs e)
        {
            if (loop != null)
            {
                if (sender.Equals(Control_Up))
                {
                    loop.game.keyboard.ControlDown(38);
                }
                else if (sender.Equals(Control_Down))
                {
                    loop.game.keyboard.ControlDown(40);
                }
                else if (sender.Equals(Control_Left))
                {
                    loop.game.keyboard.ControlDown(37);
                }
                else if (sender.Equals(Control_Right))
                {
                    loop.game.keyboard.ControlDown(39);
                }
            }
        }
        //ingame menu openen
        private void Control_Menu_Click(object sender, EventArgs e)
        {
            Sound.playEffect(Sound.hitmarker);
            loop.game.paused = true;
            ExitGame exit = new ExitGame(loop.game);
            exit.Show();
        }
    }
}
