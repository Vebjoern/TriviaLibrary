using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TriviaLibrary;

namespace TriviaUI
{
    public partial class TriviaModifier : Form
    {
        public string TriviaName { get; set; }
        public List<QuestionModel> QuestionList;
        public TriviaModifier(string collectionName)
        {
            TriviaName = collectionName;
            InitializeComponent();

            QuestionList = SQLiteController.GetQuestionsFromTrivia(SQLiteController.GetTriviaId(collectionName));
            questionListBox.DataSource = QuestionList;
            questionListBox.DisplayMember = "Question";
        }

        private void AddNewQuestionButton_Click(object sender, EventArgs e)
        {
            QuestionModifier questionModifier = new QuestionModifier(TriviaName);
            questionModifier.Show();
            this.Close();
        }
    }
}
