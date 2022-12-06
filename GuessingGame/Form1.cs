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
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();

            lowTextBox.KeyPress += new KeyPressEventHandler(TextBox__KeyPress);
            highTextBox.KeyPress += new KeyPressEventHandler(TextBox__KeyPress);

            startButton.Click += new EventHandler(StartButton__Click);
        }

        private void TextBox__KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == '\b') return;
            e.Handled = true;
        }

        private void StartButton__Click(object sender, EventArgs e)
        {
            bool bConv;
            int lowNumber = 0;
            int highNumber = 0;

            // convert the strings entered in lowTextBox and highTextBox
            lowNumber = Convert.ToInt32(lowTextBox.Text);
            highNumber = Convert.ToInt32(highTextBox.Text);

            // if not a valid range
            if ( lowNumber >= highNumber )
            {
                // show a dialog that the numbers are not valid
                MessageBox.Show("The numbers are invalid.");
            }
            else
            {
                // otherwise we're good
                // create a form object of the second form 
                // passing in the number range
                GameForm gameForm = new GameForm(lowNumber, highNumber);

                // display the form as a modal dialog, 
                // which makes the first form inactive
                gameForm.ShowDialog();
            }
        }
    }
}
