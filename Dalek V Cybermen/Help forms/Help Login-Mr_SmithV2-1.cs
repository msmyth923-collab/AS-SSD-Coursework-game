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
    public partial class Help_Login : Form
    {
        drwhoSound_Player SoundPlayer = new drwhoSound_Player();
        public Help_Login()
        {
            InitializeComponent();
        }

        private void Help_Login_Load(object sender, EventArgs e)
        {
            string videoPath = Path.Combine(Application.StartupPath, "login.mp4");
            axWindowsMediaPlayer1.URL = videoPath;
            axWindowsMediaPlayer1.Ctlcontrols.play(); //playes the video
        }

        private void loginBTN_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login_Form loginForm = new Login_Form(SoundPlayer);
            loginForm.Show();
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            SoundPlayer.playintroSound();
        }
    }
}
