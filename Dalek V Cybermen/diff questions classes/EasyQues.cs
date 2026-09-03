using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dalek_V_Cybermen.diff_questions_classes
{
    public class EasyQues : NormalQues
    {
        public EasyQues() : base() { }

        public override int SetNoOfQues()
        {
            NoOfQuestions = 5;
            return NoOfQuestions;
        }

        public override string setDifficulty()
        {
            SetDifficulty = "Easy";
            return SetDifficulty;
        }

        public override int setTimerSet()
        {
            TimeSet = 30;
            return TimeSet;
        }
    }
}
