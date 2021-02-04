using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TriviaUI
{
    public partial class TriviaModifier : Form
    {
        public string TriviaName { get; set; }
        public TriviaModifier(string collectionName)
        {
            TriviaName = collectionName;
            InitializeComponent();
        }

        private void addNewQuestionButton_Click(object sender, EventArgs e)
        {
            QuestionModifier questionModifier = new QuestionModifier(TriviaName);
            questionModifier.Show();
        }
    }
}
