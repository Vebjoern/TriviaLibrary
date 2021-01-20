using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriviaLibrary
{
    public class TriviaModel
    {
        public List<QuestionModel> QuestionList { get; set; } = new List<QuestionModel>();
        public string TriviaName { get; set; }

        public TriviaModel(string name)
        {
            this.TriviaName = name;
        }
    }
}
