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
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.catGridGroupBox = new System.Windows.Forms.GroupBox();
            this.colorsGroupBox = new System.Windows.Forms.GroupBox();
            this.orangeRadioButton = new System.Windows.Forms.RadioButton();
            this.greyRadioButton = new System.Windows.Forms.RadioButton();
            this.blackRadioButton = new System.Windows.Forms.RadioButton();
            this.whiteRadioButton = new System.Windows.Forms.RadioButton();
            this.normalRadioButton = new System.Windows.Forms.RadioButton();
            this.sillyRadioButton = new System.Windows.Forms.RadioButton();
            this.quirkyRadioButton = new System.Windows.Forms.RadioButton();
            this.sillynessGroupBox = new System.Windows.Forms.GroupBox();
            this.exitGroupBox = new System.Windows.Forms.GroupBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.selectButton = new System.Windows.Forms.Button();
            this.allRadioButton = new System.Windows.Forms.RadioButton();
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
            // catGridGroupBox
            // 
            this.catGridGroupBox.Location = new System.Drawing.Point(305, 12);
            this.catGridGroupBox.Name = "catGridGroupBox";
            this.catGridGroupBox.Size = new System.Drawing.Size(483, 426);
            this.catGridGroupBox.TabIndex = 0;
            this.catGridGroupBox.TabStop = false;
            // 
            // colorsGroupBox
            // 
            this.colorsGroupBox.Controls.Add(this.whiteRadioButton);
            this.colorsGroupBox.Controls.Add(this.blackRadioButton);
            this.colorsGroupBox.Controls.Add(this.greyRadioButton);
            this.colorsGroupBox.Controls.Add(this.orangeRadioButton);
            this.colorsGroupBox.Location = new System.Drawing.Point(12, 12);
            this.colorsGroupBox.Name = "colorsGroupBox";
            this.colorsGroupBox.Size = new System.Drawing.Size(128, 118);
            this.colorsGroupBox.TabIndex = 1;
            this.colorsGroupBox.TabStop = false;
            this.colorsGroupBox.Text = "Color";
            // 
            // orangeRadioButton
            // 
            this.orangeRadioButton.AutoSize = true;
            this.orangeRadioButton.Location = new System.Drawing.Point(7, 20);
            this.orangeRadioButton.Name = "orangeRadioButton";
            this.orangeRadioButton.Size = new System.Drawing.Size(60, 17);
            this.orangeRadioButton.TabIndex = 0;
            this.orangeRadioButton.TabStop = true;
            this.orangeRadioButton.Text = "Orange";
            this.orangeRadioButton.UseVisualStyleBackColor = true;
            // 
            // greyRadioButton
            // 
            this.greyRadioButton.AutoSize = true;
            this.greyRadioButton.Location = new System.Drawing.Point(7, 44);
            this.greyRadioButton.Name = "greyRadioButton";
            this.greyRadioButton.Size = new System.Drawing.Size(47, 17);
            this.greyRadioButton.TabIndex = 1;
            this.greyRadioButton.TabStop = true;
            this.greyRadioButton.Text = "Grey";
            this.greyRadioButton.UseVisualStyleBackColor = true;
            // 
            // blackRadioButton
            // 
            this.blackRadioButton.AutoSize = true;
            this.blackRadioButton.Location = new System.Drawing.Point(7, 68);
            this.blackRadioButton.Name = "blackRadioButton";
            this.blackRadioButton.Size = new System.Drawing.Size(52, 17);
            this.blackRadioButton.TabIndex = 2;
            this.blackRadioButton.TabStop = true;
            this.blackRadioButton.Text = "Black";
            this.blackRadioButton.UseVisualStyleBackColor = true;
            // 
            // whiteRadioButton
            // 
            this.whiteRadioButton.AutoSize = true;
            this.whiteRadioButton.Location = new System.Drawing.Point(7, 92);
            this.whiteRadioButton.Name = "whiteRadioButton";
            this.whiteRadioButton.Size = new System.Drawing.Size(53, 17);
            this.whiteRadioButton.TabIndex = 3;
            this.whiteRadioButton.TabStop = true;
            this.whiteRadioButton.Text = "White";
            this.whiteRadioButton.UseVisualStyleBackColor = true;
            // 
            // normalRadioButton
            // 
            this.normalRadioButton.AutoSize = true;
            this.normalRadioButton.Location = new System.Drawing.Point(6, 21);
            this.normalRadioButton.Name = "normalRadioButton";
            this.normalRadioButton.Size = new System.Drawing.Size(58, 17);
            this.normalRadioButton.TabIndex = 3;
            this.normalRadioButton.TabStop = true;
            this.normalRadioButton.Text = "Normal";
            this.normalRadioButton.UseVisualStyleBackColor = true;
            // 
            // sillyRadioButton
            // 
            this.sillyRadioButton.AutoSize = true;
            this.sillyRadioButton.Location = new System.Drawing.Point(6, 67);
            this.sillyRadioButton.Name = "sillyRadioButton";
            this.sillyRadioButton.Size = new System.Drawing.Size(43, 17);
            this.sillyRadioButton.TabIndex = 2;
            this.sillyRadioButton.TabStop = true;
            this.sillyRadioButton.Text = "Silly";
            this.sillyRadioButton.UseVisualStyleBackColor = true;
            // 
            // quirkyRadioButton
            // 
            this.quirkyRadioButton.AutoSize = true;
            this.quirkyRadioButton.Location = new System.Drawing.Point(6, 44);
            this.quirkyRadioButton.Name = "quirkyRadioButton";
            this.quirkyRadioButton.Size = new System.Drawing.Size(55, 17);
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
            // exitGroupBox
            // 
            this.exitGroupBox.Controls.Add(this.selectButton);
            this.exitGroupBox.Controls.Add(this.cancelButton);
            this.exitGroupBox.Location = new System.Drawing.Point(12, 136);
            this.exitGroupBox.Name = "exitGroupBox";
            this.exitGroupBox.Size = new System.Drawing.Size(275, 302);
            this.exitGroupBox.TabIndex = 5;
            this.exitGroupBox.TabStop = false;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(7, 273);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 0;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // selectButton
            // 
            this.selectButton.Location = new System.Drawing.Point(89, 272);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(75, 23);
            this.selectButton.TabIndex = 1;
            this.selectButton.Text = "Select";
            this.selectButton.UseVisualStyleBackColor = true;
            // 
            // allRadioButton
            // 
            this.allRadioButton.AutoSize = true;
            this.allRadioButton.Location = new System.Drawing.Point(6, 90);
            this.allRadioButton.Name = "allRadioButton";
            this.allRadioButton.Size = new System.Drawing.Size(36, 17);
            this.allRadioButton.TabIndex = 4;
            this.allRadioButton.TabStop = true;
            this.allRadioButton.Text = "All";
            this.allRadioButton.UseVisualStyleBackColor = true;
            // 
            // FiltersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exitGroupBox);
            this.Controls.Add(this.sillynessGroupBox);
            this.Controls.Add(this.colorsGroupBox);
            this.Controls.Add(this.catGridGroupBox);
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
        private System.Windows.Forms.GroupBox catGridGroupBox;
        private System.Windows.Forms.GroupBox exitGroupBox;
        private System.Windows.Forms.Button selectButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.RadioButton allRadioButton;
    }
}