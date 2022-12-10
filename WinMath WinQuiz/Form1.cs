using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinMath_WinQuiz
{
    public partial class SetupForm : Form
    {
        public string PlayerName;
        public int Questions;
        public int Limit;
        public MathQuiz.Difficulty Diff;
        public SetupForm()
        {
            InitializeComponent();

            // name textbox
            nameTextBox.KeyPress += new KeyPressEventHandler(NameTextBox__KeyPress);
            nameTextBox.TextChanged += new EventHandler(NameTextBox__TextChanged);

            // questions textbox
            questionsTextBox.KeyPress += new KeyPressEventHandler(QuestionsTextBox__KeyPress);
            questionsTextBox.TextChanged += new EventHandler(QuestionsTextBox__TextChanged);

            // time limit
            limitTextBox.KeyPress += new KeyPressEventHandler(LimitTextBox__KeyPress);
            limitTextBox.TextChanged += new EventHandler(LimitTextBox__TextChanged);

            // difficulty
            difficultyComboBox.TextChanged += new EventHandler(DifficultyComboBox__TextChanged);

            // cancel
            cancelButton.Click += new EventHandler(CancelButton__Click);
        }

        private void NameTextBox__KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if (char.IsLetter(e.KeyChar) || e.KeyChar == ' ' || e.KeyChar == '\b') e.Handled = false;
        }

        private void QuestionsTextBox__KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if (char.IsDigit(e.KeyChar) || e.KeyChar == '\b') e.Handled = false;
        }

        private void LimitTextBox__KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if (char.IsDigit(e.KeyChar) && limitTextBox.Text.Length < 3) e.Handled = false;
            if (e.KeyChar == '\b') e.Handled = false;
        }

        private void NameTextBox__TextChanged(object sender, EventArgs e)
        {
            PlayerName = nameTextBox.Text;
        }

        private void QuestionsTextBox__TextChanged(object sender, EventArgs e)
        {
            if (questionsTextBox.Text.Length > 0) Questions = Int32.Parse(questionsTextBox.Text);
        }

        private void LimitTextBox__TextChanged(object sender, EventArgs e)
        {
            if (limitTextBox.Text.Length > 0) Limit = 1000 * Int32.Parse(limitTextBox.Text);
        }

        private void DifficultyComboBox__TextChanged(object sender, EventArgs e)
        {
            MathQuiz.Difficulty.TryParse(difficultyComboBox.Text, true, out Diff);
        }

        private void CancelButton__Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
