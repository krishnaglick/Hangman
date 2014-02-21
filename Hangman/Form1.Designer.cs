namespace Hangman
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
            this.textBoxUserInput = new System.Windows.Forms.TextBox();
            this.labelTextboxInstructions = new System.Windows.Forms.Label();
            this.labelWord = new System.Windows.Forms.Label();
            this.pictureBoxHangman = new System.Windows.Forms.PictureBox();
            this.labelShowWord = new System.Windows.Forms.Label();
            this.labelListOfBadLetters = new System.Windows.Forms.Label();
            this.labelLetterTrackerText = new System.Windows.Forms.Label();
            this.buttonSubmitLetter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHangman)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxUserInput
            // 
            this.textBoxUserInput.Location = new System.Drawing.Point(326, 194);
            this.textBoxUserInput.MaxLength = 1;
            this.textBoxUserInput.Name = "textBoxUserInput";
            this.textBoxUserInput.Size = new System.Drawing.Size(100, 20);
            this.textBoxUserInput.TabIndex = 0;
            this.textBoxUserInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxUserInput_KeyPress);
            // 
            // labelTextboxInstructions
            // 
            this.labelTextboxInstructions.AutoSize = true;
            this.labelTextboxInstructions.Location = new System.Drawing.Point(238, 197);
            this.labelTextboxInstructions.Name = "labelTextboxInstructions";
            this.labelTextboxInstructions.Size = new System.Drawing.Size(82, 13);
            this.labelTextboxInstructions.TabIndex = 1;
            this.labelTextboxInstructions.Text = "Choose a Letter";
            // 
            // labelWord
            // 
            this.labelWord.AutoSize = true;
            this.labelWord.Location = new System.Drawing.Point(247, 143);
            this.labelWord.Name = "labelWord";
            this.labelWord.Size = new System.Drawing.Size(33, 13);
            this.labelWord.TabIndex = 2;
            this.labelWord.Text = "Word";
            // 
            // pictureBoxHangman
            // 
            this.pictureBoxHangman.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxHangman.Name = "pictureBoxHangman";
            this.pictureBoxHangman.Size = new System.Drawing.Size(220, 231);
            this.pictureBoxHangman.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxHangman.TabIndex = 3;
            this.pictureBoxHangman.TabStop = false;
            // 
            // labelShowWord
            // 
            this.labelShowWord.AutoSize = true;
            this.labelShowWord.Location = new System.Drawing.Point(247, 156);
            this.labelShowWord.Name = "labelShowWord";
            this.labelShowWord.Size = new System.Drawing.Size(0, 13);
            this.labelShowWord.TabIndex = 4;
            // 
            // labelListOfBadLetters
            // 
            this.labelListOfBadLetters.AutoSize = true;
            this.labelListOfBadLetters.Location = new System.Drawing.Point(358, 156);
            this.labelListOfBadLetters.Name = "labelListOfBadLetters";
            this.labelListOfBadLetters.Size = new System.Drawing.Size(0, 13);
            this.labelListOfBadLetters.TabIndex = 5;
            // 
            // labelLetterTrackerText
            // 
            this.labelLetterTrackerText.AutoSize = true;
            this.labelLetterTrackerText.Location = new System.Drawing.Point(358, 143);
            this.labelLetterTrackerText.Name = "labelLetterTrackerText";
            this.labelLetterTrackerText.Size = new System.Drawing.Size(61, 13);
            this.labelLetterTrackerText.TabIndex = 6;
            this.labelLetterTrackerText.Text = "Bad Letters";
            // 
            // buttonSubmitLetter
            // 
            this.buttonSubmitLetter.Location = new System.Drawing.Point(351, 220);
            this.buttonSubmitLetter.Name = "buttonSubmitLetter";
            this.buttonSubmitLetter.Size = new System.Drawing.Size(75, 23);
            this.buttonSubmitLetter.TabIndex = 7;
            this.buttonSubmitLetter.Text = "Submit";
            this.buttonSubmitLetter.UseVisualStyleBackColor = true;
            this.buttonSubmitLetter.Click += new System.EventHandler(this.buttonSubmitLetter_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.buttonSubmitLetter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 251);
            this.Controls.Add(this.buttonSubmitLetter);
            this.Controls.Add(this.labelLetterTrackerText);
            this.Controls.Add(this.labelListOfBadLetters);
            this.Controls.Add(this.labelShowWord);
            this.Controls.Add(this.pictureBoxHangman);
            this.Controls.Add(this.labelWord);
            this.Controls.Add(this.labelTextboxInstructions);
            this.Controls.Add(this.textBoxUserInput);
            this.Name = "Form1";
            this.Text = "Hang-A-Bro";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHangman)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxUserInput;
        private System.Windows.Forms.Label labelTextboxInstructions;
        private System.Windows.Forms.Label labelWord;
        private System.Windows.Forms.PictureBox pictureBoxHangman;
        private System.Windows.Forms.Label labelShowWord;
        private System.Windows.Forms.Label labelListOfBadLetters;
        private System.Windows.Forms.Label labelLetterTrackerText;
        private System.Windows.Forms.Button buttonSubmitLetter;
    }
}

