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
    public partial class EndForm : Form
    {
        public EndForm(int correct, int questions)
        {
            InitializeComponent();

            label1.Text = $"You got {correct} out of {questions} correct, which is a score of " +
                $"{(((double)correct) / questions * 100).ToString("F2")}%";

            exitButton.Click += new EventHandler(ExitButton__Click);

            playAgainButton.Click += new EventHandler(PlayAgainButton__Click);
        }

        private void ExitButton__Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PlayAgainButton__Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
