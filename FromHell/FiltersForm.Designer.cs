namespace FromHell
{
    partial class FiltersForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FiltersForm));
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.colorsGroupBox = new System.Windows.Forms.GroupBox();
            this.whiteRadioButton = new System.Windows.Forms.RadioButton();
            this.blackRadioButton = new System.Windows.Forms.RadioButton();
            this.greyRadioButton = new System.Windows.Forms.RadioButton();
            this.orangeRadioButton = new System.Windows.Forms.RadioButton();
            this.normalRadioButton = new System.Windows.Forms.RadioButton();
            this.sillyRadioButton = new System.Windows.Forms.RadioButton();
            this.quirkyRadioButton = new System.Windows.Forms.RadioButton();
            this.sillynessGroupBox = new System.Windows.Forms.GroupBox();
            this.allRadioButton = new System.Windows.Forms.RadioButton();
            this.exitGroupBox = new System.Windows.Forms.GroupBox();
            this.selectButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.listView = new System.Windows.Forms.ListView();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.brownRadioButton = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.colorsGroupBox.SuspendLayout();
            this.sillynessGroupBox.SuspendLayout();
            this.exitGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // colorsGroupBox
            // 
            this.colorsGroupBox.Controls.Add(this.brownRadioButton);
            this.colorsGroupBox.Controls.Add(this.whiteRadioButton);
            this.colorsGroupBox.Controls.Add(this.blackRadioButton);
            this.colorsGroupBox.Controls.Add(this.greyRadioButton);
            this.colorsGroupBox.Controls.Add(this.orangeRadioButton);
            this.colorsGroupBox.Location = new System.Drawing.Point(12, 12);
            this.colorsGroupBox.Name = "colorsGroupBox";
            this.colorsGroupBox.Size = new System.Drawing.Size(128, 144);
            this.colorsGroupBox.TabIndex = 1;
            this.colorsGroupBox.TabStop = false;
            this.colorsGroupBox.Text = "Color";
            // 
            // whiteRadioButton
            // 
            this.whiteRadioButton.AutoSize = true;
            this.whiteRadioButton.ForeColor = System.Drawing.Color.White;
            this.whiteRadioButton.Location = new System.Drawing.Point(7, 92);
            this.whiteRadioButton.Name = "whiteRadioButton";
            this.whiteRadioButton.Size = new System.Drawing.Size(53, 17);
            this.whiteRadioButton.TabIndex = 3;
            this.whiteRadioButton.TabStop = true;
            this.whiteRadioButton.Text = "Whit&e";
            this.whiteRadioButton.UseVisualStyleBackColor = true;
            // 
            // blackRadioButton
            // 
            this.blackRadioButton.AutoSize = true;
            this.blackRadioButton.Location = new System.Drawing.Point(7, 68);
            this.blackRadioButton.Name = "blackRadioButton";
            this.blackRadioButton.Size = new System.Drawing.Size(52, 17);
            this.blackRadioButton.TabIndex = 2;
            this.blackRadioButton.TabStop = true;
            this.blackRadioButton.Text = "&Black";
            this.blackRadioButton.UseVisualStyleBackColor = true;
            // 
            // greyRadioButton
            // 
            this.greyRadioButton.AutoSize = true;
            this.greyRadioButton.ForeColor = System.Drawing.Color.Gray;
            this.greyRadioButton.Location = new System.Drawing.Point(7, 44);
            this.greyRadioButton.Name = "greyRadioButton";
            this.greyRadioButton.Size = new System.Drawing.Size(47, 17);
            this.greyRadioButton.TabIndex = 1;
            this.greyRadioButton.TabStop = true;
            this.greyRadioButton.Text = "Gr&ey";
            this.greyRadioButton.UseVisualStyleBackColor = true;
            // 
            // orangeRadioButton
            // 
            this.orangeRadioButton.AutoSize = true;
            this.orangeRadioButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.orangeRadioButton.Location = new System.Drawing.Point(7, 20);
            this.orangeRadioButton.Name = "orangeRadioButton";
            this.orangeRadioButton.Size = new System.Drawing.Size(60, 17);
            this.orangeRadioButton.TabIndex = 0;
            this.orangeRadioButton.TabStop = true;
            this.orangeRadioButton.Text = "Orang&e";
            this.orangeRadioButton.UseVisualStyleBackColor = true;
            // 
            // normalRadioButton
            // 
            this.normalRadioButton.AutoSize = true;
            this.normalRadioButton.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.normalRadioButton.ForeColor = System.Drawing.Color.White;
            this.normalRadioButton.Location = new System.Drawing.Point(6, 21);
            this.normalRadioButton.Name = "normalRadioButton";
            this.normalRadioButton.Size = new System.Drawing.Size(60, 18);
            this.normalRadioButton.TabIndex = 3;
            this.normalRadioButton.TabStop = true;
            this.normalRadioButton.Text = "Normal";
            this.normalRadioButton.UseVisualStyleBackColor = true;
            // 
            // sillyRadioButton
            // 
            this.sillyRadioButton.AutoSize = true;
            this.sillyRadioButton.Font = new System.Drawing.Font("Gigi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sillyRadioButton.ForeColor = System.Drawing.Color.Cyan;
            this.sillyRadioButton.Location = new System.Drawing.Point(6, 67);
            this.sillyRadioButton.Name = "sillyRadioButton";
            this.sillyRadioButton.Size = new System.Drawing.Size(52, 19);
            this.sillyRadioButton.TabIndex = 2;
            this.sillyRadioButton.TabStop = true;
            this.sillyRadioButton.Text = "Silly";
            this.sillyRadioButton.UseVisualStyleBackColor = true;
            // 
            // quirkyRadioButton
            // 
            this.quirkyRadioButton.AutoSize = true;
            this.quirkyRadioButton.Font = new System.Drawing.Font("Ravie", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quirkyRadioButton.ForeColor = System.Drawing.Color.Yellow;
            this.quirkyRadioButton.Location = new System.Drawing.Point(6, 44);
            this.quirkyRadioButton.Name = "quirkyRadioButton";
            this.quirkyRadioButton.Size = new System.Drawing.Size(75, 21);
            this.quirkyRadioButton.TabIndex = 1;
            this.quirkyRadioButton.TabStop = true;
            this.quirkyRadioButton.Text = "Quirky";
            this.quirkyRadioButton.UseVisualStyleBackColor = true;
            // 
            // sillynessGroupBox
            // 
            this.sillynessGroupBox.Controls.Add(this.allRadioButton);
            this.sillynessGroupBox.Controls.Add(this.normalRadioButton);
            this.sillynessGroupBox.Controls.Add(this.sillyRadioButton);
            this.sillynessGroupBox.Controls.Add(this.quirkyRadioButton);
            this.sillynessGroupBox.Location = new System.Drawing.Point(159, 12);
            this.sillynessGroupBox.Name = "sillynessGroupBox";
            this.sillynessGroupBox.Size = new System.Drawing.Size(128, 118);
            this.sillynessGroupBox.TabIndex = 4;
            this.sillynessGroupBox.TabStop = false;
            this.sillynessGroupBox.Text = "Sillyness";
            // 
            // allRadioButton
            // 
            this.allRadioButton.AutoSize = true;
            this.allRadioButton.Font = new System.Drawing.Font("Ink Free", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allRadioButton.Location = new System.Drawing.Point(6, 90);
            this.allRadioButton.Name = "allRadioButton";
            this.allRadioButton.Size = new System.Drawing.Size(39, 18);
            this.allRadioButton.TabIndex = 4;
            this.allRadioButton.TabStop = true;
            this.allRadioButton.Text = "All";
            this.allRadioButton.UseVisualStyleBackColor = true;
            // 
            // exitGroupBox
            // 
            this.exitGroupBox.Controls.Add(this.selectButton);
            this.exitGroupBox.Controls.Add(this.cancelButton);
            this.exitGroupBox.Location = new System.Drawing.Point(12, 162);
            this.exitGroupBox.Name = "exitGroupBox";
            this.exitGroupBox.Size = new System.Drawing.Size(275, 276);
            this.exitGroupBox.TabIndex = 5;
            this.exitGroupBox.TabStop = false;
            // 
            // selectButton
            // 
            this.selectButton.BackColor = System.Drawing.Color.Red;
            this.selectButton.Font = new System.Drawing.Font("Cooper Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectButton.Location = new System.Drawing.Point(88, 247);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(75, 23);
            this.selectButton.TabIndex = 1;
            this.selectButton.Text = "Select";
            this.selectButton.UseVisualStyleBackColor = false;
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.Lime;
            this.cancelButton.Font = new System.Drawing.Font("Playbill", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(7, 247);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 0;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            // 
            // listView
            // 
            this.listView.BackColor = System.Drawing.Color.White;
            this.listView.BackgroundImage = global::FromHell.Properties.Resources.worm;
            this.listView.HideSelection = false;
            this.listView.LargeImageList = this.imageList;
            this.listView.Location = new System.Drawing.Point(293, 12);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(495, 426);
            this.listView.TabIndex = 6;
            this.listView.UseCompatibleStateImageBehavior = false;
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "alma.jpeg");
            this.imageList.Images.SetKeyName(1, "bongo.jpeg");
            this.imageList.Images.SetKeyName(2, "boopy.jpeg");
            this.imageList.Images.SetKeyName(3, "damien.jpeg");
            this.imageList.Images.SetKeyName(4, "death.jpeg");
            this.imageList.Images.SetKeyName(5, "dirt.jpeg");
            this.imageList.Images.SetKeyName(6, "douglas.jpeg");
            this.imageList.Images.SetKeyName(7, "eepy.jpeg");
            this.imageList.Images.SetKeyName(8, "fart.jpeg");
            this.imageList.Images.SetKeyName(9, "guh.jpeg");
            this.imageList.Images.SetKeyName(10, "hehe.jpeg");
            this.imageList.Images.SetKeyName(11, "milly.jpeg");
            this.imageList.Images.SetKeyName(12, "mr_mustache.jpeg");
            this.imageList.Images.SetKeyName(13, "orpy.jpeg");
            this.imageList.Images.SetKeyName(14, "pierce.jpeg");
            this.imageList.Images.SetKeyName(15, "scug.jpeg");
            this.imageList.Images.SetKeyName(16, "tina.jpeg");
            this.imageList.Images.SetKeyName(17, "toe.jpeg");
            this.imageList.Images.SetKeyName(18, "weewoo.jpeg");
            this.imageList.Images.SetKeyName(19, "winky.jpeg");
            this.imageList.Images.SetKeyName(20, "worm.jpeg");
            // 
            // brownRadioButton
            // 
            this.brownRadioButton.AutoSize = true;
            this.brownRadioButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.brownRadioButton.Location = new System.Drawing.Point(7, 116);
            this.brownRadioButton.Name = "brownRadioButton";
            this.brownRadioButton.Size = new System.Drawing.Size(55, 17);
            this.brownRadioButton.TabIndex = 4;
            this.brownRadioButton.TabStop = true;
            this.brownRadioButton.Text = "&Brown";
            this.brownRadioButton.UseVisualStyleBackColor = true;
            // 
            // FiltersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Fuchsia;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.exitGroupBox);
            this.Controls.Add(this.sillynessGroupBox);
            this.Controls.Add(this.colorsGroupBox);
            this.Name = "FiltersForm";
            this.Text = "FiltersForm";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.colorsGroupBox.ResumeLayout(false);
            this.colorsGroupBox.PerformLayout();
            this.sillynessGroupBox.ResumeLayout(false);
            this.sillynessGroupBox.PerformLayout();
            this.exitGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.GroupBox sillynessGroupBox;
        private System.Windows.Forms.RadioButton normalRadioButton;
        private System.Windows.Forms.RadioButton sillyRadioButton;
        private System.Windows.Forms.RadioButton quirkyRadioButton;
        private System.Windows.Forms.GroupBox colorsGroupBox;
        private System.Windows.Forms.RadioButton whiteRadioButton;
        private System.Windows.Forms.RadioButton blackRadioButton;
        private System.Windows.Forms.RadioButton greyRadioButton;
        private System.Windows.Forms.RadioButton orangeRadioButton;
        private System.Windows.Forms.GroupBox exitGroupBox;
        private System.Windows.Forms.Button selectButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.RadioButton allRadioButton;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.RadioButton brownRadioButton;
    }
}