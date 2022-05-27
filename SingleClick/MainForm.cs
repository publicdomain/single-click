// <copyright file="MainForm.cs" company="PublicDomain.is">
//     CC0 1.0 Universal (CC0 1.0) - Public Domain Dedication
//     https://creativecommons.org/publicdomain/zero/1.0/legalcode
// </copyright>
namespace SingleClick
{
    // Directives
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Drawing;
    using System.Windows.Forms;
    using Gma.System.MouseKeyHook;

    /// <summary>
    /// Description of MainForm.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// The m global hook.
        /// </summary>
        private IKeyboardMouseEvents m_GlobalHook;

        /// <summary>
        /// The passed.
        /// </summary>
        private int passed = 0;

        /// <summary>
        /// The blocked.
        /// </summary>
        private int blocked = 0;
        /// <summary>
        /// The suppress click.
        /// </summary>
        private bool suppressClick = false;

        /// <summary>
        /// Initializes a new instance of the <see cref="T:SingleClick.MainForm"/> class.
        /// </summary>
        public MainForm()
        {
            // The InitializeComponent() call is required for Windows Forms designer support.
            this.InitializeComponent();
        }

        /// <summary>
        /// Handles the start stop button click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnStartStopButtonClick(object sender, EventArgs e)
        {
            // Check for Star(t) vs Sto(p)
            if (this.startStopButton.Text.EndsWith("t", StringComparison.InvariantCulture))
            {
                // Change to stop
                this.startStopButton.Text = "&Stop";
                this.startStopButton.ForeColor = Color.Red;

                // Start
                this.Subscribe();
            }
            else
            {
                // Reset to start
                this.startStopButton.Text = "&Start";
                this.startStopButton.ForeColor = Color.DarkGreen;

                // Stop
                this.Unsubscribe();
            }
        }

        /// <summary>
        /// Handles the new tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnNewToolStripMenuItemClick(object sender, EventArgs e)
        {
            // TODO Stop [Can be made DRY with a separate function]
            if (this.startStopButton.Text.EndsWith("p", StringComparison.InvariantCulture))
            {
                // Reset to start
                this.startStopButton.Text = "&Start";
                this.startStopButton.ForeColor = Color.DarkGreen;

                // Stop
                this.Unsubscribe();
            }

            // Reset counters
            this.passed = 0;
            this.blocked = 0;

            // TODO Update status labels [Can be made DRY with a separate function]
            this.passedToolStripStatusLabel.Text = this.passed.ToString();
            this.blockedToolStripStatusLabel.Text = this.blocked.ToString();
        }

        /// <summary>
        /// Handles the options tool strip menu item drop down item clicked.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnOptionsToolStripMenuItemDropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            // TODO Add code
        }

        /// <summary>
        /// Handles the free releases public domainis tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnFreeReleasesPublicDomainisToolStripMenuItemClick(object sender, EventArgs e)
        {
            // TODO Add code
        }

        /// <summary>
        /// Handles the original thread redditcom tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnOriginalThreadRedditcomToolStripMenuItemClick(object sender, EventArgs e)
        {
            // TODO Add code
        }

        /// <summary>
        /// Handles the source code githubcom tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnSourceCodeGithubcomToolStripMenuItemClick(object sender, EventArgs e)
        {
            // TODO Add code
        }

        /// <summary>
        /// Handles the about tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnAboutToolStripMenuItemClick(object sender, EventArgs e)
        {
            // TODO Add code
        }

        /// <summary>
        /// Globals the hook mouse up ext.
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="e">E.</param>
        private void GlobalHookMouseUpExt(object sender, MouseEventExtArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (!this.suppressClick)
                {
                    // First click, toggle
                    this.suppressClick = true;

                    this.passed++;
                }
                else
                {
                    e.Handled = true;

                    this.blocked++;

                    // Toggle back
                    this.suppressClick = false;
                }
            }

            // Update status labels
            this.passedToolStripStatusLabel.Text = this.passed.ToString();
            this.blockedToolStripStatusLabel.Text = this.blocked.ToString();
        }

        /// <summary>
        /// Globals the hook mouse down ext.
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="e">E.</param>
        private void GlobalHookMouseDownExt(object sender, MouseEventExtArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (this.suppressClick)
                {
                    e.Handled = true;
                }
            }
        }

        /// <summary>
        /// Subscribe this instance.
        /// </summary>
        private void Subscribe()
        {
            m_GlobalHook = Hook.GlobalEvents();

            m_GlobalHook.MouseDownExt += GlobalHookMouseDownExt;
            m_GlobalHook.MouseUpExt += GlobalHookMouseUpExt;
        }

        /// <summary>
        /// Unsubscribe this instance.
        /// </summary>
        public void Unsubscribe()
        {
            m_GlobalHook.MouseDownExt -= GlobalHookMouseDownExt;
            m_GlobalHook.MouseUpExt -= GlobalHookMouseUpExt;

            m_GlobalHook.Dispose();

            // Toggle back
            this.suppressClick = false;
        }

        /// <summary>
        /// Handles the time numeric up down value changed.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnTimeNumericUpDownValueChanged(object sender, EventArgs e)
        {
            // Set timer interval
            this.clickTimer.Interval = (int)this.timeNumericUpDown.Value;
        }

        /// <summary>
        /// Handles the click timer tick.
        /// </summary>
        /// <param name="sender">Sender.</param>/// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnClickTimerTick(object sender, EventArgs e)
        {
            // Toggle back
            this.suppressClick = false;

            // Disable timer
            this.clickTimer.Stop();
        }

        /// <summary>
        /// Handles the exit tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnExitToolStripMenuItemClick(object sender, EventArgs e)
        {
            // TODO Add code
        }
    }
}
