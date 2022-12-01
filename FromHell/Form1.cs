using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FromHell
{
    public partial class Form1 : Form
    {
        private int selection;
        public int Selection { get { return selection; } }

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

            // load media and details

            // filtersButton click handler
            filtersButton.Click += new EventHandler(FiltersButton__Click);

            // rosterButton click handler
            rosterButton.Click += new EventHandler(RosterButton__Click);

            // randomize click handler

            // exitButton click handler
            exitButton.Click += new EventHandler(ExitButton__Click);
        }

        // Timer__Tick event handler
        // show meowtification
        private void Timer__Tick(object sender, EventArgs e)
        {
            notifyIcon.Visible = true;
            notifyIcon.ShowBalloonTip(1000);
        }

        // ExitButton__Click event handler
        // Close application
        private void ExitButton__Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // load media and details
        // load image, load info

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
            selection = filter.Selection;
            // String _thisSelection = filter.Selection.ToLower().Replace(". ", "_");
            // String url = "https://people.rit.edu/mrc6113/201/cats/" + _thisSelection + ".jpeg";
            // pictureBox.ImageLocation = url;
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
            selection = roster.Selection;
            String _thisSelection = Cats[selection].Name.ToLower().Replace(". ", "_");
            String url = "https://people.rit.edu/mrc6113/201/cats/" + _thisSelection + ".jpeg";
            pictureBox.ImageLocation = url;
        }

        // GenerateButton__Click
        // load media and details
    }
}
