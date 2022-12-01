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
        public FiltersForm(int _selection, Cat[] cats)
        {
            InitializeComponent();

            selection = _selection;

            // disable select
            selectButton.Enabled = false;

            // load image buttons
            foreach(Cat cat in cats)
            {
                String path = "images/" + cat.Name.ToLower().Replace(". ", "_") + ".jpeg";
                imageList.Images.Add(Image.FromFile(path));

                ListViewItem item = new ListViewItem();
                listView.Items.Add(item);
            }

            // color handler

            // sillyness handler

            // cancel handler
            cancelButton.Click += new EventHandler(CancelButton__Click);

            // select handler
            selectButton.Click += new EventHandler(SelectButton__Click);

            // default sillyness to all

            // default color to orange
        }

        // ImageButton__Click handler
        // set picture
        // enable select

        // ColorRadioButton__CheckedChanged handler
        // update grid

        // SillynessRadioButton__CheckedChanged handler
        // update grid

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
            Close();
        }
    }
}
