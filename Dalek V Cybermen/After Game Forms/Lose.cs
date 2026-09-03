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
    public partial class Lose : Form
    {
        public static Player_Class currentPlayer;

        drwhoSound_Player soundDrPlayer = new drwhoSound_Player();

        XmlSerializer serializerObject = new XmlSerializer(typeof(Player_Class[]));

        public Lose(Player_Class player, drwhoSound_Player SoundDrPlayer)
        {
            InitializeComponent();
            currentPlayer = player;
            soundDrPlayer = SoundDrPlayer;
        }

        private void Lose_Load(object sender, EventArgs e)
        {
            loadingBarTimer.Enabled = true;
            
            soundDrPlayer.playDefeatSound();

            

            bool playerExists = false;
            for (int i = 0; i<Main_Menu_Form.playerList.Count; i++)
            {
                //if the players details have been saved before then onlt the 2 scores difficulty and number of questions will be replaced
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

            //===============================Serialization of the list===============================
            Player_Class[] playerArray = Main_Menu_Form.playerList.ToArray();

            try
            {
                //writes the data to the file to be read
                using (StreamWriter writer = new StreamWriter("scoreBoard.xml"))
                {
                    serializerObject.Serialize(writer, playerArray);

                    writer.Close();
                }

                //MessageBox.Show("Player data saved successfully.");
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
                this.Hide();
                
                scoreboard scoreBoardForm = new scoreboard(currentPlayer, soundDrPlayer);
                scoreBoardForm.Show();
                soundDrPlayer.stopintroSound();
            }
        }
    }
}
