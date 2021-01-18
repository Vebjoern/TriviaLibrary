using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriviaLibrary
{
    public class QuestionModel
    {
        public string Question { get; set; }
        public string AlternativeA { get; set; }
        public string AlternativeB { get; set; }
        public string AlternativeC { get; set; }
        public string AlternativeD { get; set; }
        public char Solution { get; set; }
    }
}
