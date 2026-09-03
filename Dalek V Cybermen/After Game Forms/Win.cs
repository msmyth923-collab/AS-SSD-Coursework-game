using Dalek_V_Cybermen.after_login_forms;
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
using System.Xml.Serialization;

namespace Dalek_V_Cybermen.After_Game_Forms
{
    public partial class Win : Form
    {
        public static Player_Class currentPlayer;
        drwhoSound_Player soundDrPlayer = new drwhoSound_Player();

        XmlSerializer serializerObject = new XmlSerializer(typeof(Player_Class[]));
        public Win(Player_Class player, drwhoSound_Player soundPlayerrr)
        {
            InitializeComponent();
            currentPlayer = player;
            soundDrPlayer = soundPlayerrr;
        }

        private void Win_Load(object sender, EventArgs e)
        {
            loadingBarTimer.Enabled = true;
            

            soundDrPlayer.playVictorySound();


            bool playerExists = false;

            for (int i = 0; i < Main_Menu_Form.playerList.Count; i++)
            {
                if (Main_Menu_Form.playerList[i].Username == currentPlayer.Username && Main_Menu_Form.playerList[i].FavSubject == currentPlayer.FavSubject
                    && Main_Menu_Form.playerList[i].YearGroup == currentPlayer.YearGroup)
                {
                    // Update existing player's scores only
                    Main_Menu_Form.playerList[i].GameScore = currentPlayer.GameScore;
                    Main_Menu_Form.playerList[i].QuizScore = currentPlayer.QuizScore;
                    Main_Menu_Form.playerList[i].PlayerDif = currentPlayer.PlayerDif;
                    Main_Menu_Form.playerList[i].TotQues = currentPlayer.TotQues;
                    playerExists = true;
                    break;
                }
            }

            // Only add new player if they don't exist
            if (!playerExists)
            {
                Player_Class newPlayerClass = new Player_Class(currentPlayer.Username, currentPlayer.QuizScore, currentPlayer.GameScore, currentPlayer.FavSubject, currentPlayer.TotQues, currentPlayer.YearGroup, currentPlayer.PlayerDif);
                Main_Menu_Form.playerList.Add(newPlayerClass);
            }


            Player_Class[] playerArray = Main_Menu_Form.playerList.ToArray();

            try
            {
                using (StreamWriter writer = new StreamWriter("scoreBoard.xml"))
                {
                    serializerObject.Serialize(writer, playerArray);

                    writer.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while saving player data: " + ex.Message);
            }

           
        }

        private void loadingBarTimer_Tick(object sender, EventArgs e)
        {
            loadingBarProBar.Increment(1);

            if (loadingBarProBar.Value == 100)
            {
                loadingBarTimer.Enabled = false;
                
                soundDrPlayer.stopintroSound();

                
                scoreboard scoreBoardForm = new scoreboard(currentPlayer, soundDrPlayer);
                this.Hide();
                scoreBoardForm.Show();
        
            }
        }
    }
}
