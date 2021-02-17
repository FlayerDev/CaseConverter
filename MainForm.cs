using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaseConverter
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void UpperCaseButton_Click(object sender, EventArgs e)
        {
            string textBuffer = string.Empty;
            foreach (char item in MainTextBox.Text)
            {
                textBuffer += char.ToUpper(item);
            }
            MainTextBox.Text = textBuffer;
        }

        private void LowerCaseButton_Click(object sender, EventArgs e)
        {
            string textBuffer = string.Empty;
            foreach (char item in MainTextBox.Text)
            {
                textBuffer += char.ToLower(item);
            }
            MainTextBox.Text = textBuffer;
        }

        private void CapitalizedCase_Click(object sender, EventArgs e)
        {

        }

        private void InverseCase_Click(object sender, EventArgs e)
        {

        }

        private void TitleCase_Click(object sender, EventArgs e)
        {

        }

        private void AlternatingCase_Click(object sender, EventArgs e)
        {

        }
    }
}
