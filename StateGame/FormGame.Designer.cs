//////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//      Project:    State Matching Game
//
//    File Name:    FormGame.Designer.cs
//
//       Author:    Nicholas Yoder
//
//  Description:    FormGame is the form in which the state matching game is played. This file contains
//                  all controls that are part of the form.
//
//////////////////////////////////////////////////////////////////////////////////////////////////////////

namespace StateGame
{
    /// <summary>
    /// The form in which the state matching game is played
    /// </summary>
    partial class FormGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGame));
            this.listBoxCapitals = new System.Windows.Forms.ListBox();
            this.labelSelect = new System.Windows.Forms.Label();
            this.labelQuestion = new System.Windows.Forms.Label();
            this.textBoxQuestion = new System.Windows.Forms.TextBox();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.labelTimeLeft = new System.Windows.Forms.Label();
            this.textBoxTimeLeft = new System.Windows.Forms.TextBox();
            this.labelAttempts = new System.Windows.Forms.Label();
            this.labelCorrect = new System.Windows.Forms.Label();
            this.textBoxAttempts = new System.Windows.Forms.TextBox();
            this.textBoxCorrect = new System.Windows.Forms.TextBox();
            this.timerTimeLeft = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // listBoxCapitals
            // 
            this.listBoxCapitals.Enabled = false;
            this.listBoxCapitals.FormattingEnabled = true;
            this.listBoxCapitals.Location = new System.Drawing.Point(367, 37);
            this.listBoxCapitals.Name = "listBoxCapitals";
            this.listBoxCapitals.Size = new System.Drawing.Size(155, 238);
            this.listBoxCapitals.TabIndex = 0;
            this.listBoxCapitals.SelectedIndexChanged += new System.EventHandler(this.listBoxCapitals_SelectedIndexChanged);
            // 
            // labelSelect
            // 
            this.labelSelect.AutoSize = true;
            this.labelSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelect.Location = new System.Drawing.Point(363, 9);
            this.labelSelect.Name = "labelSelect";
            this.labelSelect.Size = new System.Drawing.Size(159, 20);
            this.labelSelect.TabIndex = 1;
            this.labelSelect.Text = "Select the Capital";
            // 
            // labelQuestion
            // 
            this.labelQuestion.AutoSize = true;
            this.labelQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuestion.Location = new System.Drawing.Point(12, 36);
            this.labelQuestion.Name = "labelQuestion";
            this.labelQuestion.Size = new System.Drawing.Size(172, 20);
            this.labelQuestion.TabIndex = 2;
            this.labelQuestion.Text = "What is the capital of:";
            // 
            // textBoxQuestion
            // 
            this.textBoxQuestion.Location = new System.Drawing.Point(190, 36);
            this.textBoxQuestion.Name = "textBoxQuestion";
            this.textBoxQuestion.ReadOnly = true;
            this.textBoxQuestion.Size = new System.Drawing.Size(143, 20);
            this.textBoxQuestion.TabIndex = 3;
            // 
            // buttonNext
            // 
            this.buttonNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNext.Location = new System.Drawing.Point(16, 230);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(140, 34);
            this.buttonNext.TabIndex = 4;
            this.buttonNext.Text = "Next Question";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.Location = new System.Drawing.Point(193, 230);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(140, 34);
            this.buttonExit.TabIndex = 5;
            this.buttonExit.Text = "End Game";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // labelTimeLeft
            // 
            this.labelTimeLeft.AutoSize = true;
            this.labelTimeLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.labelTimeLeft.Location = new System.Drawing.Point(75, 90);
            this.labelTimeLeft.Name = "labelTimeLeft";
            this.labelTimeLeft.Size = new System.Drawing.Size(157, 20);
            this.labelTimeLeft.TabIndex = 6;
            this.labelTimeLeft.Text = "Time left to answer:";
            // 
            // textBoxTimeLeft
            // 
            this.textBoxTimeLeft.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxTimeLeft.Enabled = false;
            this.textBoxTimeLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.25F, System.Drawing.FontStyle.Bold);
            this.textBoxTimeLeft.ForeColor = System.Drawing.Color.Red;
            this.textBoxTimeLeft.Location = new System.Drawing.Point(238, 74);
            this.textBoxTimeLeft.Name = "textBoxTimeLeft";
            this.textBoxTimeLeft.ReadOnly = true;
            this.textBoxTimeLeft.Size = new System.Drawing.Size(45, 44);
            this.textBoxTimeLeft.TabIndex = 7;
            this.textBoxTimeLeft.Text = "10";
            this.textBoxTimeLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelAttempts
            // 
            this.labelAttempts.AutoSize = true;
            this.labelAttempts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.labelAttempts.Location = new System.Drawing.Point(46, 142);
            this.labelAttempts.Name = "labelAttempts";
            this.labelAttempts.Size = new System.Drawing.Size(76, 20);
            this.labelAttempts.TabIndex = 8;
            this.labelAttempts.Text = "Attempts";
            // 
            // labelCorrect
            // 
            this.labelCorrect.AutoSize = true;
            this.labelCorrect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.labelCorrect.Location = new System.Drawing.Point(228, 142);
            this.labelCorrect.Name = "labelCorrect";
            this.labelCorrect.Size = new System.Drawing.Size(65, 20);
            this.labelCorrect.TabIndex = 9;
            this.labelCorrect.Text = "Correct";
            // 
            // textBoxAttempts
            // 
            this.textBoxAttempts.Location = new System.Drawing.Point(34, 165);
            this.textBoxAttempts.Name = "textBoxAttempts";
            this.textBoxAttempts.ReadOnly = true;
            this.textBoxAttempts.Size = new System.Drawing.Size(100, 20);
            this.textBoxAttempts.TabIndex = 10;
            this.textBoxAttempts.Text = "0";
            this.textBoxAttempts.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxCorrect
            // 
            this.textBoxCorrect.Location = new System.Drawing.Point(210, 165);
            this.textBoxCorrect.Name = "textBoxCorrect";
            this.textBoxCorrect.ReadOnly = true;
            this.textBoxCorrect.Size = new System.Drawing.Size(100, 20);
            this.textBoxCorrect.TabIndex = 11;
            this.textBoxCorrect.Text = "0";
            this.textBoxCorrect.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timerTimeLeft
            // 
            this.timerTimeLeft.Interval = 1000;
            this.timerTimeLeft.Tick += new System.EventHandler(this.timerTimeLeft_Tick);
            // 
            // FormGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 287);
            this.Controls.Add(this.textBoxCorrect);
            this.Controls.Add(this.textBoxAttempts);
            this.Controls.Add(this.labelCorrect);
            this.Controls.Add(this.labelAttempts);
            this.Controls.Add(this.textBoxTimeLeft);
            this.Controls.Add(this.labelTimeLeft);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.textBoxQuestion);
            this.Controls.Add(this.labelQuestion);
            this.Controls.Add(this.labelSelect);
            this.Controls.Add(this.listBoxCapitals);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "State Capital Matching Game";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormGame_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        /// <summary>
        /// A listbox containing all state capitals for the user to choose from
        /// </summary>
        private System.Windows.Forms.ListBox listBoxCapitals;

        /// <summary>
        /// A label prompting the user to select a capital
        /// </summary>
        private System.Windows.Forms.Label labelSelect;

        /// <summary>
        /// A label that identifies textBoxQuestion as the question being asked
        /// </summary>
        private System.Windows.Forms.Label labelQuestion;

        /// <summary>
        /// A textbox containing the current question being asked
        /// </summary>
        private System.Windows.Forms.TextBox textBoxQuestion;

        /// <summary>
        /// A button that begins the next round
        /// </summary>
        private System.Windows.Forms.Button buttonNext;

        /// <summary>
        /// A button that exits the game
        /// </summary>
        private System.Windows.Forms.Button buttonExit;

        /// <summary>
        /// A label that identifies textBoxTimeLeft as the amount of time left in the round
        /// </summary>
        private System.Windows.Forms.Label labelTimeLeft;

        /// <summary>
        /// A textbox containing the amount of time left in the round
        /// </summary>
        private System.Windows.Forms.TextBox textBoxTimeLeft;

        /// <summary>
        /// A label identifying textBoxAttempts as the number of questions attempted so far
        /// </summary>
        private System.Windows.Forms.Label labelAttempts;

        /// <summary>
        /// A label identifying textBoxCorrect as the number of questions answered correctly so far
        /// </summary>
        private System.Windows.Forms.Label labelCorrect;

        /// <summary>
        /// A textbox containing the number of questions attempted so far
        /// </summary>
        private System.Windows.Forms.TextBox textBoxAttempts;

        /// <summary>
        /// A textbox containing the number of questions answered correctly so far
        /// </summary>
        private System.Windows.Forms.TextBox textBoxCorrect;

        /// <summary>
        /// A timer used to keep track of the amount of time left in each round
        /// </summary>
        private System.Windows.Forms.Timer timerTimeLeft;
    }
}

