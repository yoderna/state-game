//////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//      Project:    State Matching Game
//
//    File Name:    FormGoodbye.cs
//
//       Author:    Nicholas Yoder
//
//  Description:    This form displays a message for the user upon quitting the game.
//
//////////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Windows.Forms;

namespace StateGame
{
    /// <summary>
    /// This form displays a message for the user upon quitting the game
    /// </summary>
    public partial class FormGoodbye : Form
    {
        /// <summary>
        /// Creates a default exit message for the user
        /// </summary>
        public FormGoodbye()
        {
            InitializeComponent();
            textBoxGoodbye.Text = "Thank you for trying your luck at the State Capital Matching Game.";
        }

        /// <summary>
        /// Creates form with an exit message that displays the user's score
        /// </summary>
        /// <param name="score">The percent of questions the user answered correctly</param>
        /// <param name="attempts">The number of questions that were attempted</param>
        public FormGoodbye(float score, int attempts)
        {
            InitializeComponent();

            textBoxGoodbye.Text = "Thank you for trying your luck at the State Capital Matching Game.\r\n\r\n" +
                                  $"Your score was {score:0.#}% correct on {attempts} question" +
                                  ((attempts == 1) ? "." : "s.");   // If only one question was attempted,
                                                                    // "question" should not be plural
        }

        /// <summary>
        /// Closes the form when OK button is clicked
        /// </summary>
        private void buttonOK_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
