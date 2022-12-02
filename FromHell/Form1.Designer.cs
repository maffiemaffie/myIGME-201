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
            this.filtersButton = new System.Windows.Forms.Button();
            this.rosterButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.generateButton = new System.Windows.Forms.Button();
            this.popupGroupBox = new System.Windows.Forms.GroupBox();
            this.generateGroupBox = new System.Windows.Forms.GroupBox();
            this.infoTabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.bioTextBox = new System.Windows.Forms.RichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.infoTextBox = new System.Windows.Forms.RichTextBox();
            this.infoGroupBox = new System.Windows.Forms.GroupBox();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.popupGroupBox.SuspendLayout();
            this.generateGroupBox.SuspendLayout();
            this.infoTabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.infoGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // filtersButton
            // 
            this.filtersButton.BackColor = System.Drawing.Color.Yellow;
            this.filtersButton.Font = new System.Drawing.Font("Wide Latin", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filtersButton.ForeColor = System.Drawing.Color.Cyan;
            this.filtersButton.Location = new System.Drawing.Point(21, 19);
            this.filtersButton.Name = "filtersButton";
            this.filtersButton.Size = new System.Drawing.Size(111, 23);
            this.filtersButton.TabIndex = 1;
            this.filtersButton.Tag = "Bounce";
            this.filtersButton.Text = "Filters...";
            this.filtersButton.UseVisualStyleBackColor = false;
            // 
            // rosterButton
            // 
            this.rosterButton.BackColor = System.Drawing.Color.Cyan;
            this.rosterButton.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rosterButton.ForeColor = System.Drawing.Color.Yellow;
            this.rosterButton.Location = new System.Drawing.Point(21, 48);
            this.rosterButton.Name = "rosterButton";
            this.rosterButton.Size = new System.Drawing.Size(111, 23);
            this.rosterButton.TabIndex = 2;
            this.rosterButton.Tag = "Bounce";
            this.rosterButton.Text = "Cat Roster...";
            this.rosterButton.UseVisualStyleBackColor = false;
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Red;
            this.exitButton.Font = new System.Drawing.Font("Ravie", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.Fuchsia;
            this.exitButton.Location = new System.Drawing.Point(713, 406);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 32);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            // 
            // generateButton
            // 
            this.generateButton.BackColor = System.Drawing.Color.Lime;
            this.generateButton.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateButton.ForeColor = System.Drawing.Color.Fuchsia;
            this.generateButton.Location = new System.Drawing.Point(6, 13);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(188, 37);
            this.generateButton.TabIndex = 4;
            this.generateButton.Tag = "Bounce";
            this.generateButton.Text = "Randomize Cat ^_^";
            this.generateButton.UseVisualStyleBackColor = false;
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
            this.popupGroupBox.Tag = "BounceBox";
            // 
            // generateGroupBox
            // 
            this.generateGroupBox.Controls.Add(this.generateButton);
            this.generateGroupBox.Location = new System.Drawing.Point(12, 12);
            this.generateGroupBox.Name = "generateGroupBox";
            this.generateGroupBox.Size = new System.Drawing.Size(200, 100);
            this.generateGroupBox.TabIndex = 6;
            this.generateGroupBox.TabStop = false;
            this.generateGroupBox.Tag = "BounceBox";
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
            this.tabPage1.Controls.Add(this.bioTextBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(180, 163);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Bio";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // bioTextBox
            // 
            this.bioTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bioTextBox.Enabled = false;
            this.bioTextBox.Location = new System.Drawing.Point(3, 3);
            this.bioTextBox.Name = "bioTextBox";
            this.bioTextBox.Size = new System.Drawing.Size(174, 157);
            this.bioTextBox.TabIndex = 0;
            this.bioTextBox.Text = "";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.infoTextBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(180, 163);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Basic Info";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // infoTextBox
            // 
            this.infoTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.infoTextBox.Enabled = false;
            this.infoTextBox.Location = new System.Drawing.Point(3, 3);
            this.infoTextBox.Name = "infoTextBox";
            this.infoTextBox.Size = new System.Drawing.Size(174, 157);
            this.infoTextBox.TabIndex = 0;
            this.infoTextBox.Text = "";
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
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(233, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(334, 426);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.infoGroupBox);
            this.Controls.Add(this.generateGroupBox);
            this.Controls.Add(this.popupGroupBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.pictureBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.popupGroupBox.ResumeLayout(false);
            this.generateGroupBox.ResumeLayout(false);
            this.infoTabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.infoGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
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
        private System.Windows.Forms.RichTextBox infoTextBox;
        private System.Windows.Forms.RichTextBox bioTextBox;
    }
}

