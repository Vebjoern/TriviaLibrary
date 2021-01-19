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
        public MainPage()
        {
            SQLiteController.EnsureDbExists();

            // Populate the TriviaList from DB
            InitializeComponent();

            //TriviaListBox.DataSource = TriviaList;
            //TriviaListBox.DisplayMember = nameof(TriviaModel.TriviaName);
        }

        private void addNewTriviaButton_Click(object sender, EventArgs e)
        {
            string collectionName = addNewTriviaTextbox.Text;
            SQLiteController.CreateNewTrivia(collectionName);
            // TODO - Implement user input for name

        }

        private bool ValidateNewTriviaForm(string input)
        {
            //TODO - Add validation
            return true;
        }
    }
}
