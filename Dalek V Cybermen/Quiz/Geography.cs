using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dalek_V_Cybermen.Questions_and_subjects
{
    public class Geography : Question
    {
        public override List<Question> getQuestions()
        {
            return new List<Question>()
            {
                new Question("What is the capital of Italy?", "Rome"),
                new Question("Which ocean is the largest?", "Pacific Ocean"),
                new Question("Which country has the city of Sydney?", "Australia"),
                new Question("What is the longest river in the world?", "The Nile"),
                new Question("Which continent is the Amazon Rainforest on?", "South America"),
                new Question("What is the largest desert on Earth?", "Antarctica")

            };
        }
    }
}
