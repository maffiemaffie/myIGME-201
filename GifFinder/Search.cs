using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GifFinder
{
    public partial class Search : Form
    {
        public string response;
        public string searchTerm;
        public int maxItems;

        public Search()
        {
            InitializeComponent();

            this.maxItemsTextBox.KeyPress += new KeyPressEventHandler(MaxItemsTextBox__KeyPress);
            this.cancelButton.Click += new EventHandler(CancelButton__Click);
            this.okButton.Click += new EventHandler(OKButton__Click);
        }

        private void MaxItemsTextBox__KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;

            if (Char.IsDigit(e.KeyChar) || e.KeyChar == '\b')
            {
                e.Handled = false;
            }
        }

        private void OKButton__Click(object sender, EventArgs e)
        {
            this.response = "OK";
            this.searchTerm = searchTermTextBox.Text;
            this.maxItems = Convert.ToInt32(maxItemsTextBox.Text);
            this.Hide();
        }

        private void CancelButton__Click(object sender, EventArgs e)
        {
            this.response = "Cancel";
            this.Hide();
        }
    }
}
