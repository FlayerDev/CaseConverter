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
            bool capNext = true;
            string textBuffer = string.Empty;
            foreach (char item in MainTextBox.Text)
            {
                if (item == (char)32)
                {
                    capNext = true;
                    textBuffer += (char)32;
                }
                else
                {
                    if (capNext) textBuffer += char.ToUpper(item);
                    else textBuffer += char.ToLower(item);
                    capNext = false;
                }
            }
            MainTextBox.Text = textBuffer;
        }

        private void InverseCase_Click(object sender, EventArgs e)
        {
            bool capNext = true;
            string textBuffer = string.Empty;
            foreach (char item in MainTextBox.Text)
            {
                if (item == (char)32)
                {
                    capNext = true;
                    textBuffer += (char)32;                }
                else
                {
                    if (capNext) textBuffer += char.ToLower(item);
                    else textBuffer += char.ToUpper(item);
                    capNext = false;
                }
            }
            MainTextBox.Text = textBuffer;
        }

        private void TitleCase_Click(object sender, EventArgs e)
        {

        }

        private void AlternatingCase_Click(object sender, EventArgs e)
        {
            string textBuffer = string.Empty;
            for (int i = 0; i < MainTextBox.Text.Length; i++)
            {
                if (i % 2 != 0) textBuffer += char.ToUpper(MainTextBox.Text[i]);
                else textBuffer += char.ToLower(MainTextBox.Text[i]);
            }
        }

        private void SentenceCase_Click(object sender, EventArgs e)
        {
            bool capNext = true;
            string textBuffer = string.Empty;
            foreach (char item in MainTextBox.Text)
            {
                if (item == '.')
                {
                    capNext = true;
                    textBuffer += '.';
                }
                else if (item == (char)32)
                {
                    textBuffer += (char)32;
                }
                else
                {
                    if (capNext) textBuffer += char.ToUpper(item);
                    else textBuffer += char.ToLower(item);
                    capNext = false;
                }
            }
            MainTextBox.Text = textBuffer;
        }
    }
}
