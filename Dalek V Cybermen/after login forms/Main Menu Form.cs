using Dalek_V_Cybermen.after_login_forms;
using Dalek_V_Cybermen.Before_Game_forms;
using Dalek_V_Cybermen.Help_forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dalek_V_Cybermen
{
    public partial class Main_Menu_Form : Form
    {
        public static Player_Class player;

        public static List<Player_Class> playerList = new List<Player_Class>();

        drwhoSound_Player SoundPlayer = new drwhoSound_Player();
        public Main_Menu_Form(Player_Class classPlayer,drwhoSound_Player soundPlay_)
        {
            InitializeComponent();
            player = classPlayer;

            helpBTN.TabStop = false;
            logOutBTN.TabStop = false;
            screBrdBTN.TabStop = false;
            srtGameBTN.TabStop = false;

            SoundPlayer = soundPlay_;
        }

        private void logOutBTN_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure want to log out?","Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                Login_Form LogInForm = new Login_Form(SoundPlayer);
                LogInForm.Show();
                MessageBox.Show("Log out successful, Log in again soon " + player.Username + "!","Successful Log out");
            }
        }

        private void srtGameBTN_Click(object sender, EventArgs e)
        {
            this.Hide();
            GameHelp gameHelp = new GameHelp(player, SoundPlayer);
            gameHelp.Show();
            SoundPlayer.stopintroSound();
        }

        private void screBrdBTN_Click(object sender, EventArgs e)
        {
            this.Hide();
            scoreboard screbrd = new scoreboard(player,SoundPlayer);
            screbrd.Show();
        }

        private void helpBTN_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu_help_Form mmhelp = new MainMenu_help_Form(player);
            mmhelp.Show();
            SoundPlayer.stopintroSound();
        }

        private void Main_Menu_Form_Load(object sender, EventArgs e)
        {
            welcomeLBL.Text = "Welcome " + player.Username + " to the main menu!"; // shows the players name upon entering
            
            //assigns the file name to a variable
            string file = "scoreBoard.xml";

            //converts the file to objects to read from in the scoreboard
            playerList = new XmlSerialize().ConvertXmlToObjects<Player_Class>(file);
        }
    }
}
