using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Dalek_V_Cybermen.Questions_and_subjects
{
    public class quizClass
    {
        private string _subject;
        private string _difficulty;
        private string _questionText;
        private string _answer;
        private List<string> _options;
        private bool _isMath; //boolean to see if the subject is maths


        //form comstructor
        public quizClass(string subject, bool isMath, string difficulty, string questionText, string answer, List<string> options)
        {
            Difficulty = difficulty;
            Subject = subject;
            QuestionText = questionText;
            Answer = answer;
            Options = options ?? new List<string>();
            IsMath = isMath;
        }

        //getters and setters
        public string Difficulty
        {
            get { return _difficulty; }
            set { _difficulty = value; }
        }

        public string Subject
        {
            get { return _subject; }
            set { _subject = value; }
        }

        public string QuestionText
        {
            get { return _questionText; }
            set { _questionText = value; }
        }

        public string Answer
        {
            get { return _answer; }
            set { _answer = value; }
        }

        public bool IsMath
        {
            get { return _isMath; }
            set { _isMath = value; }
        }

        public List<string> Options
        {
            get { return _options; }
            set { _options = value ?? new List<string>(); }
        }


    }
}
