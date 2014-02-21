using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace Hangman
{
    public partial class Form1 : Form
    {

        #region Variables
        private String[] WordBank = new WebClient().DownloadString("http://docs.oracle.com/javase/tutorial/collections/interfaces/examples/dictionary.txt").ToUpper().Split('\n');
        //{ "HIPPOPOTAMUS", "CHEESE", "ZOMBIE", "MEMBER", "TRIUMPH", "ZINGER", "HEY", "HARRIS", "GALAXY", "DOG" };
        private String currentWord;
        private int numOfFails = 0;
        #endregion

        #region Initialize
        public Form1()
        {
            InitializeComponent();
            pickWord();
            pictureBoxHangman.ImageLocation = "../../Images/" + ++numOfFails + ".jpg";
        }

        private void pickWord()
        {
            currentWord = WordBank[new Random().Next(WordBank.Length)];
            labelShowWord.ResetText();
            for (int i = 0; i < currentWord.Length; i++)
                labelShowWord.Text += "_";
            labelWord.Text = "Word (" + currentWord.Length + ")";
        }

        #endregion

        #region Only Allow Letters In Text Box
        private void textBoxUserInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }
        #endregion

        #region Check If The Entered Letter Is Within The Chosen String
        private void buttonSubmitLetter_Click(object sender, EventArgs e)
        {
            //If text box is blank, clear
            if (textBoxUserInput.Text == "")
            {
                MessageBox.Show("Please choose a letter!");
                return;
            }

            char testLetter = textBoxUserInput.Text.ToUpper().ToCharArray()[0];
            
            //Don't want the user trying a letter multiple times!
            if (labelListOfBadLetters.Text.Contains(testLetter) || labelShowWord.Text.Contains(testLetter))
            {
                textBoxUserInput.Clear();
                textBoxUserInput.Focus();
                return;
            }

            //If the word has what we want
            if (currentWord.Contains(testLetter))
            {
                //Look through the word to find all matches
                for(int i = 0; i < currentWord.Length; i++)
                {
                    //If a match, replace the character at the index with the correct letter.
                    if (currentWord[i] == testLetter)
                    {
                        StringBuilder sb = new StringBuilder(labelShowWord.Text);
                        sb[i] = testLetter;
                        labelShowWord.Text = sb.ToString();
                    }
                }
            }
            //Word does not have what we want
            else
            {
                //If the label is blank, set the letter, otherwise
                if (labelListOfBadLetters.Text == "")
                    labelListOfBadLetters.Text = testLetter.ToString();
                //Add the letter to the label
                else
                    labelListOfBadLetters.Text += ", " + testLetter;
                //Increment the hangman!
                pictureBoxHangman.ImageLocation = "../../Images/" + ++numOfFails + ".jpg";
            }
            textBoxUserInput.Clear();
            textBoxUserInput.Focus();

            //Check for win condition
            if(labelShowWord.Text == currentWord)
            {
                endGame("You won! Play again?", "Win");
            }

            //Check for lose condition
            if(numOfFails > 6)
            {
                endGame("You lost! The word was " + currentWord + " Play again?", "Lose");
            }
        }
        #endregion

        #region Reset The Game
        private void endGame(String message, String header)
        {
            //Create a message box and ask the user to play again.
            DialogResult playAgain = MessageBox.Show(message,header, MessageBoxButtons.YesNo);
            //If the user says Yes, reset the game.
            if (playAgain == System.Windows.Forms.DialogResult.Yes)
            {
                numOfFails = 0;
                pictureBoxHangman.ImageLocation = "../../Images/" + ++numOfFails + ".jpg";
                labelShowWord.Text = "______";
                labelListOfBadLetters.Text = "";
                pickWord();
            }
            //If no, end!
            else
            {
                MessageBox.Show("Thanks for playing!");
                Application.Exit();
            }
        }
        #endregion

    }
}
