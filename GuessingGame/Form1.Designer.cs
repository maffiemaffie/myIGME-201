namespace GuessingGame
{
    partial class SettingsForm
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
            this.instructionLabel = new System.Windows.Forms.Label();
            this.lowLabel = new System.Windows.Forms.Label();
            this.highLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.lowTextBox = new System.Windows.Forms.TextBox();
            this.highTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // instructionLabel
            // 
            this.instructionLabel.AutoSize = true;
            this.instructionLabel.Location = new System.Drawing.Point(34, 15);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(159, 13);
            this.instructionLabel.TabIndex = 0;
            this.instructionLabel.Text = "Enter Range of Values to Guess";
            // 
            // lowLabel
            // 
            this.lowLabel.AutoSize = true;
            this.lowLabel.Location = new System.Drawing.Point(18, 43);
            this.lowLabel.Name = "lowLabel";
            this.lowLabel.Size = new System.Drawing.Size(70, 13);
            this.lowLabel.TabIndex = 1;
            this.lowLabel.Text = "Low Number:";
            // 
            // highLabel
            // 
            this.highLabel.AutoSize = true;
            this.highLabel.Location = new System.Drawing.Point(16, 79);
            this.highLabel.Name = "highLabel";
            this.highLabel.Size = new System.Drawing.Size(72, 13);
            this.highLabel.TabIndex = 2;
            this.highLabel.Text = "High Number:";
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(78, 117);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 5;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            // 
            // lowTextBox
            // 
            this.lowTextBox.Location = new System.Drawing.Point(107, 43);
            this.lowTextBox.Name = "lowTextBox";
            this.lowTextBox.Size = new System.Drawing.Size(100, 20);
            this.lowTextBox.TabIndex = 6;
            this.lowTextBox.Text = "1";
            // 
            // highTextBox
            // 
            this.highTextBox.Location = new System.Drawing.Point(107, 76);
            this.highTextBox.Name = "highTextBox";
            this.highTextBox.Size = new System.Drawing.Size(100, 20);
            this.highTextBox.TabIndex = 7;
            this.highTextBox.Text = "100";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(231, 152);
            this.Controls.Add(this.highTextBox);
            this.Controls.Add(this.lowTextBox);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.highLabel);
            this.Controls.Add(this.lowLabel);
            this.Controls.Add(this.instructionLabel);
            this.Name = "SettingsForm";
            this.Text = "Guessing Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label instructionLabel;
        private System.Windows.Forms.Label lowLabel;
        private System.Windows.Forms.Label highLabel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.TextBox lowTextBox;
        private System.Windows.Forms.TextBox highTextBox;
    }
}

