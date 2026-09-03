using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Dalek_V_Cybermen.Questions_and_subjects
{
    public class History : Question
    {
        public override List<Question> getQuestions()
        {
            return new List<Question>()
            {
                new Question("Who was the first President of the USA?", "George Washington"),
                new Question("In what year did WW2 end?", "1945"),
                new Question("Which empire built the pyramids?", "The Egyptians"),
                new Question("Who wrote the Declaration of Independence?", "Thomas Jefferson"),
                new Question("What wall fell in 1989?", "The Berlin Wall"),
                new Question("Who was known as the Maid of Orléans?", "Joan of Arc")

            };
        }
    }
}
