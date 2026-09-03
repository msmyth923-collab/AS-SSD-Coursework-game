using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dalek_V_Cybermen.Questions_and_subjects
{
    public class QuizQuestion
    {
        private string _questionText;
        private string _correctAnswer;
        private string _wrongAnswer1;
        private string _wrongAnswer2;
        private string _wrongAnswer3;
        private string _subject;

        public QuizQuestion()
        {
            QuestionText = "";
            CorrectAnswer = "";
            WrongAnswer1 = "";
            WrongAnswer2 = "";
            WrongAnswer3 = "";
            Subject = "";
        }

        public string QuestionText
        {
            get { return _questionText; }
            set { _questionText = value; }
        }

        public string CorrectAnswer
        {
            get { return _correctAnswer; }
            set { _correctAnswer = value; }
        }

        public string WrongAnswer1
        {
            get { return _wrongAnswer1; }
            set { _wrongAnswer1 = value; }
        }

        public string WrongAnswer2
        {
            get { return _wrongAnswer2; }
            set { _wrongAnswer2 = value; }
        }

        public string WrongAnswer3
        {
            get { return _wrongAnswer3; }
            set { _wrongAnswer3 = value; }
        }

        public string Subject
        {
            get { return _subject; }
            set { _subject = value; }
        }
    }
}
