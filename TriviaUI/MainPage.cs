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
//using LiteDB;

namespace TriviaUI
{
    public partial class MainPage : Form
    {
        BindingList<TriviaModel> TriviaList;
        public MainPage()
        {
            //using (var db = new LiteDatabase(@".\TriviaCollections.db"))

            // Populate the TriviaList from DB
            InitializeComponent();

            TriviaListBox.DataSource = TriviaList;
            TriviaListBox.DisplayMember = nameof(TriviaModel.TriviaName);
        }

    }
}
