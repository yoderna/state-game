//////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//      Project:    State Matching Game
//
//    File Name:    FormGoodbye.Designer.cs
//
//       Author:    Nicholas Yoder
//
//  Description:    FormGoodbye displays a message for the user upon quitting the game.
//                  This file contains all controls used by the form.
//
//////////////////////////////////////////////////////////////////////////////////////////////////////////

namespace StateGame
{
    /// <summary>
    /// This form displays a message for the user upon quitting the game
    /// </summary>
    partial class FormGoodbye
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGoodbye));
            this.textBoxGoodbye = new System.Windows.Forms.TextBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxGoodbye
            // 
            this.textBoxGoodbye.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxGoodbye.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.textBoxGoodbye.ForeColor = System.Drawing.Color.White;
            this.textBoxGoodbye.Location = new System.Drawing.Point(0, 0);
            this.textBoxGoodbye.Multiline = true;
            this.textBoxGoodbye.Name = "textBoxGoodbye";
            this.textBoxGoodbye.ReadOnly = true;
            this.textBoxGoodbye.Size = new System.Drawing.Size(384, 116);
            this.textBoxGoodbye.TabIndex = 0;
            this.textBoxGoodbye.TabStop = false;
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(273, 122);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(99, 28);
            this.buttonOK.TabIndex = 1;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // GoodbyeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 162);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.textBoxGoodbye);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GoodbyeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thank You";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        /// <summary>
        /// A textbox containing a goodbye message for the user, including their score
        /// </summary>
        private System.Windows.Forms.TextBox textBoxGoodbye;

        /// <summary>
        /// A button that closes the form when clicked
        /// </summary>
        private System.Windows.Forms.Button buttonOK;
    }
}