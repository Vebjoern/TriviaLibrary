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
    public partial class QuestionModifier : Form
    {
        public QuestionModifier()
        {
            InitializeComponent();
        }

        public bool ValidateForm()
        {
            // TODO - Implement form validation (Strings not empty, ensure solution is identical to _one_ alternative - or make solution a dropdown menu char A-D)
            return true;
        }

    }

    
}
