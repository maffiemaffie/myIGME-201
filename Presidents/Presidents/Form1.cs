using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presidents
{
    public partial class Form : System.Windows.Forms.Form
    {
        private bool invalidKey;
        private int imageWidth;
        private int imageHeight;

        public Form()
        {
            InitializeComponent();

            // initialize timer
            timer.Interval = 500;

            // Progress bar set to 2 minutes
            progressBar.Minimum = 0;
            progressBar.Maximum = 120000;
            progressBar.Value = progressBar.Maximum;

            // timer tick delegate
            timer.Tick += new EventHandler(Timer__Tick);

            // Default textboxes to 0
            // president radio button change delegate
            // filter radio button change delegate
            // textbox validate delegate
            foreach(Control control in Controls)
            {

                if (control is TextBox)
                {
                    TextBox textBox = (TextBox)control;
                    textBox.Text = "0";
                    textBox.Validating += new CancelEventHandler(TextBox__Validating);
                    textBox.KeyDown += new KeyEventHandler(TextBox__KeyDown);
                    textBox.KeyPress += new KeyPressEventHandler(TextBox__KeyPress);
                    continue;
                }

                if (control is RadioButton)
                {
                    ((RadioButton)control).CheckedChanged += new EventHandler(PresidentsRadioButton__CheckedChanged);
                    continue;
                }
            }

            foreach(Control control in filterGroupBox.Controls)
            {
                RadioButton radioButton = (RadioButton)control;
                radioButton.CheckedChanged += new EventHandler(FilterRadioButton__CheckedChanged);
            }

            // suppress web/script warnings
            webBrowser.ScriptErrorsSuppressed = true;

            // documentcompleted delegate
            webBrowser.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(WebBrowser__DocumentCompleted);

            // Default president buttons to Benjamin Harrison
            bhRadioButton.Checked = true;

            // Default filter to All
            allRadioButton.Checked = true;

            // disable exit button
            exitButton.Enabled = false;

            // handle exit click
            exitButton.Click += new EventHandler(ExitButton__Click);

            // handle image hover
            imageWidth = pictureBox.Width;
            imageHeight = pictureBox.Height;
            pictureBox.MouseHover += new EventHandler(PictureBox__MouseHover);
            pictureBox.MouseLeave += new EventHandler(PictureBox__MouseLeave);
        }

        // TextBox__KeyPress event handler
        // check that key is a number, reject it otherwise
        private void TextBox__KeyDown(object sender, KeyEventArgs e)
        {
            invalidKey = false;
            if (!(e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9) &&
                !(e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9) && e.KeyCode != Keys.Back || 
                Control.ModifierKeys == Keys.Control || Control.ModifierKeys == Keys.Alt ||
                Control.ModifierKeys == Keys.Shift) invalidKey = true;
        }

        private void TextBox__KeyPress(object sender, KeyPressEventArgs e)
        {
            if (invalidKey) e.Handled = true;
        }

        // PresidentsRadioButton__CheckedChanged event handler
        // update image and browser
        private void PresidentsRadioButton__CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;

            if (radioButton.Checked)
            {
                String url = "https://en.m.wikipedia.org/wiki/" + radioButton.Text.Replace(' ', '_');
                webBrowser.Navigate(url);

                String image = "https://people.rit.edu/dxsigm/" + radioButton.Text.Replace(" ", "") + ".jpeg";
                pictureBox.ImageLocation = image;

                if (radioButton == boRadioButton) pictureBox.ImageLocation = pictureBox.ImageLocation.Replace("jpeg", "png");
            }
        }

        // FilterRadioButton__CheckedChanged event handler
        // update president buttons
        private void FilterRadioButton__CheckedChanged(object sender, EventArgs e)
        {
            RadioButton filterRadioButton = (RadioButton)sender;

            if (filterRadioButton.Checked)
            {
                foreach (Control control in Controls)
                {
                    if (control is RadioButton)
                    {
                        RadioButton radioButton = (RadioButton)control;

                        if (filterRadioButton.Tag.Equals("A") || radioButton.Tag.Equals(filterRadioButton.Tag))
                        {
                            radioButton.Enabled = true;
                            radioButton.Visible = true;
                        }
                        else
                        {
                            radioButton.Enabled = false;
                            radioButton.Visible = false;
                        }
                    }
                }

                switch(filterRadioButton.Tag)
                {
                    case "A":
                    case "R":
                        bhRadioButton.Checked = true;
                        break;
                    case "D":
                        fdrRadioButton.Checked = true;
                        break;
                    case "DR":
                        tjRadioButton.Checked = true;
                        break;
                    case "F":
                        gwRadioButton.Checked = true;
                        break;
                    default:
                        break;
                }
            }
        }

        // WebBrowser__DocumentCompleted handler
        // update link
        private void WebBrowser__DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            webGroupBox.Text = e.Url.ToString();
        }

        // PictureBox__MouseHover event handler
        // expand size
        private void PictureBox__MouseHover(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            pictureBox.Height = 2 * imageHeight;
            pictureBox.Width = 2 * imageWidth;
            
        }

        // PictureBox__MouseLeave event handler
        // shrink size
        private void PictureBox__MouseLeave(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            pictureBox.Height = imageHeight;
            pictureBox.Width = imageWidth;
        }

        // ExitButton__Click event handler
        // exit
        private void ExitButton__Click(object sender, EventArgs e)
        {
            Close();
        }

        // TextBox__Validating event handler
        // validate
        // disable other inputs on fail
        // end game if won
        private void TextBox__Validating(object sender, CancelEventArgs e)
        {
            if (!timer.Enabled) timer.Start();

            TextBox textBox = (TextBox)sender;
            if ( (Int32.Parse(textBox.Text) != Int32.Parse((String)textBox.Tag) && (Int32.Parse(textBox.Text)) != 0 ) )
            {
                e.Cancel = true;
                errorProvider.SetError(textBox, "That is the wrong number.");
            }
            else
            {
                foreach(Control thisControl in Controls)
                {
                    if (thisControl is TextBox)
                    {
                        TextBox thisTextBox = (TextBox)thisControl;
                        if (Int32.Parse(thisTextBox.Text) == 0)
                        {
                            return;
                        }
                    }
                    break;
                }
                gameWin();
            }
        }

        // Timer__Tick event handler
        // update progress bar
        // end game if reached 0
        private void Timer__Tick(object sender, EventArgs e)
        {
            progressBar.Value -= timer.Interval;
            if (progressBar.Value <= 0)
            {
                gameLose();
            }
        }

        // game lost
        // reset timer
        // reset textboxes
        private void gameLose()
        {
            progressBar.Value = progressBar.Maximum;
            timer.Stop();

            foreach (Control control in Controls)
            {

                if (control is TextBox)
                {
                    TextBox textBox = (TextBox)control;
                    textBox.Text = "0";
                    continue;
                }
            }
        }

        // game win
        // stop timer
        // enable exit
        // load youtube link
        private void gameWin()
        {
            timer.Stop();
            exitButton.Enabled = true;
            webBrowser.Navigate("https://www.youtube.com/embed/18212B4yfLg?autoplay=1");
        }
    }
}