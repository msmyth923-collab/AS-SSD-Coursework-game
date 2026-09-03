using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Dalek_V_Cybermen.Help_forms
{
    public partial class MainMenu_help_Form : Form
    {
        drwhoSound_Player SoundPlayer = new drwhoSound_Player();

        public static Player_Class player;
        public MainMenu_help_Form(Player_Class playerclass)
        {
            InitializeComponent();
            player = playerclass;
        }

        private void MainMenu_help_Form_Load(object sender, EventArgs e)
        {
            string videoPath = Path.Combine(Application.StartupPath, "mainmenu.mp4");
            axWindowsMediaPlayer1.URL = videoPath;
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void mmBTN_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main_Menu_Form mmf = new Main_Menu_Form(player,SoundPlayer);
            mmf.Show();
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            SoundPlayer.playintroSound();
        }
    }
}
