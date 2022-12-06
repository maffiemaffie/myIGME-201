using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessingGame
{
    public partial class GameForm : Form
    {
        int correct;
        int guesses = 0;

        public GameForm(int lowNumber, int highNumber)
        {
            InitializeComponent();

            Random random = new Random();
            correct = random.Next(lowNumber, highNumber);

            toolStripProgressBar1.Maximum = 45000;
            toolStripProgressBar1.Value = toolStripProgressBar1.Maximum;
            timer.Tick += new EventHandler(Timer__Tick);
            guessTextBox.KeyPress += new KeyPressEventHandler(TextBox__KeyPress);
            guessButton.Click += new EventHandler(GuessButton__Click);

            timer.Start();
        }

        private void Timer__Tick(object sender, EventArgs e)
        {
            int newValue = toolStripProgressBar1.Value - timer.Interval;

            if (newValue <= 0)
            {
                timer.Stop();
                MessageBox.Show($"Out of Time! The answer was {correct}");
                Close();
            } 
            else
            {
                toolStripProgressBar1.Value = newValue;
            }
        }

        private void TextBox__KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == '\b') return;
            e.Handled = true;
        }

        private void GuessButton__Click(object sender, EventArgs e)
        {
            guesses++;
            int thisGuess = Int32.Parse(guessTextBox.Text);
            if (thisGuess == correct)
            {
                MessageBox.Show($"Woohoo, you got it in {guesses} guesses!");
                Close();
            }
            else
            {
                if (thisGuess > correct) incorrectLabel.Text = $"{thisGuess} is too high.";
                else incorrectLabel.Text = $"{thisGuess} is too low.";

                incorrectLabel.Refresh();
            }
        }
    }
}
