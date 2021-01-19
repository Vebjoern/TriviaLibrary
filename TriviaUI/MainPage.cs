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
    public partial class MainPage : Form
    {
        public MainPage()
        {
            SQLiteController.EnsureDbExists();

            // Populate the TriviaList from DB
            InitializeComponent();

            //TriviaListBox.DataSource = TriviaList;
            //TriviaListBox.DisplayMember = nameof(TriviaModel.TriviaName);
        }

        private void AddNewTriviaButton_Click(object sender, EventArgs e)
        {
            SQLiteController.CreateNewTrivia("Geography");
            // TODO - Implement user input for name



        }
    }
}
