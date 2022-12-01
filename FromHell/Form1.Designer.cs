namespace FromHell
{
    partial class Form1
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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.filtersButton = new System.Windows.Forms.Button();
            this.rosterButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.generateButton = new System.Windows.Forms.Button();
            this.popupGroupBox = new System.Windows.Forms.GroupBox();
            this.generateGroupBox = new System.Windows.Forms.GroupBox();
            this.infoTabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.infoGroupBox = new System.Windows.Forms.GroupBox();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.popupGroupBox.SuspendLayout();
            this.generateGroupBox.SuspendLayout();
            this.infoTabControl.SuspendLayout();
            this.infoGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(233, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(334, 426);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // filtersButton
            // 
            this.filtersButton.Location = new System.Drawing.Point(21, 19);
            this.filtersButton.Name = "filtersButton";
            this.filtersButton.Size = new System.Drawing.Size(75, 23);
            this.filtersButton.TabIndex = 1;
            this.filtersButton.Text = "Filters...";
            this.filtersButton.UseVisualStyleBackColor = true;
            // 
            // rosterButton
            // 
            this.rosterButton.Location = new System.Drawing.Point(21, 48);
            this.rosterButton.Name = "rosterButton";
            this.rosterButton.Size = new System.Drawing.Size(75, 23);
            this.rosterButton.TabIndex = 2;
            this.rosterButton.Text = "Cat Roster...";
            this.rosterButton.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(713, 415);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(6, 13);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(188, 23);
            this.generateButton.TabIndex = 4;
            this.generateButton.Text = "Randomize Cat ^_^";
            this.generateButton.UseVisualStyleBackColor = true;
            // 
            // popupGroupBox
            // 
            this.popupGroupBox.Controls.Add(this.filtersButton);
            this.popupGroupBox.Controls.Add(this.rosterButton);
            this.popupGroupBox.Location = new System.Drawing.Point(588, 12);
            this.popupGroupBox.Name = "popupGroupBox";
            this.popupGroupBox.Size = new System.Drawing.Size(200, 281);
            this.popupGroupBox.TabIndex = 5;
            this.popupGroupBox.TabStop = false;
            // 
            // generateGroupBox
            // 
            this.generateGroupBox.Controls.Add(this.generateButton);
            this.generateGroupBox.Location = new System.Drawing.Point(12, 12);
            this.generateGroupBox.Name = "generateGroupBox";
            this.generateGroupBox.Size = new System.Drawing.Size(200, 100);
            this.generateGroupBox.TabIndex = 6;
            this.generateGroupBox.TabStop = false;
            // 
            // infoTabControl
            // 
            this.infoTabControl.Controls.Add(this.tabPage1);
            this.infoTabControl.Controls.Add(this.tabPage2);
            this.infoTabControl.Location = new System.Drawing.Point(6, 19);
            this.infoTabControl.Name = "infoTabControl";
            this.infoTabControl.SelectedIndex = 0;
            this.infoTabControl.Size = new System.Drawing.Size(188, 189);
            this.infoTabControl.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(180, 163);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Bio";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(180, 163);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Basic Info";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // infoGroupBox
            // 
            this.infoGroupBox.Controls.Add(this.infoTabControl);
            this.infoGroupBox.Location = new System.Drawing.Point(12, 118);
            this.infoGroupBox.Name = "infoGroupBox";
            this.infoGroupBox.Size = new System.Drawing.Size(200, 212);
            this.infoGroupBox.TabIndex = 8;
            this.infoGroupBox.TabStop = false;
            this.infoGroupBox.Text = "Cat Details";
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon.BalloonTipText = "meowmeowmeowmeowmeowmeowmeowmeowmeowmeowmeowmeowmeowmeowmeowmeow";
            this.notifyIcon.BalloonTipTitle = "meow :3333";
            this.notifyIcon.Text = "catacatacatacatacatacatacat";
            this.notifyIcon.Visible = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.infoGroupBox);
            this.Controls.Add(this.generateGroupBox);
            this.Controls.Add(this.popupGroupBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.pictureBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.popupGroupBox.ResumeLayout(false);
            this.generateGroupBox.ResumeLayout(false);
            this.infoTabControl.ResumeLayout(false);
            this.infoGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button filtersButton;
        private System.Windows.Forms.Button rosterButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.GroupBox popupGroupBox;
        private System.Windows.Forms.GroupBox generateGroupBox;
        private System.Windows.Forms.TabControl infoTabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox infoGroupBox;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.Timer timer;
    }
}

