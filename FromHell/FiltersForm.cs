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
    public partial class FiltersForm : Form
    {
        private int selection;
        public int Selection { get { return selection; } }

        private Cat[] cats;
        public Cat[] Cats { get { return cats; } }

        private bool submit;
        public bool Submit { get { return submit; } }

        private Color colorFilter;
        private Sillyness sillyFilter;

        public FiltersForm(int _selection, Cat[] _cats)
        {
            InitializeComponent();

            selection = _selection;
            cats = _cats;
            submit = false;

            // disable select
            selectButton.Enabled = false;

            // load image buttons
            for (int i = 0; i < _cats.Length; i++)
            {
                listView.Items.Add(new ListViewItem()
                {
                    ImageIndex = i
                });
            }

            // color handler
            foreach(RadioButton radioButton in colorsGroupBox.Controls)
            {
                radioButton.CheckedChanged += new EventHandler(ColorRadioButton__CheckedChanged);
            }

            // sillyness handler
            foreach (RadioButton radioButton in sillynessGroupBox.Controls)
            {
                radioButton.CheckedChanged += new EventHandler(SillynessRadioButton__CheckedChanged);
            }

            listView.SelectedIndexChanged += new EventHandler(ListView__SelectedIndexChanged);

            // cancel handler
            cancelButton.Click += new EventHandler(CancelButton__Click);

            // select handler
            selectButton.Click += new EventHandler(SelectButton__Click);

            // default sillyness to all
            allRadioButton.Checked = true;

            // default color to orange
            orangeRadioButton.Checked = true;
        }

        // ColorRadioButton__CheckedChanged handler
        // update grid
        private void ColorRadioButton__CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            if (!radioButton.Checked) return;

            Color filter;
            switch(radioButton.Text.Replace("&", ""))
            {
                case "Orange":
                    filter = Color.GREY;
                    break;
                case "Grey":
                    filter = Color.ORANGE;
                    break;
                case "Black":
                    filter = Color.GREY;
                    break;
                case "White":
                    filter = Color.GREY;
                    break;
                case "Brown":
                    filter = Color.GREY;
                    break;
                default:
                    return;
            }

            colorFilter = filter;
            Filter();
        }

        // SillynessRadioButton__CheckedChanged handler
        // update grid
        private void SillynessRadioButton__CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            if (!radioButton.Checked) return;

            Sillyness filter;
            switch (radioButton.Text.Replace("&", ""))
            {
                case "All":
                    filter = 0;
                    break;
                case "Normal":
                    filter = Sillyness.NORMAL;
                    break;
                case "Quirky":
                    filter = Sillyness.QUIRKY;
                    break;
                case "Silly":
                    filter = Sillyness.SILLY;
                    break;
                default:
                    return;
            }

            sillyFilter = filter;
            Filter();
        }

        private void Filter()
        {
            for (int i = 0; i < listView.Items.Count; i++)
            {
                ListViewItem thisItem = listView.Items[i];
                Cat thisCat = Cats[i];

                if ((thisCat.Sillyness & sillyFilter) != sillyFilter ||
                    (thisCat.Color & colorFilter) != colorFilter)
                {
                    thisItem.ImageIndex = -1;
                }
                else
                {
                    thisItem.ImageIndex = i;
                }
            }
        }

        private void ListView__SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView.SelectedIndices.Count == 0) return;

            int thisIndex = listView.SelectedIndices[0];
            ListViewItem thisItem = listView.Items[thisIndex];
            if (thisItem.ImageIndex == -1)
            {
                thisItem.Selected = false;
                return;
            }

            selection = thisIndex;
            selectButton.Enabled = true;
        }

        // CancelButton__Click handler
        // close window, re-enable main
        private void CancelButton__Click(object sender, EventArgs e)
        {
            Close();
        }

        // SelectButton__click handler
        // close window, re-enable main
        private void SelectButton__Click(object sender, EventArgs e)
        {
            submit = true;
            Close();
        }
    }
}
