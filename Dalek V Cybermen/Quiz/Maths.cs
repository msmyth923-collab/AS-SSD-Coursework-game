using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dalek_V_Cybermen.Questions_and_subjects
{
    public class Maths : Question
    {
        public override List<Question> getQuestions()
        {
            return new List<Question>()
            {
                new Question("What is 9 × 7?", "63"),
                new Question("What is 144 ÷ 12?", "12"),
                new Question("What is the square root of 49?", "7"),
                new Question("What is 15% of 200?", "30"),
                new Question("What is 2³?", "8"),
                new Question("Solve: 5x = 45", "9")


            };
        }
    }
}
