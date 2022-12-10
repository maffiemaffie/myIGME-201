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
    public partial class QuestionForm : Form
    {
        private string name;
        private double input;
        private double answer;
        public bool correct;
        public QuestionForm(string name, string question, double answer, int number, int limit)
        {
            InitializeComponent();

            this.name = name;
            this.answer = answer;

            questionLabel.Text = question;
            Text = "Question #" + number.ToString();
            pictureBox.Image = null;

            toolStripProgressBar1.Maximum = limit;
            toolStripProgressBar1.Value = toolStripProgressBar1.Maximum;

            timer.Interval = 1000;

            if (question.Contains('/'))
                answerTextBox.KeyPress += new KeyPressEventHandler(AnswerTextBox__KeyPress_Division);
            else answerTextBox.KeyPress += new KeyPressEventHandler(AnswerTextBox__KeyPress);
            answerTextBox.TextChanged += new EventHandler(AnswerTextBox__TextChanged);

            submitButton.Click += new EventHandler(SubmitButton__Click);
            nextButton.Click += new EventHandler(NextButton__Click);

            timer.Tick += new EventHandler(Timer__Tick);
            timer.Start();
        }

        private void AnswerTextBox__KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if (char.IsDigit(e.KeyChar) || e.KeyChar == '\b') e.Handled = false;
        }

        private void AnswerTextBox__KeyPress_Division(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if (char.IsDigit(e.KeyChar)) e.Handled = false;
            if (answerTextBox.Text.Contains('.'))
            {
                if (answerTextBox.Text.Split('.')[1].Length >= 2) e.Handled = true;
            }
            else if (e.KeyChar == '.') e.Handled = false;
            if (e.KeyChar == '\b') e.Handled = false;
        }

        private void AnswerTextBox__TextChanged(object sender, EventArgs e)
        {
            if (answerTextBox.Text.Length > 0) input = Double.Parse(answerTextBox.Text);
        }

        private void SubmitButton__Click(object sender, EventArgs e)
        {
            if (answer == input)
            {
                responseLabel.Text = $"Well Done {name}! That's correct ^_^";
                pictureBox.Image = WinMath_WinQuiz.Properties.Resources.cat_thumb;
                correct = true;
            } else
            {
                responseLabel.Text = $"Not quite. The answer was {answer}, but you'll get the next one!";
                pictureBox.Image = WinMath_WinQuiz.Properties.Resources.cat_stare;
                correct = false;
            }

            responseLabel.Visible = true;
            nextButton.Enabled = true;
            answerTextBox.Enabled = false;
            timer.Stop();
        }

        private void NextButton__Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Timer__Tick(object sender, EventArgs e)
        {
            toolStripProgressBar1.Value -= timer.Interval;
            if (toolStripProgressBar1.Value <= 0)
            {
                timer.Stop();
                answerTextBox.Enabled = false;
                submitButton.Enabled = false;
                nextButton.Enabled = true;
                correct = false;
                pictureBox.Image = WinMath_WinQuiz.Properties.Resources.cat_cry;
                responseLabel.Text = $"Out of time :(, answer was {answer}";
                responseLabel.Visible = true;
            }
        }
    }
}
