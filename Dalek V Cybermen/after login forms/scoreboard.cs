 using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dalek_V_Cybermen.after_login_forms
{
    public partial class scoreboard : Form
    {
        public static Player_Class player;
        drwhoSound_Player sound_Player = new drwhoSound_Player();
        string searchColumn = "";

        List<Player_Class> currentList = new List<Player_Class>();

        public scoreboard(Player_Class currentPlayer, drwhoSound_Player playSound)
        {
            InitializeComponent();
            player = currentPlayer;
            viewAllBTN.Enabled = false;
            sound_Player = playSound;

            usernameBTN.Enabled = false;
            yrBTN.Enabled = false;
            subjectBTN.Enabled = false;
            gameScoreBTN.Enabled = false;
            quizScoreBTN.Enabled = false;
        }

        private void scoreboard_Load(object sender, EventArgs e)
        {
            //orders the score board from highest game score to slowest gamescore
            //List<Player_Class> playerList = Main_Menu_Form.playerList.OrderBy(o => o.GameScore).ToList();
            currentList = Main_Menu_Form.playerList.OrderBy(o => o.GameScore).ToList();
            scoreBoardDGV.DataSource = currentList; //displays the list of saved player scores

            searchTB.Text = "Enter in data";
            searchTB.ForeColor = Color.Gray;
        }


        private void ApplySearch()
        {
            string query = searchTB.Text.Trim().ToLower();

            if(string.IsNullOrEmpty(query) || string.IsNullOrEmpty(searchColumn))
            {
                scoreBoardDGV.DataSource = new List<Player_Class>(currentList);
                return;
            }

            List<Player_Class> results;

            switch (searchColumn)
            {
                case "Username":
                    results = currentList
                    .Where(p => p.Username != null &&
                    p.Username.ToLower().Contains(query))
                    .ToList();
                    break;

                case "Year":
                    results = currentList
                    .Where(p => p.YearGroup != null &&
                    p.YearGroup.ToLower().Contains(query))
                    .ToList();
                    break;

                case "Subject":
                    results = currentList
                    .Where(p => p.FavSubject != null &&
                    p.FavSubject.ToLower().Contains(query))
                    .ToList();
                    break;

                case "Game Score":
                    results = currentList
                    .Where(p => player.GameScore.ToString().Contains(query))
                    .ToList();
                    break;

                case "Quiz Score":
                    results = currentList
                    .Where(p => player.QuizScore.ToString().Contains(query))
                    .ToList();
                    break;


                default:
                    results = new List<Player_Class>(currentList);
                    break;
            }

            scoreBoardDGV.DataSource = results;
        }




        private void mainMenuBTN_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main_Menu_Form mmf = new Main_Menu_Form(player,sound_Player);
            mmf.ShowDialog();
        }

        private void viewEasyModeBTN_Click(object sender, EventArgs e)
        {
            //the column will be removed if it is currently in the data grid view
            if (scoreBoardDGV.Columns.Contains("Rank"))
                scoreBoardDGV.Columns.Remove("Rank");

            viewEasyModeBTN.Enabled = false;
            viewNormalModeBTN.Enabled = true;
            viewHardModeBTN.Enabled = true;
            viewAllBTN.Enabled = true;
            leaderboardBTN.Enabled = true;

            //creates a new list of type player_class
            List<Player_Class> filteredEasyList = new List<Player_Class>();

            for (int i = 0; i < Main_Menu_Form.playerList.Count; i++)
            {
                if (Main_Menu_Form.playerList[i].PlayerDif == "Easy")
                {
                    filteredEasyList.Add(Main_Menu_Form.playerList[i]);
                }
            }


            //only shows the easy mode player scores
            List<Player_Class> sortedList = filteredEasyList.OrderBy(o => o.GameScore).ToList();
            scoreBoardDGV.DataSource = sortedList;
        }

        private void viewNormalModeBTN_Click(object sender, EventArgs e)
        {
            if (scoreBoardDGV.Columns.Contains("Rank"))
                scoreBoardDGV.Columns.Remove("Rank");

            viewEasyModeBTN.Enabled = true;
            viewNormalModeBTN.Enabled = false;
            viewHardModeBTN.Enabled = true;
            viewAllBTN.Enabled = true;
            leaderboardBTN.Enabled = true;

            List<Player_Class> filteredNormalList = new List<Player_Class>();

            for (int i = 0; i < Main_Menu_Form.playerList.Count; i++)
            {
                if (Main_Menu_Form.playerList[i].PlayerDif == "Normal")
                {
                    filteredNormalList.Add(Main_Menu_Form.playerList[i]);
                }
            }
            //only shows the normal mode player scores
            List<Player_Class> sortedList = filteredNormalList.OrderBy(o => o.GameScore).ToList();
            scoreBoardDGV.DataSource = sortedList;
        }

        private void viewHardModeBTN_Click(object sender, EventArgs e)
        {
            if (scoreBoardDGV.Columns.Contains("Rank"))
                scoreBoardDGV.Columns.Remove("Rank");

            viewEasyModeBTN.Enabled = true;
            viewNormalModeBTN.Enabled = true;
            viewHardModeBTN.Enabled = false;
            viewAllBTN.Enabled = true;
            leaderboardBTN.Enabled = true;

            List<Player_Class> filteredHardList = new List<Player_Class>();

            for (int i = 0; i < Main_Menu_Form.playerList.Count; i++)
            {
                if (Main_Menu_Form.playerList[i].PlayerDif == "Hard")
                {
                    filteredHardList.Add(Main_Menu_Form.playerList[i]);
                }
            }

            //only shows the hard mode player scores
            List<Player_Class> sortedList = filteredHardList.OrderBy(o => o.GameScore).ToList();
            scoreBoardDGV.DataSource = sortedList;
        }

        private void viewAllBTN_Click(object sender, EventArgs e)
        {
            if (scoreBoardDGV.Columns.Contains("Rank"))
                scoreBoardDGV.Columns.Remove("Rank");

            viewEasyModeBTN.Enabled = true;
            viewNormalModeBTN.Enabled = true;
            viewHardModeBTN.Enabled = true;
            usernameBTN.Enabled = true;
            yrBTN.Enabled = true;
            subjectBTN.Enabled = true;
            gameScoreBTN.Enabled = true;
            quizScoreBTN.Enabled = true;
            viewAllBTN.Enabled = false;
            leaderboardBTN.Enabled = true;

            //shows the score for all difficulties
            List<Player_Class> sortedList = Main_Menu_Form.playerList.OrderBy(o => o.GameScore).ToList();
            scoreBoardDGV.DataSource = sortedList;
        }

        private void usernameBTN_Click(object sender, EventArgs e)
        {
            if (scoreBoardDGV.Columns.Contains("Rank"))
                scoreBoardDGV.Columns.Remove("Rank");

            searchColumn = "Username";
            usernameBTN.Enabled = false;
            yrBTN.Enabled = true;
            subjectBTN.Enabled = true;
            gameScoreBTN.Enabled = true;
            quizScoreBTN.Enabled = true;
            viewAllBTN.Enabled = true;
            leaderboardBTN.Enabled = true;
            ApplySearch();
        }

        private void yrBTN_Click(object sender, EventArgs e)
        {
            if (scoreBoardDGV.Columns.Contains("Rank"))
                scoreBoardDGV.Columns.Remove("Rank");

            searchColumn = "Year";
            usernameBTN.Enabled = true;
            yrBTN.Enabled = false;
            subjectBTN.Enabled = true;
            gameScoreBTN.Enabled = true;
            quizScoreBTN.Enabled = true;
            viewAllBTN.Enabled = true;
            leaderboardBTN.Enabled = true;
            ApplySearch();
        }

        private void subjectBTN_Click(object sender, EventArgs e)
        {
            if (scoreBoardDGV.Columns.Contains("Rank"))
                scoreBoardDGV.Columns.Remove("Rank");

            searchColumn = "Subject";
            usernameBTN.Enabled = true;
            yrBTN.Enabled = true;
            subjectBTN.Enabled = false;
            gameScoreBTN.Enabled = true;
            quizScoreBTN.Enabled = true;
            viewAllBTN.Enabled = true;
            leaderboardBTN.Enabled = true;
            ApplySearch();
        }

        private void gameScoreBTN_Click(object sender, EventArgs e)
        {
            if (scoreBoardDGV.Columns.Contains("Rank"))
                scoreBoardDGV.Columns.Remove("Rank");

            searchColumn = "Game Score";
            usernameBTN.Enabled = true;
            yrBTN.Enabled = true;
            subjectBTN.Enabled = true;
            gameScoreBTN.Enabled = false;
            quizScoreBTN.Enabled = true;
            viewAllBTN.Enabled = true;
            leaderboardBTN.Enabled = true;
            ApplySearch();
        }

        private void quizScoreBTN_Click(object sender, EventArgs e)
        {
            if (scoreBoardDGV.Columns.Contains("Rank"))
                scoreBoardDGV.Columns.Remove("Rank");

            searchColumn = "Quiz Score";
            usernameBTN.Enabled = true;
            yrBTN.Enabled = true;
            subjectBTN.Enabled = true;
            gameScoreBTN.Enabled = true;
            quizScoreBTN.Enabled = false ;
            viewAllBTN.Enabled = true;
            leaderboardBTN.Enabled = true;
            ApplySearch();
        }

        private void searchTB_TextChanged(object sender, EventArgs e)
        {
            if (scoreBoardDGV.Columns.Contains("Rank"))
                scoreBoardDGV.Columns.Remove("Rank");

            bool hasText = !string.IsNullOrWhiteSpace(searchTB.Text);
            usernameBTN.Enabled = hasText;
            yrBTN.Enabled = hasText;
            subjectBTN.Enabled = hasText;
            gameScoreBTN.Enabled = hasText;
            quizScoreBTN.Enabled = hasText;

            if (searchTB.Text == "Enter in data")
            {
                usernameBTN.Enabled = false;
                yrBTN.Enabled = false;
                subjectBTN.Enabled = false;
                gameScoreBTN.Enabled = false;
                quizScoreBTN.Enabled = false;
            }
        }

        private void leaderboardBTN_Click(object sender, EventArgs e)
        {
            leaderboardBTN.Enabled = false;
            viewAllBTN.Enabled = true;
            //ordering the list from the highest game and quiz score to the lowest
            List<Player_Class> sortedList = currentList.OrderByDescending(o => o.QuizScore).ThenByDescending(o => o.GameScore).ToList();

            
            scoreBoardDGV.DataSource = sortedList;

            if (scoreBoardDGV.Columns.Contains("Rank"))
                scoreBoardDGV.Columns.Remove("Rank");

            DataGridViewTextBoxColumn rankColumn = new DataGridViewTextBoxColumn();
            
            //assigning the column a name and a header name
            rankColumn.Name = "Rank";
            rankColumn.HeaderText = "Placement";

            //putting in the column in the existing data grid view
            scoreBoardDGV.Columns.Insert(0, rankColumn);

            //putting the values in for each row containg a user
            for (int i = 0; i < sortedList.Count; i++)
            {
                scoreBoardDGV.Rows[i].Cells["Rank"].Value = i + 1;
            }
        }

        private void searchTB_Enter(object sender, EventArgs e)
        {
            if (searchTB.Text == "Enter in data")
            {
                searchTB.Text = "";
                searchTB.ForeColor = Color.Black;
            }
        }

        private void searchTB_Leave(object sender, EventArgs e)
        {
            if (searchTB.Text == "")
            {
                searchTB.Text = "Enter in data";
                searchTB.ForeColor = Color.Gray;
            }
        }
    }
}
