using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dalek_V_Cybermen
{
    public class EnsureDifficultySelectedException : Exception
    {
        //custom message to by used for the exception message
        private static string errorMessage = "difficulty not selected: {0}";

        public EnsureDifficultySelectedException(string message) : base(string.Format(errorMessage, message)) { }
    }
}
