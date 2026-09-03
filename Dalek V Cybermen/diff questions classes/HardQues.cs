using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dalek_V_Cybermen.diff_questions_classes
{
    public class HardQues : NormalQues
    {
        public HardQues() : base() { }

        public override int SetNoOfQues()
        {
            NoOfQuestions = 15;
            return NoOfQuestions;
        }

        public override string setDifficulty()
        {
            SetDifficulty = "Hard";
            return SetDifficulty;
        }

        public override int setTimerSet()
        {
            TimeSet = 90;
            return TimeSet;
        }
    }
}
