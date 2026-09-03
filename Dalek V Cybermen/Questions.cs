using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dalek_V_Cybermen
{
    public partial class Questions : Form
    {

        //quiz game variables

        int correctAnswer;
        int questionNumber = 1;
        int score;
        int percentage;
        int totalQuestions;
        public Questions()
        {
            InitializeComponent();

            askQuestion(questionNumber);

            totalQuestions = 8;
        }

        //all 4 buttons linked to event
        private void CheckAnsEvent(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;

            int buttonTag = Convert.ToInt32(senderObject.Tag);

            if (buttonTag == correctAnswer)
            {
                score++;
            }

            if (questionNumber == totalQuestions)
            {
                //work out the percentage

                percentage = (int)Math.Round((double)(score * 100) / totalQuestions);

                MessageBox.Show(
                    "Quiz Ended!" + Environment.NewLine +
                    "You have answered " + score + " Questions correctly." + Environment.NewLine +
                    "Your total percentage is " + percentage + "%" + Environment.NewLine +
                    "Click ok to play again");

                score = 0;
                questionNumber = 0;
                askQuestion(questionNumber);
            }

            questionNumber++;
            askQuestion(questionNumber);
        }

        private void askQuestion(int qnum)
        {
            switch (qnum)
            {
                case 1:
                    //questionLBL.Text =

                    //answer1BTN.Text =
                    //answer2BTN.Text =
                    //answer3BTN.Text =
                    //answer4BTN.Text =

                    //correctAnswer =

                    break;

                case 2:
                    //questionLBL.Text =

                    //answer1BTN.Text =
                    //answer2BTN.Text =
                    //answer3BTN.Text =
                    //answer4BTN.Text =

                    //correctAnswer =

                    break;
                case 3:
                    //questionLBL.Text =

                    //answer1BTN.Text =
                    //answer2BTN.Text =
                    //answer3BTN.Text =
                    //answer4BTN.Text =

                    //correctAnswer =

                    break;

                case 4:
                    //questionLBL.Text =

                    //answer1BTN.Text =
                    //answer2BTN.Text =
                    //answer3BTN.Text =
                    //answer4BTN.Text =

                    //correctAnswer =

                    break;

                case 5:
                    //questionLBL.Text =

                    //answer1BTN.Text =
                    //answer2BTN.Text =
                    //answer3BTN.Text =
                    //answer4BTN.Text =

                    //correctAnswer =

                    break;

                case 6:
                    //questionLBL.Text =

                    //answer1BTN.Text =
                    //answer2BTN.Text =
                    //answer3BTN.Text =
                    //answer4BTN.Text =

                    //correctAnswer =

                    break;

                case 7:
                    //questionLBL.Text =

                    //answer1BTN.Text =
                    //answer2BTN.Text =
                    //answer3BTN.Text =
                    //answer4BTN.Text =

                    //correctAnswer = 

                    break;

                case 8:
                    //questionLBL.Text = 

                    //answer1BTN.Text = 
                    //answer2BTN.Text = 
                    //answer3BTN.Text = 
                    //answer4BTN.Text =

                    //correctAnswer =

                    break;
            }
        }
    }
}
