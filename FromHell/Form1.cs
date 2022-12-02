using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FromHell
{
    public partial class Form1 : Form
    {
        private int selection;
        public int Selection { get { return selection; } }

        private Thread thread;

        public BounceBoxEventHandler BounceDelegate;

        private ThreadStart bounceStart;
        private BounceBox[] bounceBoxes;

        private int tickCount = 0;

        private Cat[] cats = new Cat[]
        {
            new Cat("Alma", Color.ORANGE, Sillyness.QUIRKY),
            new Cat("Bongo", Color.WHITE, Sillyness.NORMAL),
            new Cat("Boopy", Color.BROWN, Sillyness.SILLY),
            new Cat("Damien", Color.ORANGE, Sillyness.NORMAL),
            new Cat("Death", Color.WHITE, Sillyness.NORMAL),
            new Cat("Dirt", Color.BROWN | Color.WHITE, Sillyness.QUIRKY),
            new Cat("Douglas", Color.GREY, Sillyness.QUIRKY),
            new Cat("Eepy", Color.GREY, Sillyness.NORMAL),
            new Cat("Fart", Color.GREY, Sillyness.SILLY),
            new Cat("Guh", Color.GREY | Color.WHITE, Sillyness.SILLY),
            new Cat("Hehe", Color.BROWN, Sillyness.SILLY),
            new Cat("Milly", Color.ORANGE, Sillyness.NORMAL),
            new Cat("Mr. Mustache", Color.BLACK | Color.WHITE, Sillyness.QUIRKY),
            new Cat("Orpy", Color.ORANGE, Sillyness.NORMAL),
            new Cat("Pierce", Color.GREY | Color.WHITE, Sillyness.NORMAL),
            new Cat("Scug", Color.GREY | Color.WHITE, Sillyness.SILLY),
            new Cat("Tina", Color.WHITE, Sillyness.NORMAL),
            new Cat("Toe", Color.GREY, Sillyness.SILLY),
            new Cat("Weewoo", Color.BROWN | Color.WHITE, Sillyness.SILLY),
            new Cat("Winky", Color.BROWN, Sillyness.NORMAL),
            new Cat("Worm", Color.WHITE, Sillyness.QUIRKY)
        };
        public Cat[] Cats { get { return cats; } }

        public Form1()
        {
            InitializeComponent();

            // initialize meowtification
            notifyIcon.Icon = SystemIcons.Information;
            timer.Interval = 1000;

            // start timer
            timer.Tick += new EventHandler(Timer__Tick);
            timer.Start();

            // default selection
            selection = 0;

            // filtersButton click handler
            filtersButton.Click += new EventHandler(FiltersButton__Click);

            // rosterButton click handler
            rosterButton.Click += new EventHandler(RosterButton__Click);

            // randomize click handler
            generateButton.Click += new EventHandler(GenerateButton__Click);

            // exitButton click handler
            exitButton.Click += new EventHandler(ExitButton__Click);

            // exitButton hover handler
            exitButton.MouseHover += new EventHandler(ExitButton__MouseHover);

            // load media and details
            LoadDisplay(0);

            FormClosing += new FormClosingEventHandler(Form__Closing);
            BounceDelegate = new BounceBoxEventHandler(Bounce__Update);

            bounceStart = new ThreadStart(BounceThread);
            thread = new Thread(bounceStart);

            Bounce();
        }

        // Timer__Tick event handler
        // show meowtification
        private void Timer__Tick(object sender, EventArgs e)
        {
            if(++tickCount == 10)
            {
                timer.Tick -= new EventHandler(Timer__Tick);
            }
            notifyIcon.Visible = true;
            notifyIcon.ShowBalloonTip(1000);
        }

        // ExitButton__Click event handler
        // Close application
        private void ExitButton__Click(object sender, EventArgs e)
        {
            if (selection != 7)
            {
                BlockExit();
                return;
            }
            Application.Exit();
        }

        private void BlockExit()
        {
            String message = "Sorry, " + cats[selection].Name + " is standing on the exit button :(";
            MessageBox.Show(message, "Oops..", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }

        // ExitButton__MouseHover event handler
        // jump around
        private void ExitButton__MouseHover(object sender, EventArgs e)
        {
            if (exitButton.Location.X == 713) exitButton.Location = new Point(12, exitButton.Location.Y);
            else exitButton.Location = new Point(713, exitButton.Location.Y);
        }

        // load media and details
        // load image, load info
        private void LoadDisplay(int index)
        {
            if (index == 6)
            {
                String message = "Douglas did not like that.";
                String caption = "Suffer in Hell.";

                MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                Application.Exit();
            }

            selection = index;
            Cat thisCat = Cats[index];

            String filename = thisCat.Name.ToLower().Replace(". ", "_");
            String url = "https://people.rit.edu/mrc6113/201/cats/" + filename + ".jpeg";
            pictureBox.ImageLocation = url;

            String details = "";
            details += "Color: " + thisCat.Color.ToString() + '\n';
            details += "Sillyness: " + thisCat.Sillyness.ToString() + '\n';

            bioTextBox.Text = thisCat.Name;
            infoTextBox.Text = details;
        }

        // FiltersButton__Click
        // disable this form, show filters
        private void FiltersButton__Click(object sender, EventArgs e)
        {
            FiltersForm filter = new FiltersForm(selection, Cats);
            filter.FormClosed += new FormClosedEventHandler(FiltersForm__Close);
            Enabled = false;
            filter.Show();
        }

        private void FiltersForm__Close(object sender, FormClosedEventArgs e)
        {
            Enabled = true;
            FiltersForm filter = (FiltersForm)sender;
            LoadDisplay(filter.Selection);
        }

        // RosterButton__Click
        // disable this form, show filters
        private void RosterButton__Click(object sender, EventArgs e)
        {
            RosterForm roster = new RosterForm(selection);
            roster.FormClosed += new FormClosedEventHandler(RosterForm__Close);
            Enabled = false;
            roster.Show();
        }

        private void RosterForm__Close(object sender, FormClosedEventArgs e)
        {
            Enabled = true;
            RosterForm roster = (RosterForm)sender;
            LoadDisplay(roster.Selection);
        }

        // GenerateButton__Click
        // load media and details
        private void GenerateButton__Click(object sender, EventArgs e)
        {
            Random random = new Random();
            LoadDisplay(random.Next(16));
        }

        private void Form__Closing(object sender, FormClosingEventArgs e)
        {
            thread.Abort();
        }

        private void Bounce()
        {
            int Count = 0;
            foreach (Control box in Controls)
            {
                if (box.Tag != null && box.Tag.Equals("BounceBox"))
                {
                    foreach (Control control in box.Controls)
                    {
                        if (control.Tag == null || !control.Tag.Equals("Bounce")) continue;
                        Count++;
                    }
                }
            }

            Control[] bouncers = new Control[Count];
            bounceBoxes = new BounceBox[Count];

            Count = 0;
            foreach (Control box in Controls)
            {
                if (box.Tag != null && box.Tag.Equals("BounceBox"))
                {
                    foreach (Control control in box.Controls)
                    {
                        if (control.Tag == null || !control.Tag.Equals("Bounce")) continue;

                        bounceBoxes[Count++] = new BounceBox(
                            control.Name, 0, box.Width, box.Height, 0, 
                            control.Location.X, control.Location.Y, control.Width, control.Height);
                    }
                }
            }

            thread.Start();
        }

        private void BounceThread()
        {
            BounceThreadClass bounceThreadClass = new BounceThreadClass(this);

            while (true)
            {
                for (int i = 0; i < bounceBoxes.Length; i++)
                {
                    bounceBoxes[i].Update();
                }
                bounceThreadClass.Run();
                Thread.Sleep(50);
            }
        }

        public delegate void BounceBoxEventHandler();

        private void Bounce__Update()
        {
            foreach (BounceBox bounceBox in bounceBoxes)
            {
                foreach (Control box in Controls)
                {
                    if (box.Tag == null || !box.Tag.Equals("BounceBox")) continue;
                    foreach (Control control in box.Controls)
                    {
                        if (control.Name.Equals(bounceBox.Name))
                        {
                            control.Location = new Point(bounceBox.X, bounceBox.Y);
                            continue;
                        }
                    }
                }

            }
        }
    }

    public class BounceThreadClass
    {
        private Form1 form;
        public BounceThreadClass(Form1 form)
        {
            this.form = form;
        }

        public void Run()
        {
            form.Invoke(form.BounceDelegate);
        }
    }
}
