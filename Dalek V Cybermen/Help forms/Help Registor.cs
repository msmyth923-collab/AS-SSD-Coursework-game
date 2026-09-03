using Dalek_V_Cybermen.Before_Game_forms;
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
    public partial class Help_Registor : Form
    {

        drwhoSound_Player SoundPlayer = new drwhoSound_Player();
        public Help_Registor(drwhoSound_Player playMe)
        {
            InitializeComponent();
            registorBTN.TabStop = false;
                SoundPlayer = playMe;
        }

        private void Help_Registor_Load(object sender, EventArgs e)
        {
            string videoPath = Path.Combine(Application.StartupPath, "registor.mp4");
            axWindowsMediaPlayer1.URL = videoPath;
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void registorBTN_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            this.Hide();
            registor_form regForn = new registor_form(SoundPlayer);
            regForn.Show();
            SoundPlayer.playintroSound();
        }
    }
}
