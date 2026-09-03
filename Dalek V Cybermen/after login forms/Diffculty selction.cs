using Dalek_V_Cybermen.diff_questions_classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dalek_V_Cybermen
{
    public partial class Diffculty_selction : Form
    {
        public static Easy easyMode;
        public static Normal normalMode;
        public static Hard hardMode;


        public static Player_Class playerCurrent;

        public static EasyQues QuesEasy;
        public static NormalQues QuesNormal;
        public static HardQues QuesHard;

        drwhoSound_Player drwhoSound_Playerrrr = new drwhoSound_Player();

        public Diffculty_selction(Player_Class currentPlayer, drwhoSound_Player soundMePlay)
        {
            InitializeComponent();
            startBTN.Enabled = false;
            playerCurrent = currentPlayer;
            easyBTN.TabStop = false;
            normalBTN.TabStop = false;
            hardBTN.TabStop = false;
            startBTN.TabStop = false;

            drwhoSound_Playerrrr = soundMePlay;

        }
        

        private void easyBTN_Click(object sender, EventArgs e)
        {
            //disables the button that has been clicked and enables the other 2
            easyBTN.Enabled = false;
            normalBTN.Enabled = true;
            hardBTN.Enabled = true;


            //set normal mode and question to null so only easy will be used
            normalMode = null;
            QuesNormal = null;

            //set hard mode and question to null so only easy will be used
            hardMode = null;
            QuesHard = null;

            //assign new object to declare reference type variable
            easyMode = new Easy(); // object created from derived
            QuesEasy = new EasyQues();

            //calling override methods from derived class to assign lives and amount of enemies
            easyMode.setLives();
            easyMode.setEnemies();

            //caling override methods from derived class to assign number of questions, timer and difficulty
            QuesEasy.SetNoOfQues();
            QuesEasy.setTimerSet();
            QuesEasy.setDifficulty();

            DialogResult result = MessageBox.Show("The number of lives are: " + easyMode.Lives
                + "\nThe amount of enemies are: " + easyMode.Enemies + "\nThe time given for the questions are: " + QuesEasy.TimeSet
                + "\nThe amount of questions are: " + QuesEasy.NoOfQuestions, "Ready to Game?",MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                //button will be enabled if the user has confirmed they want to play on easy mode
                startBTN.Enabled = true;
            }
            else if (result == DialogResult.No)
            {
                easyBTN.Enabled = true;
                easyMode = null;
                QuesEasy = null;
            }
        }

        private void normalBTN_Click(object sender, EventArgs e)
        {
            //disables the button that has been clicked and enables the other 2
            easyBTN.Enabled = true;
            normalBTN.Enabled = false;
            hardBTN.Enabled = true;

            //set easy mode and question to null so only normal will be used
            easyMode = null;
            QuesEasy = null;

            hardMode = null;
            QuesHard = null;

            //assign new object to declare reference type variable
            normalMode = new Normal(); //objected from base class
            QuesNormal = new NormalQues();

            //calling virtual methods from base class to assign lives and amount of enemies
            normalMode.setLives();
            normalMode.setEnemies();

            QuesNormal.SetNoOfQues();
            QuesNormal.setTimerSet();
            QuesNormal.setDifficulty();

            DialogResult result = MessageBox.Show("The number of lives are: " + normalMode.Lives
                + "\nThe amount of enemies are: " + normalMode.Enemies + "\nThe time given for the questions are: " + QuesNormal.TimeSet
                + "\nThe amount of questions are: " + QuesNormal.NoOfQuestions, "Ready to Game?", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                startBTN.Enabled = true;
            }
            else if (result == DialogResult.No)
            {
                normalBTN.Enabled = true;
                normalMode = null;
                QuesNormal = null;
            }
        }

        private void hardBTN_Click(object sender, EventArgs e)
        {
            easyBTN.Enabled = true;
            normalBTN.Enabled = true;
            hardBTN.Enabled = false;

            easyMode = null;
            QuesEasy = null;

            normalMode = null;
            QuesNormal = null;

            //assign new object to declare reference type variable
            hardMode = new Hard(); //object created from derived class
            QuesHard = new HardQues();

            //calling override methods from derived class to assign lives and amount of enemies
            hardMode.setLives();
            hardMode.setEnemies();

            QuesHard.SetNoOfQues();
            QuesHard.setTimerSet();
            QuesHard.setDifficulty();

            DialogResult result = MessageBox.Show("The number of lives are: " + hardMode.Lives
                + "\nThe amount of enemies are: " + hardMode.Enemies + "\nThe time given for the questions are: " + QuesHard.TimeSet
                + "\nThe amount of questions are: " + QuesHard.NoOfQuestions, "Ready to Game?", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                startBTN.Enabled = true;
            }
            else if (result == DialogResult.No)
            {
                hardBTN.Enabled = true;
                hardMode = null;
                QuesHard = null;
            }
        }

        private void startBTN_Click(object sender, EventArgs e)
        {
            if (!easyBTN.Enabled || !normalBTN.Enabled || !hardBTN.Enabled )
            {

                //if the one of the difficulty is disabled then it will check if any of the difficulty classes are null
                try
                {
                    if (easyMode == null && normalMode == null && hardMode == null)
                        throw new EnsureDifficultySelectedException("Please select a game difficulty (Easy, Medium, or Hard).");

                    if (QuesEasy == null && QuesNormal == null && QuesHard == null)
                        throw new EnsureDifficultySelectedException("Please select a quiz difficulty (Easy, Medium, or Hard).");

                    if (easyMode == null && normalMode == null && hardMode == null && QuesEasy == null && QuesNormal == null && QuesHard == null)
                        throw new EnsureDifficultySelectedException("Please select a difficulty for the questions and game");

                    List<object> selectedDifficulties = new List<object>();
                    List<object> selectedDifficultiesQuestions = new List<object>();

                    //assigns the game difficulty to a list
                    if (easyMode != null) selectedDifficulties.Add(easyMode);
                    if (normalMode != null) selectedDifficulties.Add(normalMode);
                    if (hardMode != null) selectedDifficulties.Add(hardMode);

                    //assigns the quiz diffiuclty to a list
                    if (QuesEasy != null) selectedDifficultiesQuestions.Add(QuesEasy);
                    if (QuesNormal != null) selectedDifficultiesQuestions.Add(QuesNormal);
                    if (QuesHard != null) selectedDifficultiesQuestions.Add(QuesHard);


                    playerCurrent.PlayerDif = selectedDifficultiesQuestions[0] is EasyQues ? "Easy" :
                                                  selectedDifficultiesQuestions[0] is HardQues ? "Hard" : "Normal";

                    this.Hide();
                    Form1 Game = new Form1(drwhoSound_Playerrrr,selectedDifficulties.ToArray(), selectedDifficultiesQuestions.ToArray(), playerCurrent);
                    Game.Show();
                    
                }
                catch (EnsureDifficultySelectedException ex)
                {
                    DialogResult result = MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                }
            }
        }
    }
}
