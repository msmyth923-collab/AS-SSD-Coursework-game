using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dalek_V_Cybermen.Questions_and_subjects
{
    public class Science : Question
    {
        public override List<Question> getQuestions()
        {
            return new List<Question>()
            {
                new Question("What gas do plants release during photosynthesis?", "Oxygen"),
                new Question("What planet is closest to the Sun?", "Mercury"),
                new Question("What force keeps us on the ground?", "Gravity"),
                new Question("What is the chemical symbol for water?", "H2O"),
                new Question("What part of the cell contains DNA?", "The nucleus"),
                new Question("What gas do humans exhale?", "Carbon dioxide")

            };
        }
    }
}
