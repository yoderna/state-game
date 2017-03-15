//////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//      Project:    State Matching Game
//
//    File Name:    FormGame.cs
//
//       Author:    Nicholas Yoder
//
//  Description:    FormGame is the form in which the state matching game is played. This file contains
//                  all event handlers and other functions related to the game.
//
//////////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Reflection;

namespace StateGame
{
    /// <summary>
    /// The form in which the state matching game is played
    /// </summary>
    public partial class FormGame : Form
    {
        /// <summary>
        /// Maps all capitals to their respective states
        /// </summary>
        private SortedDictionary<string, string> capitalStatePairs;

        /// <summary>
        /// A uniform random number generator used to select questions
        /// </summary>
        private Random rng;

        /// <summary>
        /// The current state that the user is being asked about
        /// </summary>
        private string currQuestion;

        /// <summary>
        /// Populates answers with state/capital data and initializes controls
        /// </summary>
        public FormGame()
        {
            InitializeComponent();

            ReadCapitalStatePairs();

            rng = new Random();
        }

        /// <summary>
        /// Populates stateCapitalPairs with data from States.txt
        /// </summary>
        private void ReadCapitalStatePairs()
        {
            capitalStatePairs = new SortedDictionary<string, string>();

            // Open the embedded resource States.txt
            StreamReader reader = new StreamReader(
                Assembly.GetExecutingAssembly().GetManifestResourceStream("StateGame.Resources.States.txt"));

            // Read each line, which contains comma-delimited information on each state's capital
            // Process each line and add the pair to capitalStatePairs
            string line;

            while ((line = reader.ReadLine()) != null)
            {
                string[] pair = line.Split(',');

                pair[1].Trim(" \r\n".ToCharArray());
                pair[0].Trim(" \r\n".ToCharArray());

                capitalStatePairs.Add(pair[0], pair[1]);
            }

            // Add the sorted capitals to listBoxCapitals
            foreach (string s in capitalStatePairs.Keys)
            {
                listBoxCapitals.Items.Add(s);
            }
        }

        /// <summary>
        /// Ends a turn of the game
        /// </summary>
        /// <param name="answeredCorrectly">Indicates whether the user answered the question correctly or not</param>
        private void EndTurn(bool answeredCorrectly)
        {
            // Disable or enable all necessary controls to end the round
            timerTimeLeft.Enabled = false;
            textBoxTimeLeft.Enabled = false;
            listBoxCapitals.Enabled = false;
            buttonNext.Enabled = true;

            // Increment questions attempted, and if necessary, number of questions answered correctly
            textBoxAttempts.Text = (int.Parse(textBoxAttempts.Text) + 1).ToString();

            if (answeredCorrectly)
            {
                textBoxCorrect.Text = (int.Parse(textBoxCorrect.Text) + 1).ToString();
            }
        }

        #region Control Events
        /// <summary>
        /// Closes the form when the user clicks "End Game"
        /// </summary>
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Decrements the timer on tick events and ends the user's turn when 0
        /// </summary>
        private void timerTimeLeft_Tick(object sender, EventArgs e)
        {
            textBoxTimeLeft.Text = (int.Parse(textBoxTimeLeft.Text) - 1).ToString();

            if (textBoxTimeLeft.Text == "0")
            {
                EndTurn(false);
            }
        }

        /// <summary>
        /// Begins a new turn
        /// </summary>
        private void buttonNext_Click(object sender, EventArgs e)
        {
            // Enable or disable all necessary controls for the new round
            timerTimeLeft.Enabled = true;
            textBoxTimeLeft.Enabled = true;
            listBoxCapitals.Enabled = true;
            buttonNext.Enabled = false;

            textBoxTimeLeft.Text = "10";

            // Randomly select a new question
            currQuestion = capitalStatePairs.Values.ElementAt(rng.Next(50));

            textBoxQuestion.Text = currQuestion;
        }

        /// <summary>
        /// When the user selects an answer, determines if
        /// it is correct or incorrect and ends the turn
        /// </summary>
        private void listBoxCapitals_SelectedIndexChanged(object sender, EventArgs e)
        {
            string capitalChosen = listBoxCapitals.SelectedItem as string;

            // End turn with TRUE passed if answer is correct, FALSE if incorrect
            EndTurn(capitalStatePairs[capitalChosen] == currQuestion);
        }

        /// <summary>
        /// Event when the form is closed for any reason; displays an exit message for the user
        /// </summary>
        private void FormGame_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (textBoxAttempts.Text != "0")
            {
                int attempts = int.Parse(textBoxAttempts.Text),
                    correct = int.Parse(textBoxCorrect.Text);

                float score = ((float)correct / attempts) * 100;

                FormGoodbye fgb = new FormGoodbye(score, attempts);

                fgb.ShowDialog();
            }
        }
        #endregion
    }
}
