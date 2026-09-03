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

namespace Dalek_V_Cybermen.Help_forms
{
    public partial class GameHelp : Form
    {
        public static Player_Class currentPlayer;
        drwhoSound_Player SoundPlayer = new drwhoSound_Player();
        public GameHelp(Player_Class playerCurrent,drwhoSound_Player playmeYEAH)
        {
            InitializeComponent();
            currentPlayer = playerCurrent;

            SoundPlayer = playmeYEAH;

            continueBTN.TabStop = false;



        }

        private void continueBTN_Click(object sender, EventArgs e)
        {
            this.Hide();
            Diffculty_selction diffSelcForm = new Diffculty_selction(currentPlayer,SoundPlayer);
            diffSelcForm.Show();
            axWindowsMediaPlayer1.Ctlcontrols.stop(); //stops the video being played
            
        }

        private void GameHelp_Load(object sender, EventArgs e)
        {
            string videoPath = Path.Combine(Application.StartupPath, "game tutorial.mp4"); //assigns the video file to be shown and played
            axWindowsMediaPlayer1.URL = videoPath;
        }

        private void mmBTN_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main_Menu_Form mmf = new Main_Menu_Form(currentPlayer,SoundPlayer);
            mmf.Show();
            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }


    }
}
