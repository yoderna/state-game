//////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//      Project:    State Matching Game
//
//    File Name:    FormSplash.cs
//
//       Author:    Nicholas Yoder
//
//  Description:    This form is a brief splash screen that is shown for a short time when the program
//                  is run. It disappears after a short time.
//
//////////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Windows.Forms;

namespace StateGame
{
    /// <summary>
    /// This form is a brief splash screen that is shown for a short time when the program is run
    /// </summary>
    public partial class FormSplash : Form
    {
        /// <summary>
        /// Prepares the form for use
        /// </summary>
        public FormSplash()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Closes the splash screen on timer tick
        /// </summary>
        private void timerSplash_Tick(object sender, EventArgs e)
        {
            Close();
        }
    }
}
