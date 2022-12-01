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
    public partial class RosterForm : Form
    {
        private int selection;
        public int Selection { get { return selection; } }

        private bool submit;
        public bool Submit { get { return submit; } }

        public RosterForm(int _selection)
        {
            InitializeComponent();

            selection = _selection;
            submit = false;
            listView.Items[selection].Selected = true;

            // listView selected index changed handler
            listView.SelectedIndexChanged += new EventHandler(ListView__SelectedIndexChanged);

            // default to first listed index

            // cancel handler
            cancelButton.Click += new EventHandler(CancelButton__Click);

            // select handler
            selectButton.Click += new EventHandler(SelectButton__Click);
        }

        // ListView__SelectedIndexChanged
        // update pictureBox
        // update label
        // enable selected
        private void ListView__SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count > 0)
            {
                selection = listView.SelectedIndices[0];
                String selectedName = listView.Items[selection].Text;
                String thisSelection = selectedName.ToLower().Replace(". ", "_");
                String url = "https://people.rit.edu/mrc6113/201/cats/" + thisSelection + ".jpeg";
                pictureBox.ImageLocation = url;
                nameLabel.Text = selectedName;
            }
        }

        // CancelButton__Click
        // close form, re-enable main
        private void CancelButton__Click(object sender, EventArgs e)
        {
            Close();
        }

        // SelectButton__Click
        // close form, re-enable main
        private void SelectButton__Click(object sender, EventArgs e)
        {
            submit = true;
            Close();
        }
    }
}
