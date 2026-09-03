using Dalek_V_Cybermen.After_Game_Forms;
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
    public partial class TheGameQuiz : Form
    {
        private static Player_Class player;

        private EasyQues QuesEasyMode;
        private NormalQues QuesNormalMode;
        private HardQues QuesHardMode;

        private object[] Difficulty;
        private object[] QuestionDifficulty;

        private List<quizClass> allQuestions = new List<quizClass>();
        private quizClass currentQuestion;

        drwhoSound_Player soundmeplay = new drwhoSound_Player();


        string questionType;
        int totalQuestions;
        int timeLeft;
        int setTime;
        int livesLeft;
        int total;

        public TheGameQuiz(drwhoSound_Player drwho,object[] selectedDifficulties, Player_Class playerClass, object[] DifficultySelectedQuestions, int lives)
        {
            InitializeComponent();

            //ShuffleButtons();
            Cursor.Show();
            livesLeft = lives;
            player = playerClass;
            Difficulty = selectedDifficulties;
            QuestionDifficulty = DifficultySelectedQuestions;

            soundmeplay = drwho;

            questionTimer.Interval = 1000;

            //sets the difficulties variables
            foreach (var questionDifficulty in DifficultySelectedQuestions)
            {
                if (questionDifficulty is EasyQues)
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

            }

            DisplayNextQuestion();

            answer1BTN.TabStop = false;
            answer2BTN.TabStop = false;
            answer3BTN.TabStop = false;
            answer4BTN.TabStop = false;
            mathsAnswerBTN.TabStop = false;
        }

        private void LoadQuestionsFromFile(string filePath)
        {
            if (!File.Exists(filePath))
            {
                MessageBox.Show("Question file not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //displays a picture of the players chosen subject
            if (player.FavSubject == "Maths")
            {
                subjectPB.Image = Properties.Resources.Maths;
            }
            else if (player.FavSubject == "History")
            {
                subjectPB.Image = Properties.Resources.History;
            }
            else if (player.FavSubject == "Science")
            {
                subjectPB.Image = Properties.Resources.Science;
            }
            else if (player.FavSubject == "Geography")
            {
                subjectPB.Image = Properties.Resources.Geography;
            }

            var lines = File.ReadAllLines(filePath);

            foreach (var line in lines)
            {
                var parts = line.Split('~');
                if (parts.Length < 5)
                    continue;


                //assigns each part to a varible
                string subject = parts[0].ToLower();
                bool isMath = parts[1].ToLower() == "yes";
                string diff = parts[2].ToLower();
                string ques = parts[3];
                string answer = parts[4];
                List<string> option = !isMath && parts.Length > 5
                                        ? parts[5].Split(',').ToList()
                                        : new List<string>();

                if (!isMath)
                {
                    instructionsLBL.Text = "please select 1 of the 4 buttons as an answer";
                }
                else
                    instructionsLBL.Text = "please enter in an answer in the text box  and click the submit button to answer";


                //setting the level of difficulty for the questions
                if (subject == player.FavSubject.ToLower())
                {
                    if (questionType.Equals("easy", StringComparison.OrdinalIgnoreCase))
                    {
                        if(diff.Equals("easy", StringComparison.OrdinalIgnoreCase))
                        {
                            allQuestions.Add(new quizClass(subject, isMath, "easy", ques, answer, option));
                        }
                    }
                    else if (questionType.Equals("normal", StringComparison.OrdinalIgnoreCase))
                    {
                        if (diff.Equals("normal", StringComparison.OrdinalIgnoreCase))
                        {
                            allQuestions.Add(new quizClass(subject, isMath, "normal", ques, answer, option));
                        }
                    }
                    else if(questionType.Equals("hard", StringComparison.OrdinalIgnoreCase))
                    {
                        if (diff.Equals("hard", StringComparison.OrdinalIgnoreCase))
                        {
                            allQuestions.Add(new quizClass(subject, isMath, "hard", ques, answer, option));
                        }
                    }
                }
            }
        }
        private void DisplayNextQuestion()
        {
            ShuffleButtons(); //shuffles the buttons for each question

            //doesnt highlight any of the buttons which can give away the answer
            answer1BTN.TabStop = false;
            answer2BTN.TabStop = false;
            answer3BTN.TabStop = false;
            answer4BTN.TabStop = false;
            mathsAnswerBTN.TabStop = false;

            timerLBL.Text = timeLeft.ToString();

            if(total == totalQuestions)
            {
                soundmeplay.stopintroSound();

                //if the player loses

                questionTimer.Stop();
                if (livesLeft <= 0)
                {
                    MessageBox.Show("No lives left! Game Over.", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Hide();
                    Lose gameOver = new Lose(player, soundmeplay);
                    gameOver.ShowDialog();
                }

                //if the player wins
                if (livesLeft > 0)
                {
                    

                    if (player.PlayerDif.Equals("Easy") && player.GameScore == 15)
                    {
                        this.Hide();
                        Win youHaveWon = new Win(player,soundmeplay);
                        youHaveWon.Show();
                    }
                    else if (player.PlayerDif.Equals("Normal") && player.GameScore == 25)
                    {
                        this.Hide();
                        Win youHaveWon = new Win(player,soundmeplay);
                        youHaveWon.Show();
                    }
                    else if (player.PlayerDif.Equals("Hard") && player.GameScore == 40)
                    {
                        this.Hide();
                        Win youHaveWon = new Win(player, soundmeplay);
                        youHaveWon.Show();
                    }
                    else
                    {
                        this.Hide();
                        Form1 game = new Form1(soundmeplay, Difficulty, QuestionDifficulty, player, livesLeft);
                        game.ShowDialog();
                    }
                }
            }

            if(allQuestions.Count == 0)
            {
                MessageBox.Show("No more questions available.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Random rand = new Random();
            int index = rand.Next(allQuestions.Count);

            //randomly cycles through questions
            currentQuestion = allQuestions[index];
            allQuestions.RemoveAt(index);

            questionLBL.Text = currentQuestion.QuestionText;

            if(!currentQuestion.IsMath && currentQuestion.Options.Count == 4)
            {
                answer1BTN.Text = currentQuestion.Options[0];
                answer2BTN.Text = currentQuestion.Options[1];
                answer3BTN.Text = currentQuestion.Options[2];
                answer4BTN.Text = currentQuestion.Options[3];

                answer1BTN.Visible = true;
                answer2BTN.Visible = true;
                answer3BTN.Visible = true;
                answer4BTN.Visible = true;
                mathsAnswerBTN.Visible = false;
                mathsAnswerTB.Visible = false;
            }
            else
            {
                answer1BTN.Visible = false;
                answer2BTN.Visible = false;
                answer3BTN.Visible = false;
                answer4BTN.Visible = false;
                mathsAnswerBTN.Visible = true;
                mathsAnswerTB.Visible = true;
            }
        }

        private void CheckAnswer(string userAnswer)
        {
            bool isCorrect = userAnswer.Trim().Equals(currentQuestion.Answer, StringComparison.OrdinalIgnoreCase);

            player.TotQues++;
            total++;

            if (isCorrect)
            {
                //adds 1 to the quiz score if the user got the correct answer
                player.QuizScore++;
            }

            
            DisplayNextQuestion();
        }



        private void questionTimer_Tick(object sender, EventArgs e)
        {
            timeLeft--;
            timerLBL.Text = timeLeft.ToString();
            if (timeLeft <= 0 && livesLeft > 0)
            {
                questionTimer.Stop();
                MessageBox.Show("Time's up!");
                this.Hide();
                Form1 game = new Form1(soundmeplay,Difficulty, QuestionDifficulty, player);
                game.ShowDialog();
            }
            else if (timeLeft == 0 && livesLeft <= 0) 
            {
                soundmeplay.stopintroSound();
                questionTimer.Stop();
                MessageBox.Show("No lives left! Game Over.", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                Lose gameOver = new Lose(player, soundmeplay);
                gameOver.ShowDialog();
            }
        }

        //checks if the answer typed in the text box for maths questions is correct
        private void mathsAnswerBTN_Click(object sender, EventArgs e)
        {
            CheckAnswer(mathsAnswerTB.Text);
            mathsAnswerTB.Clear();

            if (currentQuestion != null)
            {
                bool isCorrect = false;
                if (currentQuestion.IsMath)
                {
                    Button clickedButton = this.Controls.OfType<Button>().FirstOrDefault(b => b.Focused);
                    if (clickedButton != null && clickedButton.Text == currentQuestion.Answer)
                    {
                        isCorrect = true;
                    }
                }
                else
                {
                    isCorrect = (mathsAnswerTB.Text.Trim() == currentQuestion.Answer);
                }
            }
        }

        //4 buttons linked to the 1 event fro the multiple choice questions
        private void ClickButtonEvent(object sender, EventArgs e)
        {
            if (sender is Button clickedButton)
            {
                CheckAnswer(clickedButton.Text);
            }
        }

        private void ShuffleButtons()
        {
            answer1BTN.TabStop = false;
            answer2BTN.TabStop = false;
            answer3BTN.TabStop = false;
            answer4BTN.TabStop = false;
            mathsAnswerBTN.TabStop = false;

            //records the positions of the buttons
            List<Point> positions = new List<Point>
            {
                answer1BTN.Location,
                answer2BTN.Location,
                answer3BTN.Location,
                answer4BTN.Location
            };

            Random rand = new Random();
            for (int i = 0; i < positions.Count; i++)
            {
                int j = rand.Next(i);
                Point temp = positions[i];
                positions[i] = positions[j];
                positions[j] = temp;
            }

            //gives the buttons new locations
            answer1BTN.Location = positions[0];
            answer2BTN.Location = positions[1];
            answer3BTN.Location = positions[2];
            answer4BTN.Location = positions[3];
        }

    }
}
