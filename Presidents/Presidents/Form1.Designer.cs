namespace Presidents
{
    partial class Form
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
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.webGroupBox = new System.Windows.Forms.GroupBox();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.filterGroupBox = new System.Windows.Forms.GroupBox();
            this.fedRadioButton = new System.Windows.Forms.RadioButton();
            this.drRadioButton = new System.Windows.Forms.RadioButton();
            this.repRadioButton = new System.Windows.Forms.RadioButton();
            this.demRadioButton = new System.Windows.Forms.RadioButton();
            this.allRadioButton = new System.Windows.Forms.RadioButton();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.bhRadioButton = new System.Windows.Forms.RadioButton();
            this.fdrRadioButton = new System.Windows.Forms.RadioButton();
            this.wjcRadioButton = new System.Windows.Forms.RadioButton();
            this.jbRadioButton = new System.Windows.Forms.RadioButton();
            this.fpRadioButton = new System.Windows.Forms.RadioButton();
            this.gwbRadioButton = new System.Windows.Forms.RadioButton();
            this.boRadioButton = new System.Windows.Forms.RadioButton();
            this.jfkRadioButton = new System.Windows.Forms.RadioButton();
            this.tjRadioButton = new System.Windows.Forms.RadioButton();
            this.trRadioButton = new System.Windows.Forms.RadioButton();
            this.jaRadioButton = new System.Windows.Forms.RadioButton();
            this.gwRadioButton = new System.Windows.Forms.RadioButton();
            this.mvbRadioButton = new System.Windows.Forms.RadioButton();
            this.ddeRadioButton = new System.Windows.Forms.RadioButton();
            this.rrRadioButton = new System.Windows.Forms.RadioButton();
            this.wmRadioButton = new System.Windows.Forms.RadioButton();
            this.bhTextBox = new System.Windows.Forms.TextBox();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.fdrTextBox = new System.Windows.Forms.TextBox();
            this.jbTextBox = new System.Windows.Forms.TextBox();
            this.wjcTextBox = new System.Windows.Forms.TextBox();
            this.gwbTextBox = new System.Windows.Forms.TextBox();
            this.fpTextBox = new System.Windows.Forms.TextBox();
            this.jfkTextBox = new System.Windows.Forms.TextBox();
            this.boTextBox = new System.Windows.Forms.TextBox();
            this.tjTextBox = new System.Windows.Forms.TextBox();
            this.trTextBox = new System.Windows.Forms.TextBox();
            this.jaTextBox = new System.Windows.Forms.TextBox();
            this.gwTextBox = new System.Windows.Forms.TextBox();
            this.mvbTextBox = new System.Windows.Forms.TextBox();
            this.ddeTextBox = new System.Windows.Forms.TextBox();
            this.rrTextBox = new System.Windows.Forms.TextBox();
            this.wmTextBox = new System.Windows.Forms.TextBox();
            this.presidentsToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.webGroupBox.SuspendLayout();
            this.filterGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar1.Location = new System.Drawing.Point(0, 557);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(946, 23);
            this.progressBar1.TabIndex = 1;
            // 
            // webGroupBox
            // 
            this.webGroupBox.Controls.Add(this.webBrowser);
            this.webGroupBox.Location = new System.Drawing.Point(347, 12);
            this.webGroupBox.Name = "webGroupBox";
            this.webGroupBox.Size = new System.Drawing.Size(599, 487);
            this.webGroupBox.TabIndex = 18;
            this.webGroupBox.TabStop = false;
            this.webGroupBox.Text = "https://en.wikipedia.org/wiki/Benjamin_Harrison";
            // 
            // webBrowser
            // 
            this.webBrowser.Location = new System.Drawing.Point(6, 19);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(587, 479);
            this.webBrowser.TabIndex = 18;
            // 
            // filterGroupBox
            // 
            this.filterGroupBox.Controls.Add(this.fedRadioButton);
            this.filterGroupBox.Controls.Add(this.drRadioButton);
            this.filterGroupBox.Controls.Add(this.repRadioButton);
            this.filterGroupBox.Controls.Add(this.demRadioButton);
            this.filterGroupBox.Controls.Add(this.allRadioButton);
            this.filterGroupBox.Location = new System.Drawing.Point(189, 213);
            this.filterGroupBox.Name = "filterGroupBox";
            this.filterGroupBox.Size = new System.Drawing.Size(152, 144);
            this.filterGroupBox.TabIndex = 17;
            this.filterGroupBox.TabStop = false;
            this.filterGroupBox.Text = "Filter";
            // 
            // fedRadioButton
            // 
            this.fedRadioButton.AutoSize = true;
            this.fedRadioButton.Location = new System.Drawing.Point(15, 112);
            this.fedRadioButton.Name = "fedRadioButton";
            this.fedRadioButton.Size = new System.Drawing.Size(70, 17);
            this.fedRadioButton.TabIndex = 18;
            this.fedRadioButton.Text = "Federalist";
            this.fedRadioButton.UseVisualStyleBackColor = true;
            // 
            // drRadioButton
            // 
            this.drRadioButton.AutoSize = true;
            this.drRadioButton.Location = new System.Drawing.Point(15, 89);
            this.drRadioButton.Name = "drRadioButton";
            this.drRadioButton.Size = new System.Drawing.Size(136, 17);
            this.drRadioButton.TabIndex = 18;
            this.drRadioButton.Text = "Democratic-Republican";
            this.drRadioButton.UseVisualStyleBackColor = true;
            // 
            // repRadioButton
            // 
            this.repRadioButton.AutoSize = true;
            this.repRadioButton.Location = new System.Drawing.Point(15, 65);
            this.repRadioButton.Name = "repRadioButton";
            this.repRadioButton.Size = new System.Drawing.Size(79, 17);
            this.repRadioButton.TabIndex = 18;
            this.repRadioButton.Text = "Republican";
            this.repRadioButton.UseVisualStyleBackColor = true;
            // 
            // demRadioButton
            // 
            this.demRadioButton.AutoSize = true;
            this.demRadioButton.Location = new System.Drawing.Point(15, 42);
            this.demRadioButton.Name = "demRadioButton";
            this.demRadioButton.Size = new System.Drawing.Size(71, 17);
            this.demRadioButton.TabIndex = 18;
            this.demRadioButton.Text = "Democrat";
            this.demRadioButton.UseVisualStyleBackColor = true;
            // 
            // allRadioButton
            // 
            this.allRadioButton.AutoSize = true;
            this.allRadioButton.Location = new System.Drawing.Point(15, 19);
            this.allRadioButton.Name = "allRadioButton";
            this.allRadioButton.Size = new System.Drawing.Size(36, 17);
            this.allRadioButton.TabIndex = 18;
            this.allRadioButton.Text = "All";
            this.allRadioButton.UseVisualStyleBackColor = true;
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(12, 213);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(146, 189);
            this.pictureBox.TabIndex = 2;
            this.pictureBox.TabStop = false;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(865, 516);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 18;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            // 
            // bhRadioButton
            // 
            this.bhRadioButton.AutoSize = true;
            this.bhRadioButton.Location = new System.Drawing.Point(12, 12);
            this.bhRadioButton.Name = "bhRadioButton";
            this.bhRadioButton.Size = new System.Drawing.Size(110, 17);
            this.bhRadioButton.TabIndex = 18;
            this.bhRadioButton.Text = "Benjamin Harrison";
            this.bhRadioButton.UseVisualStyleBackColor = true;
            // 
            // fdrRadioButton
            // 
            this.fdrRadioButton.AutoSize = true;
            this.fdrRadioButton.Location = new System.Drawing.Point(12, 35);
            this.fdrRadioButton.Name = "fdrRadioButton";
            this.fdrRadioButton.Size = new System.Drawing.Size(124, 17);
            this.fdrRadioButton.TabIndex = 18;
            this.fdrRadioButton.Text = "Franklin D Roosevelt";
            this.fdrRadioButton.UseVisualStyleBackColor = true;
            // 
            // wjcRadioButton
            // 
            this.wjcRadioButton.AutoSize = true;
            this.wjcRadioButton.Location = new System.Drawing.Point(12, 58);
            this.wjcRadioButton.Name = "wjcRadioButton";
            this.wjcRadioButton.Size = new System.Drawing.Size(101, 17);
            this.wjcRadioButton.TabIndex = 18;
            this.wjcRadioButton.Text = "William J Clinton";
            this.wjcRadioButton.UseVisualStyleBackColor = true;
            // 
            // jbRadioButton
            // 
            this.jbRadioButton.AutoSize = true;
            this.jbRadioButton.Location = new System.Drawing.Point(12, 81);
            this.jbRadioButton.Name = "jbRadioButton";
            this.jbRadioButton.Size = new System.Drawing.Size(107, 17);
            this.jbRadioButton.TabIndex = 18;
            this.jbRadioButton.Text = "James Buchanan";
            this.jbRadioButton.UseVisualStyleBackColor = true;
            // 
            // fpRadioButton
            // 
            this.fpRadioButton.AutoSize = true;
            this.fpRadioButton.Location = new System.Drawing.Point(12, 104);
            this.fpRadioButton.Name = "fpRadioButton";
            this.fpRadioButton.Size = new System.Drawing.Size(95, 17);
            this.fpRadioButton.TabIndex = 18;
            this.fpRadioButton.Text = "Franklin Pierce";
            this.fpRadioButton.UseVisualStyleBackColor = true;
            // 
            // gwbRadioButton
            // 
            this.gwbRadioButton.AutoSize = true;
            this.gwbRadioButton.Location = new System.Drawing.Point(12, 127);
            this.gwbRadioButton.Name = "gwbRadioButton";
            this.gwbRadioButton.Size = new System.Drawing.Size(101, 17);
            this.gwbRadioButton.TabIndex = 18;
            this.gwbRadioButton.Text = "George W Bush";
            this.gwbRadioButton.UseVisualStyleBackColor = true;
            // 
            // boRadioButton
            // 
            this.boRadioButton.AutoSize = true;
            this.boRadioButton.Location = new System.Drawing.Point(12, 150);
            this.boRadioButton.Name = "boRadioButton";
            this.boRadioButton.Size = new System.Drawing.Size(96, 17);
            this.boRadioButton.TabIndex = 18;
            this.boRadioButton.Text = "Barack Obama";
            this.boRadioButton.UseVisualStyleBackColor = true;
            // 
            // jfkRadioButton
            // 
            this.jfkRadioButton.AutoSize = true;
            this.jfkRadioButton.Location = new System.Drawing.Point(12, 173);
            this.jfkRadioButton.Name = "jfkRadioButton";
            this.jfkRadioButton.Size = new System.Drawing.Size(102, 17);
            this.jfkRadioButton.TabIndex = 18;
            this.jfkRadioButton.Text = "John F Kennedy";
            this.jfkRadioButton.UseVisualStyleBackColor = true;
            // 
            // tjRadioButton
            // 
            this.tjRadioButton.AutoSize = true;
            this.tjRadioButton.Location = new System.Drawing.Point(178, 173);
            this.tjRadioButton.Name = "tjRadioButton";
            this.tjRadioButton.Size = new System.Drawing.Size(109, 17);
            this.tjRadioButton.TabIndex = 18;
            this.tjRadioButton.Text = "Thomas Jefferson";
            this.tjRadioButton.UseVisualStyleBackColor = true;
            // 
            // trRadioButton
            // 
            this.trRadioButton.AutoSize = true;
            this.trRadioButton.Location = new System.Drawing.Point(178, 150);
            this.trRadioButton.Name = "trRadioButton";
            this.trRadioButton.Size = new System.Drawing.Size(122, 17);
            this.trRadioButton.TabIndex = 18;
            this.trRadioButton.Text = "Theodore Roosevelt";
            this.trRadioButton.UseVisualStyleBackColor = true;
            // 
            // jaRadioButton
            // 
            this.jaRadioButton.AutoSize = true;
            this.jaRadioButton.Location = new System.Drawing.Point(178, 127);
            this.jaRadioButton.Name = "jaRadioButton";
            this.jaRadioButton.Size = new System.Drawing.Size(83, 17);
            this.jaRadioButton.TabIndex = 18;
            this.jaRadioButton.Text = "John Adams";
            this.jaRadioButton.UseVisualStyleBackColor = true;
            // 
            // gwRadioButton
            // 
            this.gwRadioButton.AutoSize = true;
            this.gwRadioButton.Location = new System.Drawing.Point(178, 104);
            this.gwRadioButton.Name = "gwRadioButton";
            this.gwRadioButton.Size = new System.Drawing.Size(120, 17);
            this.gwRadioButton.TabIndex = 18;
            this.gwRadioButton.Text = "George Washington";
            this.gwRadioButton.UseVisualStyleBackColor = true;
            // 
            // mvbRadioButton
            // 
            this.mvbRadioButton.AutoSize = true;
            this.mvbRadioButton.Location = new System.Drawing.Point(178, 81);
            this.mvbRadioButton.Name = "mvbRadioButton";
            this.mvbRadioButton.Size = new System.Drawing.Size(104, 17);
            this.mvbRadioButton.TabIndex = 18;
            this.mvbRadioButton.Text = "Martin VanBuren";
            this.mvbRadioButton.UseVisualStyleBackColor = true;
            // 
            // ddeRadioButton
            // 
            this.ddeRadioButton.AutoSize = true;
            this.ddeRadioButton.Location = new System.Drawing.Point(178, 58);
            this.ddeRadioButton.Name = "ddeRadioButton";
            this.ddeRadioButton.Size = new System.Drawing.Size(127, 17);
            this.ddeRadioButton.TabIndex = 18;
            this.ddeRadioButton.Text = "Dwight D Eisenhower";
            this.ddeRadioButton.UseVisualStyleBackColor = true;
            // 
            // rrRadioButton
            // 
            this.rrRadioButton.AutoSize = true;
            this.rrRadioButton.Location = new System.Drawing.Point(178, 35);
            this.rrRadioButton.Name = "rrRadioButton";
            this.rrRadioButton.Size = new System.Drawing.Size(100, 17);
            this.rrRadioButton.TabIndex = 18;
            this.rrRadioButton.Text = "Ronald Reagan";
            this.rrRadioButton.UseVisualStyleBackColor = true;
            // 
            // wmRadioButton
            // 
            this.wmRadioButton.AutoSize = true;
            this.wmRadioButton.Location = new System.Drawing.Point(178, 12);
            this.wmRadioButton.Name = "wmRadioButton";
            this.wmRadioButton.Size = new System.Drawing.Size(104, 17);
            this.wmRadioButton.TabIndex = 18;
            this.wmRadioButton.Text = "William McKinley";
            this.wmRadioButton.UseVisualStyleBackColor = true;
            // 
            // bhTextBox
            // 
            this.bhTextBox.Location = new System.Drawing.Point(142, 9);
            this.bhTextBox.Name = "bhTextBox";
            this.bhTextBox.Size = new System.Drawing.Size(30, 20);
            this.bhTextBox.TabIndex = 1;
            this.bhTextBox.Text = "0";
            this.bhTextBox.WordWrap = false;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // fdrTextBox
            // 
            this.fdrTextBox.Location = new System.Drawing.Point(142, 32);
            this.fdrTextBox.Name = "fdrTextBox";
            this.fdrTextBox.Size = new System.Drawing.Size(30, 20);
            this.fdrTextBox.TabIndex = 3;
            this.fdrTextBox.Text = "0";
            this.fdrTextBox.WordWrap = false;
            // 
            // jbTextBox
            // 
            this.jbTextBox.Location = new System.Drawing.Point(142, 78);
            this.jbTextBox.Name = "jbTextBox";
            this.jbTextBox.Size = new System.Drawing.Size(30, 20);
            this.jbTextBox.TabIndex = 7;
            this.jbTextBox.Text = "0";
            this.jbTextBox.WordWrap = false;
            // 
            // wjcTextBox
            // 
            this.wjcTextBox.Location = new System.Drawing.Point(142, 55);
            this.wjcTextBox.Name = "wjcTextBox";
            this.wjcTextBox.Size = new System.Drawing.Size(30, 20);
            this.wjcTextBox.TabIndex = 5;
            this.wjcTextBox.Text = "0";
            this.wjcTextBox.WordWrap = false;
            // 
            // gwbTextBox
            // 
            this.gwbTextBox.Location = new System.Drawing.Point(142, 124);
            this.gwbTextBox.Name = "gwbTextBox";
            this.gwbTextBox.Size = new System.Drawing.Size(30, 20);
            this.gwbTextBox.TabIndex = 11;
            this.gwbTextBox.Text = "0";
            this.gwbTextBox.WordWrap = false;
            // 
            // fpTextBox
            // 
            this.fpTextBox.Location = new System.Drawing.Point(142, 101);
            this.fpTextBox.Name = "fpTextBox";
            this.fpTextBox.Size = new System.Drawing.Size(30, 20);
            this.fpTextBox.TabIndex = 9;
            this.fpTextBox.Text = "0";
            this.fpTextBox.WordWrap = false;
            // 
            // jfkTextBox
            // 
            this.jfkTextBox.Location = new System.Drawing.Point(142, 170);
            this.jfkTextBox.Name = "jfkTextBox";
            this.jfkTextBox.Size = new System.Drawing.Size(30, 20);
            this.jfkTextBox.TabIndex = 15;
            this.jfkTextBox.Text = "0";
            this.jfkTextBox.WordWrap = false;
            // 
            // boTextBox
            // 
            this.boTextBox.Location = new System.Drawing.Point(142, 147);
            this.boTextBox.Name = "boTextBox";
            this.boTextBox.Size = new System.Drawing.Size(30, 20);
            this.boTextBox.TabIndex = 13;
            this.boTextBox.Text = "0";
            this.boTextBox.WordWrap = false;
            // 
            // tjTextBox
            // 
            this.tjTextBox.Location = new System.Drawing.Point(311, 173);
            this.tjTextBox.Name = "tjTextBox";
            this.tjTextBox.Size = new System.Drawing.Size(30, 20);
            this.tjTextBox.TabIndex = 16;
            this.tjTextBox.Text = "0";
            this.tjTextBox.WordWrap = false;
            // 
            // trTextBox
            // 
            this.trTextBox.Location = new System.Drawing.Point(311, 150);
            this.trTextBox.Name = "trTextBox";
            this.trTextBox.Size = new System.Drawing.Size(30, 20);
            this.trTextBox.TabIndex = 14;
            this.trTextBox.Text = "0";
            this.trTextBox.WordWrap = false;
            // 
            // jaTextBox
            // 
            this.jaTextBox.Location = new System.Drawing.Point(311, 127);
            this.jaTextBox.Name = "jaTextBox";
            this.jaTextBox.Size = new System.Drawing.Size(30, 20);
            this.jaTextBox.TabIndex = 12;
            this.jaTextBox.Text = "0";
            this.jaTextBox.WordWrap = false;
            // 
            // gwTextBox
            // 
            this.gwTextBox.Location = new System.Drawing.Point(311, 104);
            this.gwTextBox.Name = "gwTextBox";
            this.gwTextBox.Size = new System.Drawing.Size(30, 20);
            this.gwTextBox.TabIndex = 10;
            this.gwTextBox.Text = "0";
            this.gwTextBox.WordWrap = false;
            // 
            // mvbTextBox
            // 
            this.mvbTextBox.Location = new System.Drawing.Point(311, 81);
            this.mvbTextBox.Name = "mvbTextBox";
            this.mvbTextBox.Size = new System.Drawing.Size(30, 20);
            this.mvbTextBox.TabIndex = 8;
            this.mvbTextBox.Text = "0";
            this.mvbTextBox.WordWrap = false;
            // 
            // ddeTextBox
            // 
            this.ddeTextBox.Location = new System.Drawing.Point(311, 58);
            this.ddeTextBox.Name = "ddeTextBox";
            this.ddeTextBox.Size = new System.Drawing.Size(30, 20);
            this.ddeTextBox.TabIndex = 6;
            this.ddeTextBox.Text = "0";
            this.ddeTextBox.WordWrap = false;
            // 
            // rrTextBox
            // 
            this.rrTextBox.Location = new System.Drawing.Point(311, 35);
            this.rrTextBox.Name = "rrTextBox";
            this.rrTextBox.Size = new System.Drawing.Size(30, 20);
            this.rrTextBox.TabIndex = 4;
            this.rrTextBox.Text = "0";
            this.rrTextBox.WordWrap = false;
            // 
            // wmTextBox
            // 
            this.wmTextBox.Location = new System.Drawing.Point(311, 12);
            this.wmTextBox.Name = "wmTextBox";
            this.wmTextBox.Size = new System.Drawing.Size(30, 20);
            this.wmTextBox.TabIndex = 2;
            this.wmTextBox.Text = "0";
            this.wmTextBox.WordWrap = false;
            // 
            // presidentsToolTip
            // 
            this.presidentsToolTip.IsBalloon = true;
            this.presidentsToolTip.ToolTipTitle = "Which # President";
            // 
            // timer
            // 
            this.timer.Interval = 50;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 580);
            this.Controls.Add(this.tjTextBox);
            this.Controls.Add(this.trTextBox);
            this.Controls.Add(this.jaTextBox);
            this.Controls.Add(this.gwTextBox);
            this.Controls.Add(this.mvbTextBox);
            this.Controls.Add(this.ddeTextBox);
            this.Controls.Add(this.rrTextBox);
            this.Controls.Add(this.wmTextBox);
            this.Controls.Add(this.jfkTextBox);
            this.Controls.Add(this.boTextBox);
            this.Controls.Add(this.gwbTextBox);
            this.Controls.Add(this.fpTextBox);
            this.Controls.Add(this.jbTextBox);
            this.Controls.Add(this.wjcTextBox);
            this.Controls.Add(this.fdrTextBox);
            this.Controls.Add(this.bhTextBox);
            this.Controls.Add(this.tjRadioButton);
            this.Controls.Add(this.trRadioButton);
            this.Controls.Add(this.jaRadioButton);
            this.Controls.Add(this.gwRadioButton);
            this.Controls.Add(this.mvbRadioButton);
            this.Controls.Add(this.ddeRadioButton);
            this.Controls.Add(this.rrRadioButton);
            this.Controls.Add(this.wmRadioButton);
            this.Controls.Add(this.jfkRadioButton);
            this.Controls.Add(this.boRadioButton);
            this.Controls.Add(this.gwbRadioButton);
            this.Controls.Add(this.fpRadioButton);
            this.Controls.Add(this.jbRadioButton);
            this.Controls.Add(this.wjcRadioButton);
            this.Controls.Add(this.fdrRadioButton);
            this.Controls.Add(this.bhRadioButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.filterGroupBox);
            this.Controls.Add(this.webGroupBox);
            this.Name = "Form";
            this.webGroupBox.ResumeLayout(false);
            this.filterGroupBox.ResumeLayout(false);
            this.filterGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.GroupBox webGroupBox;
        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.GroupBox filterGroupBox;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.RadioButton bhRadioButton;
        private System.Windows.Forms.RadioButton fdrRadioButton;
        private System.Windows.Forms.RadioButton wjcRadioButton;
        private System.Windows.Forms.RadioButton jbRadioButton;
        private System.Windows.Forms.RadioButton fpRadioButton;
        private System.Windows.Forms.RadioButton gwbRadioButton;
        private System.Windows.Forms.RadioButton boRadioButton;
        private System.Windows.Forms.RadioButton jfkRadioButton;
        private System.Windows.Forms.RadioButton tjRadioButton;
        private System.Windows.Forms.RadioButton trRadioButton;
        private System.Windows.Forms.RadioButton jaRadioButton;
        private System.Windows.Forms.RadioButton gwRadioButton;
        private System.Windows.Forms.RadioButton mvbRadioButton;
        private System.Windows.Forms.RadioButton ddeRadioButton;
        private System.Windows.Forms.RadioButton rrRadioButton;
        private System.Windows.Forms.RadioButton wmRadioButton;
        protected System.Windows.Forms.TextBox bhTextBox;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.RadioButton fedRadioButton;
        private System.Windows.Forms.RadioButton drRadioButton;
        private System.Windows.Forms.RadioButton repRadioButton;
        private System.Windows.Forms.RadioButton demRadioButton;
        private System.Windows.Forms.RadioButton allRadioButton;
        protected System.Windows.Forms.TextBox tjTextBox;
        protected System.Windows.Forms.TextBox trTextBox;
        protected System.Windows.Forms.TextBox jaTextBox;
        protected System.Windows.Forms.TextBox gwTextBox;
        protected System.Windows.Forms.TextBox mvbTextBox;
        protected System.Windows.Forms.TextBox ddeTextBox;
        protected System.Windows.Forms.TextBox rrTextBox;
        protected System.Windows.Forms.TextBox wmTextBox;
        protected System.Windows.Forms.TextBox jfkTextBox;
        protected System.Windows.Forms.TextBox boTextBox;
        protected System.Windows.Forms.TextBox gwbTextBox;
        protected System.Windows.Forms.TextBox fpTextBox;
        protected System.Windows.Forms.TextBox jbTextBox;
        protected System.Windows.Forms.TextBox wjcTextBox;
        protected System.Windows.Forms.TextBox fdrTextBox;
        private System.Windows.Forms.ToolTip presidentsToolTip;
        private System.Windows.Forms.Timer timer;
    }
}

