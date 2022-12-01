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

            // exitButton click handler
            exitButton.Click += new EventHandler(ExitButton__Click);

            // start timer
            timer.Tick += new EventHandler(Timer__Tick);
            timer.Start();
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
    }
}
