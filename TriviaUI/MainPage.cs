﻿using System;
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
        private List<TriviaModel> Trivias = new List<TriviaModel>();
        //private List<QuestionModel> Questions = new List<QuestionModel>();

        public MainPage()
        {
            SQLiteController.EnsureDbExists();
            Trivias = SQLiteController.GetTrivias();

            InitializeComponent();

            TriviaListBox.DataSource = Trivias;
            TriviaListBox.DisplayMember = "TriviaName";
        }

        private void addNewTriviaButton_Click(object sender, EventArgs e)
        {
            string collectionName = addNewTriviaTextbox.Text;
            SQLiteController.CreateNewTrivia(collectionName);

            Trivias = SQLiteController.GetTrivias();
            TriviaListBox.DataSource = null;
            TriviaListBox.DataSource = Trivias;
            TriviaListBox.DisplayMember = "TriviaName";
            //TODO - find a proper solution for refreshing the listbox
        }

        private bool ValidateNewTriviaForm(string input)
        {
            //TODO - Add validation
            return true;
        }
    }
}
