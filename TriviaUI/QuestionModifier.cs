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
    public partial class QuestionModifier : Form
    {
        public string TriviaName { get; set; }
        readonly char[] solutionList = { 'A', 'B', 'C', 'D' };
        

        public QuestionModifier(string collectionName)
        {
            TriviaName = collectionName;
            InitializeComponent();
        }

        public bool ValidateForm()
        {
            // TODO - Implement form validation (Strings not empty, no alternatives identical)
            return true;
        }

        private void ConfirmationButton_Click(object sender, EventArgs e)
        {

            if (ValidateForm())
            {
                QuestionModel question = new QuestionModel(questionTextBox.Text, alternativeATextBox.Text, alternativeBTextBox.Text, alternativeCTextBox.Text, alternativeDTextBox.Text, solutionComboBox.Text);

                SQLiteController.AddQuestion(TriviaName, question);
            }

        }
    }

    
}
