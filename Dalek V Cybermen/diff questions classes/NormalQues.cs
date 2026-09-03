using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Dalek_V_Cybermen.diff_questions_classes
{
    public class NormalQues
    {
        private int _noOfQuestions;
        private string _setDifficulty;
        private int _timeSet;

        public NormalQues()
        {
            NoOfQuestions = 0;
            SetDifficulty = null;
            TimeSet = 0;
        }

        public int NoOfQuestions
        {
            get { return _noOfQuestions; }
            set { _noOfQuestions = value; }
        }

        public string SetDifficulty
        {
            get { return _setDifficulty; }
            set { _setDifficulty = value; }
        }

        public int TimeSet
        {
            get { return _timeSet; }
            set { _timeSet = value; }
        }


        public virtual int SetNoOfQues()
        {
            NoOfQuestions = 10;
            return NoOfQuestions;
        }

        public virtual string setDifficulty()
        {
            SetDifficulty = "Normal";
            return SetDifficulty;
        }

        public virtual int setTimerSet()
        {
            TimeSet = 60;
            return TimeSet;
        }
    }
}
