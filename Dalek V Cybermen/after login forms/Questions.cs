using Dalek_V_Cybermen.diff_questions_classes;
using Dalek_V_Cybermen.Questions_and_subjects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace Dalek_V_Cybermen
{
    public partial class Questions : Form
    {
        private Player_Class player;

        private EasyQues QuesEasyMode;
        private NormalQues QuesNormalMode;
        private HardQues QuesHardMode;

        private object[] Difficulty;
        private object[] QuestionDifficulty;

        private List<quizClass> allQuestions = new List<quizClass>();


        private string questionType;
        private int totalQuestions;
        private int timeLeft;
        private int setTime;
        int total;

        Random random = new Random();

        public Questions(object[] selectedDifficulties, Player_Class playerClass, object[] DifficultySelectedQuestions)
        {
            InitializeComponent(); 
            Cursor.Show();
            player = playerClass;
            Difficulty = selectedDifficulties;
            QuestionDifficulty = DifficultySelectedQuestions;

            questionTimer.Interval = 1000;

            answer1BTN.Click += AnswerButtonEvent;
            answer2BTN.Click += AnswerButtonEvent;
            answer3BTN.Click += AnswerButtonEvent;
            answer4BTN.Click += AnswerButtonEvent;

            foreach(var questionDifficulty in DifficultySelectedQuestions)
            {
                if(questionDifficulty is EasyQues)
                {
                    this.QuesEasyMode = (EasyQues)questionDifficulty;
                    totalQuestions = QuesEasyMode.SetNoOfQues();
                    questionType = QuesEasyMode.setDifficulty();
                    setTime = QuesEasyMode.setTimerSet();
                }
                else if (questionDifficulty is NormalQues)
                {
                    this.QuesNormalMode = (NormalQues)questionDifficulty;
                    totalQuestions = QuesNormalMode.SetNoOfQues();
                    questionType = QuesNormalMode.setDifficulty();
                    setTime = QuesNormalMode.setTimerSet();
                }
                else if (questionDifficulty is HardQues)
                {
                    this.QuesHardMode = (HardQues)questionDifficulty;
                    totalQuestions = QuesHardMode.SetNoOfQues();
                    questionType = QuesHardMode.setDifficulty();
                    setTime = QuesHardMode.setTimerSet();
                }

                questionTimer.Start();
                timeLeft = setTime;

            }
            LoadQuestionsFromFile("questionsComplete.txt");

            if (allQuestions.Count == 0)
            {
                MessageBox.Show("No questions available for the selected subject and difficulty.",
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                this.Close();
                return;
            }

            DisplayNextQuestion();
        }

        private void LoadQuestionsFromFile(string filePath)
        {
            if (!File.Exists(filePath))
            {
                MessageBox.Show("Question file not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var lines = File.ReadAllLines(filePath);
            foreach (var line in lines)
            {
                var parts = line.Split('~');
                if (parts.Length > 6)
                    continue;

                string diff = parts[0].ToLower();
                bool isMath = parts[1].ToLower() == "yes";
                string subject = parts[2].ToLower();
                string ques = parts[3];
                string answer = parts[4];
                List<string> option = !isMath && parts.Length >6
                                        ? parts[5].Split(',').ToList()
                                        : new List<string>();

                if(subject == player.FavSubject.ToLower())
                {
                    if (questionType.Equals("easy", StringComparison.OrdinalIgnoreCase))
                    {
                        if(diff.Equals("easy", StringComparison.OrdinalIgnoreCase))
                        {
                            allQuestions.Add(new quizClass("easy",isMath,subject,ques,answer,option))
                        }
                    }
                }
            }
        }
        private void AnswerButtonEvent(object sender, EventArgs e)
        {
            
        }

        private void mathsAnswerBTN_Click(object sender, EventArgs e)
        {
            
        }

        private void questionTimer_Tick(object sender, EventArgs e)
        {
            
        }

    }
}
