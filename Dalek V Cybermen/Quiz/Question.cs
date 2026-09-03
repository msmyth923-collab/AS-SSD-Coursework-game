using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Dalek_V_Cybermen
{
    public class Question
    {
        private string _difficulty;
        private string _subject;
        private string _question;
        private string _correctAnswer;
        private string[] _options;

        public bool isMaths => Subject == "Maths";
        public Question(string difficulty, string subject,
            string question, string answer, string[] options)
        {
            Difficulty = difficulty;
            Subject = subject;
            TextQues = question;
            CorrectAns = answer;
            Options = options;
        }

        public Question(string fileLine)
        {
            string[] parts = fileLine.Split('~');

            Difficulty = parts[0];
            Subject = parts[1];
            TextQues = parts[2];
            CorrectAns = parts[3];

            Options = new string[]
            {
                parts[3],
                parts[4],
                parts[5],
                parts[6]
            };
        }

        public string[] GetShuffledOptions()
        {
            return Options.OrderBy(x => Guid.NewGuid()).ToArray();
        }
        public int GetTimerLimit()
        {
            switch (Difficulty)
            {
                case "Easy": return 30;
                case "Medium": return 20;
                case "Hard": return 10;
                default: return 20;
            }
        }

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
        public string TextQues
        {
            get { return _question; }
            set { _question = value; }
        }
        public string CorrectAns
        {
            get { return _correctAnswer; }
            set { _correctAnswer = value; }
        }
        public string[] Options
        {
            get { return _options; }
            set { _options = value; }
        }
    }
}
