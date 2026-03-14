using System;
using System.Text;
using System.Windows.Forms;

namespace WordGuessApplication
{
    public partial class frmGuessWord : Form
    {
        // Array of words to guess (multiple words)
        string[] words = { "computer", "keyboard", "monitor", "programming", "software" };

        // Track the current word index
        int currentWordIndex = 0;

        // Score tracking
        int correctCount = 0;
        int wrongCount = 0;

        // Attempts limit per word
        int maxAttempts = 5;
        int currentAttempts = 0;

        public frmGuessWord()
        {
            InitializeComponent();
        }

        // Form Load event - set up the first word
        private void frmGuessWord_Load(object sender, EventArgs e)
        {
            // Display the hint for the first word
            DisplayHint();
            UpdateScoreLabel();
            UpdateAttemptsLabel();
        }

        // Method to display the hint using StringBuilder
        private void DisplayHint()
        {
            string currentWord = words[currentWordIndex];

            // Use StringBuilder to build the hint
            StringBuilder hint = new StringBuilder();

            for (int i = 0; i < currentWord.Length; i++)
            {
                // Show first and last letter, hide the rest with '?'
                if (i == 0 || i == currentWord.Length - 1)
                {
                    hint.Append(currentWord[i]);
                }
                else
                {
                    hint.Append("?");
                }
            }

            // Display the hint in the label
            lblWord.Text = hint.ToString();
        }

        // Method to update the score label
        private void UpdateScoreLabel()
        {
            lblScore.Text = "Correct: " + correctCount + "  |  Wrong: " + wrongCount;
        }

        // Method to update the attempts label
        private void UpdateAttemptsLabel()
        {
            int remaining = maxAttempts - currentAttempts;
            lblAttempts.Text = "Attempts left: " + remaining + " / " + maxAttempts;
        }

        // Method to move to the next word
        private void NextWord()
        {
            currentWordIndex++;
            currentAttempts = 0;
            lstWrongGuess.Items.Clear();

            // Check if there are more words
            if (currentWordIndex < words.Length)
            {
                DisplayHint();
                UpdateAttemptsLabel();
            }
            else
            {
                
                btnGuess.Enabled = false;
                txtGuess.Enabled = false;

                if(correctCount == words.Length)
                {
                    // All words are done - show final score
                    lblWord.Text = "You WON!";
                    lblAttempts.Text = "Perfect score!";

                    MessageBox.Show("Congratulations, You WON!\n\n"
                    + "Correct guesses: " + correctCount + "\n"
                    + "Wrong guesses: " + wrongCount + "\n"
                    + "Total words: " + words.Length,
                    "Final Score");
                }
                else
                {
                    // All words are done - show final score
                    lblWord.Text = "GAME OVER";
                    lblAttempts.Text = "No more words!";

                    MessageBox.Show("Game Over!\n\n"
                    + "Correct guesses: " + correctCount + "\n"
                    + "Wrong guesses: " + wrongCount + "\n"
                    + "Total words: " + words.Length,
                    "Final Score");
                }
                
            }
        }

        // Button click event - check if the guess is correct
        private void btnGuess_Click(object sender, EventArgs e)
        {
            // Get the user's guess and convert to lowercase using String methods
            string userGuess = txtGuess.Text.Trim().ToLower();
            string currentWord = words[currentWordIndex];

            // Validate that the textbox is not empty
            if (string.IsNullOrWhiteSpace(userGuess))
            {
                MessageBox.Show("Please enter a word.");
                txtGuess.Focus();
                return;
            }

            // Compare the guess with the current word using String.Equals method
            if (userGuess.Equals(currentWord))
            {
                // Correct guess - reveal the full word
                lblWord.Text = currentWord;
                correctCount++;
                UpdateScoreLabel();

                MessageBox.Show("Correct guess!\nMoving to the next word...");

                // Move to the next word
                NextWord();
            }
            else
            {
                // Wrong guess - add to the listbox
                currentAttempts++;
                wrongCount++;
                lstWrongGuess.Items.Add(userGuess);
                UpdateScoreLabel();
                UpdateAttemptsLabel();

                // Check if attempts are used up
                if (currentAttempts >= maxAttempts)
                {
                    MessageBox.Show("Out of attempts!\nThe word was: " + currentWord
                        + "\n\nMoving to the next word...");

                    // Move to the next word
                    NextWord();
                }
                else
                {
                    int remaining = maxAttempts - currentAttempts;
                    MessageBox.Show("Wrong guess!\nTry again. " + remaining + " attempts left.");
                }
            }

            // Clear the textbox for the next guess
            txtGuess.Clear();
            txtGuess.Focus();
        }
    }
}
