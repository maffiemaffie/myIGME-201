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
        public Form1()
        {
            InitializeComponent();

            // initialize meowtification
            notifyIcon.Icon = SystemIcons.Information;
            timer.Interval = 1000;

            // start timer
            timer.Tick += new EventHandler(Timer__Tick);
            timer.Start();

            // load media and details

            // filtersButton click handler

            // rosterButton click handler

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

        // RosterButton__Click
        // disable this form, show filters

        // GenerateButton__Click
        // load media and details
    }
}
