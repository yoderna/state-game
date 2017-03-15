//////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//      Project:    State Matching Game
//
//    File Name:    Program.cs
//
//       Author:    Nicholas Yoder
//
//  Description:    This file contains the program entry point, which is responsible for running
//                  forms used by this application.
//
//////////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Windows.Forms;

namespace StateGame
{
    /// <summary>
    /// Contains the entry point of the program
    /// </summary>
    static class Program
    {
        /// <summary>
        /// The entry point of the program; runs forms used by this application
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormSplash());
            Application.Run(new FormGame());
        }
    }
}
